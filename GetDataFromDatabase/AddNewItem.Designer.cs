
namespace GetDataFromDatabase
{
    partial class AddNewItem
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewItem));
            this.label1 = new System.Windows.Forms.Label();
            this.discardProductName = new System.Windows.Forms.Button();
            this.discardPrice = new System.Windows.Forms.Button();
            this.productprice = new System.Windows.Forms.TextBox();
            this.productname = new System.Windows.Forms.TextBox();
            this.addNew = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.discardImage = new System.Windows.Forms.Button();
            this.insertImage = new System.Windows.Forms.Button();
            this.cbProductcategory = new System.Windows.Forms.ComboBox();
            this.logout = new System.Windows.Forms.Button();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.Location = new System.Drawing.Point(219, 72);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(192, 33);
            usernameLabel.TabIndex = 26;
            usernameLabel.Text = "Názov Produktu";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(232, 158);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(179, 33);
            passwordLabel.TabIndex = 27;
            passwordLabel.Text = "Cena Produktu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(52, 242);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(210, 33);
            label3.TabIndex = 34;
            label3.Text = "Nahranie obrázku";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(420, 242);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(117, 33);
            label2.TabIndex = 41;
            label2.Text = "Kategória";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pridanie položky";
            // 
            // discardProductName
            // 
            this.discardProductName.BackColor = System.Drawing.Color.Transparent;
            this.discardProductName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("discardProductName.BackgroundImage")));
            this.discardProductName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.discardProductName.FlatAppearance.BorderSize = 0;
            this.discardProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discardProductName.Location = new System.Drawing.Point(514, 96);
            this.discardProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.discardProductName.Name = "discardProductName";
            this.discardProductName.Size = new System.Drawing.Size(43, 42);
            this.discardProductName.TabIndex = 32;
            this.discardProductName.UseVisualStyleBackColor = false;
            this.discardProductName.Click += new System.EventHandler(this.discardProductName_Click);
            // 
            // discardPrice
            // 
            this.discardPrice.BackColor = System.Drawing.Color.Transparent;
            this.discardPrice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("discardPrice.BackgroundImage")));
            this.discardPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.discardPrice.FlatAppearance.BorderSize = 0;
            this.discardPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discardPrice.Location = new System.Drawing.Point(514, 182);
            this.discardPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.discardPrice.Name = "discardPrice";
            this.discardPrice.Size = new System.Drawing.Size(43, 42);
            this.discardPrice.TabIndex = 31;
            this.discardPrice.UseVisualStyleBackColor = false;
            this.discardPrice.Click += new System.EventHandler(this.discardPrice_Click);
            // 
            // productprice
            // 
            this.productprice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.productprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productprice.Location = new System.Drawing.Point(125, 193);
            this.productprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productprice.Name = "productprice";
            this.productprice.Size = new System.Drawing.Size(383, 31);
            this.productprice.TabIndex = 30;
            // 
            // productname
            // 
            this.productname.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.productname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname.Location = new System.Drawing.Point(125, 107);
            this.productname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(383, 31);
            this.productname.TabIndex = 29;
            // 
            // addNew
            // 
            this.addNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addNew.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNew.Location = new System.Drawing.Point(496, 401);
            this.addNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(115, 64);
            this.addNew.TabIndex = 28;
            this.addNew.Text = "Vložit položku";
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.Location = new System.Drawing.Point(58, 278);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(174, 158);
            this.pictureBox.TabIndex = 37;
            this.pictureBox.TabStop = false;
            // 
            // discardImage
            // 
            this.discardImage.BackColor = System.Drawing.Color.Transparent;
            this.discardImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("discardImage.BackgroundImage")));
            this.discardImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.discardImage.FlatAppearance.BorderSize = 0;
            this.discardImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discardImage.Location = new System.Drawing.Point(238, 367);
            this.discardImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.discardImage.Name = "discardImage";
            this.discardImage.Size = new System.Drawing.Size(61, 55);
            this.discardImage.TabIndex = 38;
            this.discardImage.UseVisualStyleBackColor = false;
            this.discardImage.Click += new System.EventHandler(this.discardImage_Click);
            // 
            // insertImage
            // 
            this.insertImage.BackColor = System.Drawing.Color.Transparent;
            this.insertImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("insertImage.BackgroundImage")));
            this.insertImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.insertImage.FlatAppearance.BorderSize = 0;
            this.insertImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertImage.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertImage.Location = new System.Drawing.Point(238, 293);
            this.insertImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertImage.Name = "insertImage";
            this.insertImage.Size = new System.Drawing.Size(61, 57);
            this.insertImage.TabIndex = 39;
            this.insertImage.UseVisualStyleBackColor = false;
            this.insertImage.Click += new System.EventHandler(this.insertImage_Click);
            // 
            // cbProductcategory
            // 
            this.cbProductcategory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbProductcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProductcategory.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductcategory.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbProductcategory.FormattingEnabled = true;
            this.cbProductcategory.Location = new System.Drawing.Point(364, 278);
            this.cbProductcategory.Name = "cbProductcategory";
            this.cbProductcategory.Size = new System.Drawing.Size(235, 40);
            this.cbProductcategory.TabIndex = 40;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout.BackgroundImage")));
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logout.Location = new System.Drawing.Point(566, 11);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(45, 46);
            this.logout.TabIndex = 42;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.logout);
            this.Controls.Add(label2);
            this.Controls.Add(this.cbProductcategory);
            this.Controls.Add(this.insertImage);
            this.Controls.Add(this.discardImage);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.discardProductName);
            this.Controls.Add(this.discardPrice);
            this.Controls.Add(this.productprice);
            this.Controls.Add(this.productname);
            this.Controls.Add(this.addNew);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddNewItem";
            this.Size = new System.Drawing.Size(645, 486);
            this.Load += new System.EventHandler(this.AddNewItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button discardProductName;
        private System.Windows.Forms.Button discardPrice;
        private System.Windows.Forms.TextBox productprice;
        private System.Windows.Forms.TextBox productname;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button discardImage;
        private System.Windows.Forms.Button insertImage;
        private System.Windows.Forms.ComboBox cbProductcategory;
        private System.Windows.Forms.Button logout;
    }
}
