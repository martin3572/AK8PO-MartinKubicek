
namespace GetDataFromDatabase
{
    partial class LoginForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.discardUsername = new System.Windows.Forms.Button();
            this.discardPassword = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.incorectLogin = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.Location = new System.Drawing.Point(263, 144);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(107, 46);
            usernameLabel.TabIndex = 19;
            usernameLabel.Text = "Meno:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(264, 277);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(106, 46);
            passwordLabel.TabIndex = 20;
            passwordLabel.Text = "Heslo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 46);
            this.label1.TabIndex = 26;
            this.label1.Text = "Prihlásenie zamestnanca";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // discardUsername
            // 
            this.discardUsername.BackColor = System.Drawing.Color.Transparent;
            this.discardUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("discardUsername.BackgroundImage")));
            this.discardUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.discardUsername.FlatAppearance.BorderSize = 0;
            this.discardUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discardUsername.Location = new System.Drawing.Point(443, 189);
            this.discardUsername.Name = "discardUsername";
            this.discardUsername.Size = new System.Drawing.Size(43, 42);
            this.discardUsername.TabIndex = 25;
            this.discardUsername.UseVisualStyleBackColor = false;
            this.discardUsername.Click += new System.EventHandler(this.discardUsername_Click);
            // 
            // discardPassword
            // 
            this.discardPassword.BackColor = System.Drawing.Color.Transparent;
            this.discardPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("discardPassword.BackgroundImage")));
            this.discardPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.discardPassword.FlatAppearance.BorderSize = 0;
            this.discardPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discardPassword.Location = new System.Drawing.Point(443, 315);
            this.discardPassword.Name = "discardPassword";
            this.discardPassword.Size = new System.Drawing.Size(43, 42);
            this.discardPassword.TabIndex = 24;
            this.discardPassword.UseVisualStyleBackColor = false;
            this.discardPassword.Click += new System.EventHandler(this.discardPassword_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(196, 326);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(241, 31);
            this.password.TabIndex = 23;
            this.password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(196, 193);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(241, 31);
            this.username.TabIndex = 22;
            // 
            // loginButton
            // 
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(271, 391);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(114, 44);
            this.loginButton.TabIndex = 21;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // incorectLogin
            // 
            this.incorectLogin.AutoSize = true;
            this.incorectLogin.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorectLogin.ForeColor = System.Drawing.Color.Red;
            this.incorectLogin.Location = new System.Drawing.Point(232, 98);
            this.incorectLogin.Name = "incorectLogin";
            this.incorectLogin.Size = new System.Drawing.Size(168, 27);
            this.incorectLogin.TabIndex = 27;
            this.incorectLogin.Text = "Nesprávne údaje!";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.incorectLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.discardUsername);
            this.Controls.Add(this.discardPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(passwordLabel);
            this.Name = "LoginForm";
            this.Size = new System.Drawing.Size(645, 486);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button discardUsername;
        private System.Windows.Forms.Button discardPassword;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label incorectLogin;
    }
}
