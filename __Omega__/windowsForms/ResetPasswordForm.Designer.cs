namespace OmegaSportExplorerClub.windowsForms
{
    partial class ResetPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
            commitButton = new MaterialSkin.Controls.MaterialButton();
            verificationCodeTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            NewPsswordTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            NewPsswordRepeatTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            AccountNAmePlaceholder = new MaterialSkin.Controls.MaterialLabel();
            returnButton = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // commitButton
            // 
            commitButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            commitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            commitButton.Depth = 0;
            commitButton.HighEmphasis = true;
            commitButton.Icon = (Image)resources.GetObject("commitButton.Icon");
            commitButton.Location = new Point(226, 534);
            commitButton.Margin = new Padding(4, 6, 4, 6);
            commitButton.MouseState = MaterialSkin.MouseState.HOVER;
            commitButton.Name = "commitButton";
            commitButton.NoAccentTextColor = Color.Empty;
            commitButton.Size = new Size(191, 36);
            commitButton.TabIndex = 0;
            commitButton.Text = "Change password";
            commitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            commitButton.UseAccentColor = false;
            commitButton.UseVisualStyleBackColor = true;
            commitButton.Click += commitButton_Click;
            // 
            // verificationCodeTextBox
            // 
            verificationCodeTextBox.AnimateReadOnly = false;
            verificationCodeTextBox.BackgroundImageLayout = ImageLayout.None;
            verificationCodeTextBox.CharacterCasing = CharacterCasing.Normal;
            verificationCodeTextBox.Depth = 0;
            verificationCodeTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            verificationCodeTextBox.HelperText = "00AA00";
            verificationCodeTextBox.HideSelection = true;
            verificationCodeTextBox.Hint = "00AA00";
            verificationCodeTextBox.LeadingIcon = null;
            verificationCodeTextBox.Location = new Point(33, 59);
            verificationCodeTextBox.MaxLength = 32767;
            verificationCodeTextBox.MouseState = MaterialSkin.MouseState.OUT;
            verificationCodeTextBox.Name = "verificationCodeTextBox";
            verificationCodeTextBox.PasswordChar = '\0';
            verificationCodeTextBox.PrefixSuffixText = null;
            verificationCodeTextBox.ReadOnly = false;
            verificationCodeTextBox.RightToLeft = RightToLeft.No;
            verificationCodeTextBox.SelectedText = "";
            verificationCodeTextBox.SelectionLength = 0;
            verificationCodeTextBox.SelectionStart = 0;
            verificationCodeTextBox.ShortcutsEnabled = true;
            verificationCodeTextBox.Size = new Size(250, 48);
            verificationCodeTextBox.TabIndex = 1;
            verificationCodeTextBox.TabStop = false;
            verificationCodeTextBox.TextAlign = HorizontalAlignment.Left;
            verificationCodeTextBox.TrailingIcon = null;
            verificationCodeTextBox.UseSystemPasswordChar = false;
            verificationCodeTextBox.TextChanged += verificationCodeTextBox_TextChanged;
            // 
            // NewPsswordTextBox
            // 
            NewPsswordTextBox.AnimateReadOnly = false;
            NewPsswordTextBox.BackgroundImageLayout = ImageLayout.None;
            NewPsswordTextBox.CharacterCasing = CharacterCasing.Normal;
            NewPsswordTextBox.Depth = 0;
            NewPsswordTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            NewPsswordTextBox.HelperText = "At least 6 characters and at least 1 number";
            NewPsswordTextBox.HideSelection = true;
            NewPsswordTextBox.Hint = "At least 6 characters and at least 1 number";
            NewPsswordTextBox.LeadingIcon = null;
            NewPsswordTextBox.Location = new Point(33, 253);
            NewPsswordTextBox.MaxLength = 30;
            NewPsswordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            NewPsswordTextBox.Name = "NewPsswordTextBox";
            NewPsswordTextBox.PasswordChar = '*';
            NewPsswordTextBox.PrefixSuffixText = null;
            NewPsswordTextBox.ReadOnly = false;
            NewPsswordTextBox.RightToLeft = RightToLeft.No;
            NewPsswordTextBox.SelectedText = "";
            NewPsswordTextBox.SelectionLength = 0;
            NewPsswordTextBox.SelectionStart = 0;
            NewPsswordTextBox.ShortcutsEnabled = true;
            NewPsswordTextBox.Size = new Size(250, 48);
            NewPsswordTextBox.TabIndex = 2;
            NewPsswordTextBox.TabStop = false;
            NewPsswordTextBox.TextAlign = HorizontalAlignment.Left;
            NewPsswordTextBox.TrailingIcon = null;
            NewPsswordTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            materialLabel1.HighEmphasis = true;
            materialLabel1.Location = new Point(81, 50);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(319, 41);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "Password reset form";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel2.Location = new Point(33, 32);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(200, 24);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Your verification code:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel3.Location = new Point(33, 226);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(137, 24);
            materialLabel3.TabIndex = 5;
            materialLabel3.Text = "New password:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel4.Location = new Point(33, 321);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(202, 24);
            materialLabel4.TabIndex = 7;
            materialLabel4.Text = "Repeat new password:";
            // 
            // NewPsswordRepeatTextBox
            // 
            NewPsswordRepeatTextBox.AnimateReadOnly = false;
            NewPsswordRepeatTextBox.BackgroundImageLayout = ImageLayout.None;
            NewPsswordRepeatTextBox.CharacterCasing = CharacterCasing.Normal;
            NewPsswordRepeatTextBox.Depth = 0;
            NewPsswordRepeatTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            NewPsswordRepeatTextBox.HelperText = "Verifi your password";
            NewPsswordRepeatTextBox.HideSelection = true;
            NewPsswordRepeatTextBox.Hint = "Verifi your password";
            NewPsswordRepeatTextBox.LeadingIcon = null;
            NewPsswordRepeatTextBox.Location = new Point(33, 348);
            NewPsswordRepeatTextBox.MaxLength = 30;
            NewPsswordRepeatTextBox.MouseState = MaterialSkin.MouseState.OUT;
            NewPsswordRepeatTextBox.Name = "NewPsswordRepeatTextBox";
            NewPsswordRepeatTextBox.PasswordChar = '*';
            NewPsswordRepeatTextBox.PrefixSuffixText = null;
            NewPsswordRepeatTextBox.ReadOnly = false;
            NewPsswordRepeatTextBox.RightToLeft = RightToLeft.No;
            NewPsswordRepeatTextBox.SelectedText = "";
            NewPsswordRepeatTextBox.SelectionLength = 0;
            NewPsswordRepeatTextBox.SelectionStart = 0;
            NewPsswordRepeatTextBox.ShortcutsEnabled = true;
            NewPsswordRepeatTextBox.Size = new Size(250, 48);
            NewPsswordRepeatTextBox.TabIndex = 6;
            NewPsswordRepeatTextBox.TabStop = false;
            NewPsswordRepeatTextBox.TextAlign = HorizontalAlignment.Left;
            NewPsswordRepeatTextBox.TrailingIcon = null;
            NewPsswordRepeatTextBox.UseSystemPasswordChar = false;
            // 
            // AccountNAmePlaceholder
            // 
            AccountNAmePlaceholder.AutoSize = true;
            AccountNAmePlaceholder.Depth = 0;
            AccountNAmePlaceholder.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            AccountNAmePlaceholder.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            AccountNAmePlaceholder.Location = new Point(86, 157);
            AccountNAmePlaceholder.MouseState = MaterialSkin.MouseState.HOVER;
            AccountNAmePlaceholder.Name = "AccountNAmePlaceholder";
            AccountNAmePlaceholder.Size = new Size(132, 24);
            AccountNAmePlaceholder.TabIndex = 8;
            AccountNAmePlaceholder.Text = "Account Name";
            // 
            // returnButton
            // 
            returnButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            returnButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            returnButton.Depth = 0;
            returnButton.HighEmphasis = true;
            returnButton.Icon = (Image)resources.GetObject("returnButton.Icon");
            returnButton.Location = new Point(66, 534);
            returnButton.Margin = new Padding(4, 6, 4, 6);
            returnButton.MouseState = MaterialSkin.MouseState.HOVER;
            returnButton.Name = "returnButton";
            returnButton.NoAccentTextColor = Color.Empty;
            returnButton.Size = new Size(105, 36);
            returnButton.TabIndex = 9;
            returnButton.Text = "Return";
            returnButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            returnButton.UseAccentColor = false;
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(verificationCodeTextBox);
            materialCard1.Controls.Add(AccountNAmePlaceholder);
            materialCard1.Controls.Add(NewPsswordTextBox);
            materialCard1.Controls.Add(materialLabel4);
            materialCard1.Controls.Add(materialLabel3);
            materialCard1.Controls.Add(NewPsswordRepeatTextBox);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(81, 105);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(319, 442);
            materialCard1.TabIndex = 10;
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 612);
            Controls.Add(returnButton);
            Controls.Add(materialLabel1);
            Controls.Add(commitButton);
            Controls.Add(materialCard1);
            FormStyle = FormStyles.ActionBar_None;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ResetPasswordForm";
            Padding = new Padding(3, 24, 3, 3);
            Sizable = false;
            Text = "ResetPasswordForm";
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton commitButton;
        private MaterialSkin.Controls.MaterialTextBox2 verificationCodeTextBox;
        private MaterialSkin.Controls.MaterialTextBox2 NewPsswordTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 NewPsswordRepeatTextBox;
        private MaterialSkin.Controls.MaterialLabel AccountNAmePlaceholder;
        private MaterialSkin.Controls.MaterialButton returnButton;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}