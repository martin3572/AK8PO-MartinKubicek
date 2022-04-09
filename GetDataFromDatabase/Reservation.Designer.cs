
namespace GetDataFromDatabase
{
    partial class Reservation
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
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.label1 = new System.Windows.Forms.Label();
            this.guestName = new System.Windows.Forms.TextBox();
            this.cbGuestCount = new System.Windows.Forms.ComboBox();
            this.cbAvailableTables = new System.Windows.Forms.ComboBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.addNew = new System.Windows.Forms.Button();
            this.warningMessage = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rezervácia stola";
            // 
            // guestName
            // 
            this.guestName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.guestName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestName.Location = new System.Drawing.Point(292, 329);
            this.guestName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guestName.Name = "guestName";
            this.guestName.Size = new System.Drawing.Size(235, 31);
            this.guestName.TabIndex = 31;
            this.guestName.TextChanged += new System.EventHandler(this.guestName_TextChanged);
            // 
            // cbGuestCount
            // 
            this.cbGuestCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbGuestCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGuestCount.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGuestCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbGuestCount.FormattingEnabled = true;
            this.cbGuestCount.Location = new System.Drawing.Point(292, 173);
            this.cbGuestCount.Name = "cbGuestCount";
            this.cbGuestCount.Size = new System.Drawing.Size(235, 40);
            this.cbGuestCount.TabIndex = 41;
            this.cbGuestCount.SelectedIndexChanged += new System.EventHandler(this.cbGuestCount_SelectedIndexChanged);
            // 
            // cbAvailableTables
            // 
            this.cbAvailableTables.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbAvailableTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAvailableTables.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAvailableTables.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbAvailableTables.FormattingEnabled = true;
            this.cbAvailableTables.Location = new System.Drawing.Point(292, 250);
            this.cbAvailableTables.Name = "cbAvailableTables";
            this.cbAvailableTables.Size = new System.Drawing.Size(235, 40);
            this.cbAvailableTables.TabIndex = 42;
            this.cbAvailableTables.SelectedIndexChanged += new System.EventHandler(this.cbAvailableTables_SelectedIndexChanged);
            // 
            // datetime
            // 
            this.datetime.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime.Location = new System.Drawing.Point(292, 101);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(235, 39);
            this.datetime.TabIndex = 43;
            this.datetime.ValueChanged += new System.EventHandler(this.datetime_ValueChanged);
            // 
            // addNew
            // 
            this.addNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addNew.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNew.Location = new System.Drawing.Point(488, 405);
            this.addNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(137, 65);
            this.addNew.TabIndex = 44;
            this.addNew.Text = "Rezervovat Stôl";
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(127, 101);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(97, 33);
            passwordLabel.TabIndex = 45;
            passwordLabel.Text = "Dátum:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(127, 173);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(140, 33);
            label2.TabIndex = 46;
            label2.Text = "Počet hostí:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(127, 252);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(133, 33);
            label3.TabIndex = 47;
            label3.Text = "Voľné stoly:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(127, 327);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(76, 33);
            label4.TabIndex = 48;
            label4.Text = "Meno:";
            // 
            // warningMessage
            // 
            this.warningMessage.AutoSize = true;
            this.warningMessage.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningMessage.ForeColor = System.Drawing.Color.Red;
            this.warningMessage.Location = new System.Drawing.Point(128, 424);
            this.warningMessage.Name = "warningMessage";
            this.warningMessage.Size = new System.Drawing.Size(246, 33);
            this.warningMessage.TabIndex = 50;
            this.warningMessage.Text = "Vyplňte meno prosím!";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.Controls.Add(this.warningMessage);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.addNew);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.cbAvailableTables);
            this.Controls.Add(this.cbGuestCount);
            this.Controls.Add(this.guestName);
            this.Controls.Add(this.label1);
            this.Name = "Reservation";
            this.Size = new System.Drawing.Size(645, 486);
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox guestName;
        private System.Windows.Forms.ComboBox cbGuestCount;
        private System.Windows.Forms.ComboBox cbAvailableTables;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.Label warningMessage;
    }
}
