
namespace GetDataFromDatabase
{
    partial class Reviews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reviews));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.review = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.reviewCount = new System.Windows.Forms.Label();
            this.reload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recenzie Od Zákazníkov";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Recenzia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Zákazník:";
            // 
            // review
            // 
            this.review.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review.Location = new System.Drawing.Point(142, 235);
            this.review.Multiline = true;
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(365, 234);
            this.review.TabIndex = 9;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(142, 165);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(365, 34);
            this.username.TabIndex = 8;
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Location = new System.Drawing.Point(520, 243);
            this.next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(61, 54);
            this.next.TabIndex = 40;
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            this.previous.BackColor = System.Drawing.Color.Transparent;
            this.previous.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previous.BackgroundImage")));
            this.previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previous.FlatAppearance.BorderSize = 0;
            this.previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous.Location = new System.Drawing.Point(64, 243);
            this.previous.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(61, 54);
            this.previous.TabIndex = 39;
            this.previous.UseVisualStyleBackColor = false;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // reviewCount
            // 
            this.reviewCount.AutoSize = true;
            this.reviewCount.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewCount.ForeColor = System.Drawing.Color.Black;
            this.reviewCount.Location = new System.Drawing.Point(215, 69);
            this.reviewCount.Name = "reviewCount";
            this.reviewCount.Size = new System.Drawing.Size(141, 33);
            this.reviewCount.TabIndex = 42;
            this.reviewCount.Text = "Recenzia: x";
            // 
            // reload
            // 
            this.reload.BackColor = System.Drawing.Color.Transparent;
            this.reload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reload.BackgroundImage")));
            this.reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reload.FlatAppearance.BorderSize = 0;
            this.reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reload.Location = new System.Drawing.Point(432, 68);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(38, 38);
            this.reload.TabIndex = 43;
            this.reload.UseVisualStyleBackColor = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // Reviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.reload);
            this.Controls.Add(this.reviewCount);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.review);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Name = "Reviews";
            this.Size = new System.Drawing.Size(645, 486);
            this.Load += new System.EventHandler(this.Reviews_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox review;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Label reviewCount;
        private System.Windows.Forms.Button reload;
    }
}
