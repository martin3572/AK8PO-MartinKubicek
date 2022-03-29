
namespace GetDataFromDatabase
{
    partial class Menu
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
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.cbProductcategory = new System.Windows.Forms.ComboBox();
            this.productImage = new System.Windows.Forms.PictureBox();
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.productCount = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(85, 35);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(123, 33);
            label3.TabIndex = 31;
            label3.Text = "Kategória:";
            // 
            // cbProductcategory
            // 
            this.cbProductcategory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbProductcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProductcategory.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductcategory.FormattingEnabled = true;
            this.cbProductcategory.Location = new System.Drawing.Point(223, 35);
            this.cbProductcategory.Name = "cbProductcategory";
            this.cbProductcategory.Size = new System.Drawing.Size(229, 37);
            this.cbProductcategory.TabIndex = 1;
            this.cbProductcategory.SelectedIndexChanged += new System.EventHandler(this.cbProductcategory_SelectedIndexChanged);
            // 
            // productImage
            // 
            this.productImage.Location = new System.Drawing.Point(223, 150);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(213, 201);
            this.productImage.TabIndex = 28;
            this.productImage.TabStop = false;
            // 
            // previous
            // 
            this.previous.BackColor = System.Drawing.Color.Transparent;
            this.previous.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previous.BackgroundImage")));
            this.previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previous.FlatAppearance.BorderSize = 0;
            this.previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous.Location = new System.Drawing.Point(67, 217);
            this.previous.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(61, 54);
            this.previous.TabIndex = 37;
            this.previous.UseVisualStyleBackColor = false;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Location = new System.Drawing.Point(523, 217);
            this.next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(61, 54);
            this.next.TabIndex = 38;
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // productCount
            // 
            this.productCount.AutoSize = true;
            this.productCount.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCount.ForeColor = System.Drawing.Color.Black;
            this.productCount.Location = new System.Drawing.Point(458, 39);
            this.productCount.Name = "productCount";
            this.productCount.Size = new System.Drawing.Size(145, 33);
            this.productCount.TabIndex = 39;
            this.productCount.Text = "Produkty: x";
            // 
            // productName
            // 
            this.productName.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.ForeColor = System.Drawing.Color.Black;
            this.productName.Location = new System.Drawing.Point(216, 97);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(227, 40);
            this.productName.TabIndex = 40;
            this.productName.Text = "Nazov Produktu";
            this.productName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productPrice
            // 
            this.productPrice.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice.ForeColor = System.Drawing.Color.Black;
            this.productPrice.Location = new System.Drawing.Point(216, 372);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(227, 40);
            this.productPrice.TabIndex = 42;
            this.productPrice.Text = "Cena";
            this.productPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productCount);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(label3);
            this.Controls.Add(this.productImage);
            this.Controls.Add(this.cbProductcategory);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(645, 486);
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbProductcategory;
        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label productCount;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label productPrice;
    }
}
