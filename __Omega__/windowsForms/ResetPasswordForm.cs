using MaterialSkin;
using MaterialSkin.Controls;
using OmegaSportExplorerClub.src.User;

namespace OmegaSportExplorerClub.windowsForms
{
    public partial class ResetPasswordForm : MaterialForm
    {

        private static ResetPasswordForm instance = null;
        private UserResetPassword reset = new UserResetPassword();
        public ResetPasswordForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Color.FromArgb(177, 195, 88), Color.FromArgb(64, 64, 64), Color.FromArgb(255, 255, 252), Color.FromArgb(177, 195, 88), TextShade.BLACK);
            verificationCodeTextBox.SetErrorState(true);
        }
        public static ResetPasswordForm GetInstance()
        {
            if (instance == null)
            {
                instance = new ResetPasswordForm();
            }
            return instance;

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn.GetInstance().Show();
        }

        private void verificationCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (verificationCodeTextBox.Text.Length == 6)
            {
                verificationCodeTextBox.SetErrorState(false);
                User user = new User()
                {
                    VerificationCode = verificationCodeTextBox.Text,
                };
                reset = new UserResetPassword(user);
                reset.GetUsername();
                if (reset.User.UserName == null)
                {
                    verificationCodeTextBox.SetErrorState(true);
                    return;
                }
                else
                {
                    verificationCodeTextBox.SetErrorState(false);
                    AccountNAmePlaceholder.Text = reset.User.UserName;
                    return;
                }

            }
            else
            {
                verificationCodeTextBox.SetErrorState(true);
            }
        }

        private void commitButton_Click(object sender, EventArgs e)
        {
            if (NewPsswordRepeatTextBox.Text == NewPsswordTextBox.Text && verificationCodeTextBox.GetErrorState() != true)
            {
                var result = reset.ChangePassword(NewPsswordRepeatTextBox.Text);
                if (result == true)
                {
                    MessageBox.Show("Change of password was succesfull!");
                    LogIn.GetInstance().Show();
                    this.Close();

                    return;
                }
                MessageBox.Show("Change of password wasn't succesfull!");

            }
            else
            {
                NewPsswordRepeatTextBox.SetErrorState(true);
            }

        }
    }
}
