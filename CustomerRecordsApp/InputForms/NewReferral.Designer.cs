namespace CustomerRecordsApp.InputForms
{
    partial class NewReferral
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
            this.lblCustomerSelected = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtReferralType = new System.Windows.Forms.TextBox();
            this.lblReferralType = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblAppointmentTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustomerSelected
            // 
            this.lblCustomerSelected.AutoSize = true;
            this.lblCustomerSelected.Location = new System.Drawing.Point(52, 54);
            this.lblCustomerSelected.Name = "lblCustomerSelected";
            this.lblCustomerSelected.Size = new System.Drawing.Size(57, 13);
            this.lblCustomerSelected.TabIndex = 0;
            this.lblCustomerSelected.Text = "Customer: ";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(181, 54);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "label2";
            // 
            // txtReferralType
            // 
            this.txtReferralType.Location = new System.Drawing.Point(184, 121);
            this.txtReferralType.Name = "txtReferralType";
            this.txtReferralType.Size = new System.Drawing.Size(143, 20);
            this.txtReferralType.TabIndex = 2;
            this.txtReferralType.Text = "B2B/CARECEN/Other";
            // 
            // lblReferralType
            // 
            this.lblReferralType.AutoSize = true;
            this.lblReferralType.Location = new System.Drawing.Point(52, 124);
            this.lblReferralType.Name = "lblReferralType";
            this.lblReferralType.Size = new System.Drawing.Size(77, 13);
            this.lblReferralType.TabIndex = 3;
            this.lblReferralType.Text = "Referral Type: ";
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Location = new System.Drawing.Point(52, 174);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(98, 13);
            this.lblAppointmentDate.TabIndex = 4;
            this.lblAppointmentDate.Text = "Appointment Date: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(184, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(184, 220);
            this.maskedTextBox1.Mask = "90:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // lblAppointmentTime
            // 
            this.lblAppointmentTime.AutoSize = true;
            this.lblAppointmentTime.Location = new System.Drawing.Point(52, 223);
            this.lblAppointmentTime.Name = "lblAppointmentTime";
            this.lblAppointmentTime.Size = new System.Drawing.Size(98, 13);
            this.lblAppointmentTime.TabIndex = 7;
            this.lblAppointmentTime.Text = "Appointment Time: ";
            // 
            // NewReferral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 404);
            this.Controls.Add(this.lblAppointmentTime);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblAppointmentDate);
            this.Controls.Add(this.lblReferralType);
            this.Controls.Add(this.txtReferralType);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerSelected);
            this.Name = "NewReferral";
            this.Text = "New Referral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerSelected;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtReferralType;
        private System.Windows.Forms.Label lblReferralType;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblAppointmentTime;
    }
}