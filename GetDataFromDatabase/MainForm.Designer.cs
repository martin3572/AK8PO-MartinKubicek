
namespace GetDataFromDatabase
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.order = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newReview = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.reviewForm = new System.Windows.Forms.Button();
            this.reservation = new System.Windows.Forms.Button();
            this.minimalizeButton = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.reviews2 = new GetDataFromDatabase.Reviews();
            this.menu2 = new GetDataFromDatabase.Menu();
            this.addNewItem1 = new GetDataFromDatabase.AddNewItem();
            this.loginForm1 = new GetDataFromDatabase.LoginForm();
            this.reservation1 = new GetDataFromDatabase.Reservation();
            this.addReview1 = new GetDataFromDatabase.AddReview();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // order
            // 
            this.order.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.order.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.order.Location = new System.Drawing.Point(22, 24);
            this.order.Margin = new System.Windows.Forms.Padding(0);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(197, 65);
            this.order.TabIndex = 0;
            this.order.Text = "Denné Menu";
            this.order.UseVisualStyleBackColor = false;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuText;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(141, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Restaurant Ordering And Reservation System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.newReview);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.reviewForm);
            this.panel1.Controls.Add(this.reservation);
            this.panel1.Controls.Add(this.order);
            this.panel1.Location = new System.Drawing.Point(22, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 488);
            this.panel1.TabIndex = 2;
            // 
            // newReview
            // 
            this.newReview.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.newReview.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newReview.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newReview.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newReview.Location = new System.Drawing.Point(22, 300);
            this.newReview.Margin = new System.Windows.Forms.Padding(0);
            this.newReview.Name = "newReview";
            this.newReview.Size = new System.Drawing.Size(197, 65);
            this.newReview.TabIndex = 5;
            this.newReview.Text = "Nová Recenzia";
            this.newReview.UseVisualStyleBackColor = false;
            this.newReview.Click += new System.EventHandler(this.newReview_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login.Location = new System.Drawing.Point(22, 392);
            this.login.Margin = new System.Windows.Forms.Padding(0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(197, 65);
            this.login.TabIndex = 4;
            this.login.Text = "Obsluha";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // reviewForm
            // 
            this.reviewForm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.reviewForm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.reviewForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reviewForm.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reviewForm.Location = new System.Drawing.Point(22, 207);
            this.reviewForm.Margin = new System.Windows.Forms.Padding(0);
            this.reviewForm.Name = "reviewForm";
            this.reviewForm.Size = new System.Drawing.Size(197, 65);
            this.reviewForm.TabIndex = 3;
            this.reviewForm.Text = "Recenzie";
            this.reviewForm.UseVisualStyleBackColor = false;
            this.reviewForm.Click += new System.EventHandler(this.reviewForm_Click);
            // 
            // reservation
            // 
            this.reservation.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.reservation.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservation.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reservation.Location = new System.Drawing.Point(22, 115);
            this.reservation.Margin = new System.Windows.Forms.Padding(0);
            this.reservation.Name = "reservation";
            this.reservation.Size = new System.Drawing.Size(197, 65);
            this.reservation.TabIndex = 1;
            this.reservation.Text = "Rezervácie";
            this.reservation.UseVisualStyleBackColor = false;
            this.reservation.Click += new System.EventHandler(this.reservation_Click);
            // 
            // minimalizeButton
            // 
            this.minimalizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimalizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimalizeButton.BackgroundImage")));
            this.minimalizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimalizeButton.FlatAppearance.BorderSize = 0;
            this.minimalizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimalizeButton.Location = new System.Drawing.Point(75, 18);
            this.minimalizeButton.Name = "minimalizeButton";
            this.minimalizeButton.Size = new System.Drawing.Size(51, 52);
            this.minimalizeButton.TabIndex = 5;
            this.minimalizeButton.UseVisualStyleBackColor = false;
            this.minimalizeButton.Click += new System.EventHandler(this.minimalizeButton_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.close.Location = new System.Drawing.Point(24, 21);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(45, 46);
            this.close.TabIndex = 10;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // reviews2
            // 
            this.reviews2.Adding = false;
            this.reviews2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.reviews2.Location = new System.Drawing.Point(267, 99);
            this.reviews2.Name = "reviews2";
            this.reviews2.Size = new System.Drawing.Size(645, 486);
            this.reviews2.TabIndex = 15;
            // 
            // menu2
            // 
            this.menu2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu2.Location = new System.Drawing.Point(267, 99);
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(645, 486);
            this.menu2.TabIndex = 13;
            // 
            // addNewItem1
            // 
            this.addNewItem1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addNewItem1.Location = new System.Drawing.Point(267, 99);
            this.addNewItem1.LoggedIn = true;
            this.addNewItem1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewItem1.Name = "addNewItem1";
            this.addNewItem1.Size = new System.Drawing.Size(645, 486);
            this.addNewItem1.TabIndex = 12;
            // 
            // loginForm1
            // 
            this.loginForm1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.loginForm1.Location = new System.Drawing.Point(267, 101);
            this.loginForm1.LoggedIn = false;
            this.loginForm1.Name = "loginForm1";
            this.loginForm1.Size = new System.Drawing.Size(645, 486);
            this.loginForm1.TabIndex = 9;
            // 
            // reservation1
            // 
            this.reservation1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.reservation1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reservation1.CausesValidation = false;
            this.reservation1.Location = new System.Drawing.Point(267, 99);
            this.reservation1.Name = "reservation1";
            this.reservation1.Size = new System.Drawing.Size(645, 486);
            this.reservation1.TabIndex = 16;
            // 
            // addReview1
            // 
            this.addReview1.Adding = false;
            this.addReview1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addReview1.Location = new System.Drawing.Point(267, 99);
            this.addReview1.Name = "addReview1";
            this.addReview1.Size = new System.Drawing.Size(645, 486);
            this.addReview1.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(936, 618);
            this.Controls.Add(this.close);
            this.Controls.Add(this.minimalizeButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reviews2);
            this.Controls.Add(this.menu2);
            this.Controls.Add(this.addNewItem1);
            this.Controls.Add(this.loginForm1);
            this.Controls.Add(this.reservation1);
            this.Controls.Add(this.addReview1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Restaurant Ordering And Reservation System";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reviewForm;
        private System.Windows.Forms.Button reservation;
        private System.Windows.Forms.Button minimalizeButton;
        private LoginForm loginForm1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button login;
        private AddNewItem addNewItem1;
        private Menu menu2;
        private GetDataFromDatabase.Reviews reviews2;
        private Reservation reservation1;
        private AddReview addReview1;
        private System.Windows.Forms.Button newReview;
    }
}