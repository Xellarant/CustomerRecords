﻿namespace CustomerRecordsApp
{
    partial class formServiceView
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.panelReferralDGV = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCustomerServices = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panelReferralDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btSave);
            this.panel2.Location = new System.Drawing.Point(571, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 40);
            this.panel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(18, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.Location = new System.Drawing.Point(122, 10);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(92, 23);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // panelReferralDGV
            // 
            this.panelReferralDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReferralDGV.Controls.Add(this.dataGridView1);
            this.panelReferralDGV.Location = new System.Drawing.Point(12, 45);
            this.panelReferralDGV.Name = "panelReferralDGV";
            this.panelReferralDGV.Size = new System.Drawing.Size(776, 247);
            this.panelReferralDGV.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblCustomerServices
            // 
            this.lblCustomerServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerServices.AutoSize = true;
            this.lblCustomerServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerServices.Location = new System.Drawing.Point(313, 10);
            this.lblCustomerServices.Name = "lblCustomerServices";
            this.lblCustomerServices.Size = new System.Drawing.Size(185, 24);
            this.lblCustomerServices.TabIndex = 4;
            this.lblCustomerServices.Text = "Customer Services";
            // 
            // formServiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.lblCustomerServices);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelReferralDGV);
            this.Name = "formServiceView";
            this.Text = "formServiceView";
            this.panel2.ResumeLayout(false);
            this.panelReferralDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Panel panelReferralDGV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCustomerServices;
    }
}