namespace iaFinal1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.NewUser = new System.Windows.Forms.Button();
            this.ForgotPass = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsertypeComboBox = new System.Windows.Forms.ComboBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.RKLogo = new System.Windows.Forms.PictureBox();
            this.BlueDesign = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.RKLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // NewUser
            // 
            this.NewUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NewUser.FlatAppearance.BorderSize = 0;
            this.NewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.NewUser.ForeColor = System.Drawing.Color.DimGray;
            this.NewUser.Location = new System.Drawing.Point(320, 354);
            this.NewUser.Margin = new System.Windows.Forms.Padding(2);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(129, 37);
            this.NewUser.TabIndex = 31;
            this.NewUser.Text = "new user registration";
            this.NewUser.UseVisualStyleBackColor = false;
            this.NewUser.Click += new System.EventHandler(this.NewUser_Click);
            // 
            // ForgotPass
            // 
            this.ForgotPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ForgotPass.FlatAppearance.BorderSize = 0;
            this.ForgotPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForgotPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.ForgotPass.ForeColor = System.Drawing.Color.DimGray;
            this.ForgotPass.Location = new System.Drawing.Point(320, 313);
            this.ForgotPass.Margin = new System.Windows.Forms.Padding(2);
            this.ForgotPass.Name = "ForgotPass";
            this.ForgotPass.Size = new System.Drawing.Size(129, 37);
            this.ForgotPass.TabIndex = 30;
            this.ForgotPass.Text = "forgot password";
            this.ForgotPass.UseVisualStyleBackColor = false;
            this.ForgotPass.Click += new System.EventHandler(this.ForgotPass_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.CloseButton.Location = new System.Drawing.Point(655, 19);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CloseButton.Size = new System.Drawing.Size(33, 32);
            this.CloseButton.TabIndex = 29;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.LoginButton.Location = new System.Drawing.Point(320, 272);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(129, 37);
            this.LoginButton.TabIndex = 28;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Password.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultText = "";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password.Location = new System.Drawing.Point(378, 224);
            this.Password.Margin = new System.Windows.Forms.Padding(2);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '\0';
            this.Password.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Password.PlaceholderText = "enter password here";
            this.Password.SelectedText = "";
            this.Password.Size = new System.Drawing.Size(169, 29);
            this.Password.TabIndex = 27;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Username.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.DefaultText = "";
            this.Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Black;
            this.Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username.Location = new System.Drawing.Point(378, 190);
            this.Username.Margin = new System.Windows.Forms.Padding(2);
            this.Username.Name = "Username";
            this.Username.PasswordChar = '\0';
            this.Username.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Username.PlaceholderText = "enter username here";
            this.Username.SelectedText = "";
            this.Username.Size = new System.Drawing.Size(169, 20);
            this.Username.TabIndex = 26;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.PasswordLabel.Location = new System.Drawing.Point(258, 224);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(113, 23);
            this.PasswordLabel.TabIndex = 25;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.UsernameLabel.Location = new System.Drawing.Point(258, 187);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(116, 23);
            this.UsernameLabel.TabIndex = 24;
            this.UsernameLabel.Text = "Username:";
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // UsertypeComboBox
            // 
            this.UsertypeComboBox.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsertypeComboBox.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.UsertypeComboBox.FormattingEnabled = true;
            this.UsertypeComboBox.Items.AddRange(new object[] {
            "Manager",
            "Cashier"});
            this.UsertypeComboBox.Location = new System.Drawing.Point(302, 144);
            this.UsertypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsertypeComboBox.Name = "UsertypeComboBox";
            this.UsertypeComboBox.Size = new System.Drawing.Size(147, 25);
            this.UsertypeComboBox.TabIndex = 23;
            this.UsertypeComboBox.Text = "Select User Type";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.LoginLabel.Location = new System.Drawing.Point(324, 100);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(107, 32);
            this.LoginLabel.TabIndex = 22;
            this.LoginLabel.Text = "LOGIN";
            // 
            // RKLogo
            // 
            this.RKLogo.Image = ((System.Drawing.Image)(resources.GetObject("RKLogo.Image")));
            this.RKLogo.Location = new System.Drawing.Point(347, 29);
            this.RKLogo.Margin = new System.Windows.Forms.Padding(2);
            this.RKLogo.Name = "RKLogo";
            this.RKLogo.Size = new System.Drawing.Size(53, 58);
            this.RKLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RKLogo.TabIndex = 21;
            this.RKLogo.TabStop = false;
            // 
            // BlueDesign
            // 
            this.BlueDesign.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BlueDesign.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BlueDesign.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BlueDesign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BlueDesign.FillColor = System.Drawing.Color.RoyalBlue;
            this.BlueDesign.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BlueDesign.ForeColor = System.Drawing.Color.White;
            this.BlueDesign.Location = new System.Drawing.Point(-186, -1);
            this.BlueDesign.Margin = new System.Windows.Forms.Padding(2);
            this.BlueDesign.Name = "BlueDesign";
            this.BlueDesign.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BlueDesign.Size = new System.Drawing.Size(386, 432);
            this.BlueDesign.TabIndex = 32;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(712, 431);
            this.Controls.Add(this.BlueDesign);
            this.Controls.Add(this.NewUser);
            this.Controls.Add(this.ForgotPass);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UsertypeComboBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.RKLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "c";
            ((System.ComponentModel.ISupportInitialize)(this.RKLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewUser;
        private System.Windows.Forms.Button ForgotPass;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button LoginButton;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2TextBox Username;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.ComboBox UsertypeComboBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.PictureBox RKLogo;
        private Guna.UI2.WinForms.Guna2CircleButton BlueDesign;
    }
}