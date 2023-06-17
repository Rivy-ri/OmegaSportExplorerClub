using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OmegaSportExplorerClub.src.User
{
    public class UserResetPassword
    {
        private User user;

        public UserResetPassword(User user)
        {
            User = user;
        }
        public UserResetPassword()
        {
            
        }

        public User User { get => user; set => user = value; }

        /// <summary>
        /// Method will get username base on security code
        /// </summary>
        public void GetUsername()
        {
            var connection = Connection.ConnectionSingleton.Connection();
            string commandText = "Select [name] from [dbo].[AplicationUser] where [verification_code]=@verificationCode";
            using (SqlCommand command=new SqlCommand(commandText,connection))
            {
                SqlParameter codeParameter = new SqlParameter("@verificationCode",System.Data.SqlDbType.VarChar,6);
                codeParameter.Value = User.VerificationCode;
                command.Parameters.Add(codeParameter);
                try
                { 
                    user.UserName = command.ExecuteScalar().ToString();
                    return;
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return ;
                }
            }
        }
        /// <summary>
        /// MEtchod will upodate in database salt and hashed password with a new
        /// </summary>
        /// <param name="newPassword">New password for account</param>
        /// <returns>true if chnage was succesfull</returns>
         public bool ChangePassword(string newPassword) 
        {
            var saltValue = BCrypt.Net.BCrypt.GenerateSalt();
            var hashVal=BCrypt.Net.BCrypt.HashPassword(newPassword, saltValue);
           var connection= Connection.ConnectionSingleton.Connection();
           string commandText = "Update AplicationUser set salt=@salt,hash=@hashedPassword where verification_code=@verificationCode";
           using(TransactionScope scope=new TransactionScope())
            {
                using(SqlCommand command=new SqlCommand(commandText, connection))
                {
                    SqlParameter salt = new SqlParameter("@salt", System.Data.SqlDbType.VarChar);
                    SqlParameter hashedPassword = new SqlParameter("@hashedPassword", System.Data.SqlDbType.VarChar);
                    SqlParameter verificationCode = new SqlParameter("@verificationCode",System.Data.SqlDbType.VarChar);
                    salt.Value = saltValue;
                    hashedPassword.Value = hashVal;
                    verificationCode.Value=user.VerificationCode;
                    command.Parameters.Add(salt);
                    command.Parameters.Add(hashedPassword); 
                    command.Parameters.Add(verificationCode);
                    if (command.ExecuteNonQuery()>0)
                    {
                        scope.Complete();
                        return true;
                    }
                    else
                    {
                        scope.Dispose();
                        return false;

                    }
                }
            }

        }
    }
}
