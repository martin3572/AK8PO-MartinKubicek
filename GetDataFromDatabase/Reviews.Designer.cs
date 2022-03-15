
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
            this.email = new System.Windows.Forms.TextBox();
            this.review = new System.Windows.Forms.TextBox();
            this.sendReview = new System.Windows.Forms.Button();
            this.discardReview = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Napíšte Recenziu";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(65, 126);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(521, 27);
            this.email.TabIndex = 2;
            // 
            // review
            // 
            this.review.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review.Location = new System.Drawing.Point(65, 196);
            this.review.Multiline = true;
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(521, 198);
            this.review.TabIndex = 3;
            // 
            // sendReview
            // 
            this.sendReview.BackColor = System.Drawing.Color.Transparent;
            this.sendReview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sendReview.FlatAppearance.BorderSize = 0;
            this.sendReview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendReview.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendReview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sendReview.Image = ((System.Drawing.Image)(resources.GetObject("sendReview.Image")));
            this.sendReview.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sendReview.Location = new System.Drawing.Point(421, 413);
            this.sendReview.Name = "sendReview";
            this.sendReview.Size = new System.Drawing.Size(165, 47);
            this.sendReview.TabIndex = 4;
            this.sendReview.Text = "Odoslat";
            this.sendReview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendReview.UseVisualStyleBackColor = false;
            // 
            // discardReview
            // 
            this.discardReview.BackColor = System.Drawing.Color.Transparent;
            this.discardReview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("discardReview.BackgroundImage")));
            this.discardReview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.discardReview.FlatAppearance.BorderSize = 0;
            this.discardReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discardReview.Location = new System.Drawing.Point(359, 413);
            this.discardReview.Name = "discardReview";
            this.discardReview.Size = new System.Drawing.Size(56, 47);
            this.discardReview.TabIndex = 5;
            this.discardReview.UseVisualStyleBackColor = false;
            this.discardReview.Click += new System.EventHandler(this.discardReview_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email (nepovinné):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Recenzia:";
            // 
            // Reviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.discardReview);
            this.Controls.Add(this.sendReview);
            this.Controls.Add(this.review);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.Name = "Reviews";
            this.Size = new System.Drawing.Size(645, 486);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox review;
        private System.Windows.Forms.Button discardReview;
        private System.Windows.Forms.Button sendReview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
