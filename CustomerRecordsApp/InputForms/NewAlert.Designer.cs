namespace CustomerRecordsApp.InputForms
{
    partial class formNewAlert
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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.cbAlertType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbDetails = new System.Windows.Forms.RichTextBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.lblNewAlert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(55, 93);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(57, 13);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer: ";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(158, 90);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(233, 20);
            this.tbCustomerName.TabIndex = 1;
            this.tbCustomerName.Text = "(Customer Name)";
            // 
            // cbAlertType
            // 
            this.cbAlertType.FormattingEnabled = true;
            this.cbAlertType.Location = new System.Drawing.Point(158, 126);
            this.cbAlertType.Name = "cbAlertType";
            this.cbAlertType.Size = new System.Drawing.Size(233, 21);
            this.cbAlertType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alert Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Details:";
            // 
            // rtbDetails
            // 
            this.rtbDetails.Location = new System.Drawing.Point(158, 172);
            this.rtbDetails.Name = "rtbDetails";
            this.rtbDetails.Size = new System.Drawing.Size(233, 53);
            this.rtbDetails.TabIndex = 5;
            this.rtbDetails.Text = "";
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(362, 247);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 6;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.BtSubmit_Click);
            // 
            // lblNewAlert
            // 
            this.lblNewAlert.AutoSize = true;
            this.lblNewAlert.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewAlert.Location = new System.Drawing.Point(145, 25);
            this.lblNewAlert.Name = "lblNewAlert";
            this.lblNewAlert.Size = new System.Drawing.Size(175, 24);
            this.lblNewAlert.TabIndex = 7;
            this.lblNewAlert.Text = "Enter New Alert";
            // 
            // formNewAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 289);
            this.Controls.Add(this.lblNewAlert);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.rtbDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAlertType);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lblCustomer);
            this.Name = "formNewAlert";
            this.Text = "New Alert Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.ComboBox cbAlertType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbDetails;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Label lblNewAlert;
    }
}