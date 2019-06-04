namespace CustomerRecordsApp
{
    partial class formCustomerDetailView
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
            this.panelReferralDGV = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.lblCustomerReferrals = new System.Windows.Forms.Label();
            this.lblCustomerServices = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCustomerServices = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tcCustomerServiceDetails = new System.Windows.Forms.TabControl();
            this.tpServices = new System.Windows.Forms.TabPage();
            this.tpOutcomes = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvCustomerOutcomes = new System.Windows.Forms.DataGridView();
            this.lblCustomerOutcomes = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelReferralDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerServices)).BeginInit();
            this.panel3.SuspendLayout();
            this.tcCustomerServiceDetails.SuspendLayout();
            this.tpServices.SuspendLayout();
            this.tpOutcomes.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOutcomes)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReferralDGV
            // 
            this.panelReferralDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReferralDGV.Controls.Add(this.dataGridView1);
            this.panelReferralDGV.Location = new System.Drawing.Point(12, 45);
            this.panelReferralDGV.Name = "panelReferralDGV";
            this.panelReferralDGV.Size = new System.Drawing.Size(776, 125);
            this.panelReferralDGV.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 125);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btSave);
            this.panel2.Location = new System.Drawing.Point(548, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 40);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(21, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
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
            // lblCustomerReferrals
            // 
            this.lblCustomerReferrals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerReferrals.AutoSize = true;
            this.lblCustomerReferrals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerReferrals.Location = new System.Drawing.Point(318, 9);
            this.lblCustomerReferrals.Name = "lblCustomerReferrals";
            this.lblCustomerReferrals.Size = new System.Drawing.Size(188, 24);
            this.lblCustomerReferrals.TabIndex = 5;
            this.lblCustomerReferrals.Text = "Customer Referrals";
            // 
            // lblCustomerServices
            // 
            this.lblCustomerServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerServices.AutoSize = true;
            this.lblCustomerServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerServices.Location = new System.Drawing.Point(302, 1);
            this.lblCustomerServices.Name = "lblCustomerServices";
            this.lblCustomerServices.Size = new System.Drawing.Size(185, 24);
            this.lblCustomerServices.TabIndex = 7;
            this.lblCustomerServices.Text = "Customer Services";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvCustomerServices);
            this.panel1.Location = new System.Drawing.Point(3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 141);
            this.panel1.TabIndex = 6;
            // 
            // dgvCustomerServices
            // 
            this.dgvCustomerServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerServices.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomerServices.Name = "dgvCustomerServices";
            this.dgvCustomerServices.Size = new System.Drawing.Size(762, 141);
            this.dgvCustomerServices.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(571, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 40);
            this.panel3.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(21, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(122, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tcCustomerServiceDetails
            // 
            this.tcCustomerServiceDetails.Controls.Add(this.tpServices);
            this.tcCustomerServiceDetails.Controls.Add(this.tpOutcomes);
            this.tcCustomerServiceDetails.Location = new System.Drawing.Point(12, 228);
            this.tcCustomerServiceDetails.Name = "tcCustomerServiceDetails";
            this.tcCustomerServiceDetails.SelectedIndex = 0;
            this.tcCustomerServiceDetails.Size = new System.Drawing.Size(776, 239);
            this.tcCustomerServiceDetails.TabIndex = 9;
            // 
            // tpServices
            // 
            this.tpServices.Controls.Add(this.panel1);
            this.tpServices.Controls.Add(this.lblCustomerServices);
            this.tpServices.Controls.Add(this.panel2);
            this.tpServices.Location = new System.Drawing.Point(4, 22);
            this.tpServices.Name = "tpServices";
            this.tpServices.Padding = new System.Windows.Forms.Padding(3);
            this.tpServices.Size = new System.Drawing.Size(768, 213);
            this.tpServices.TabIndex = 0;
            this.tpServices.Text = "Services";
            this.tpServices.UseVisualStyleBackColor = true;
            // 
            // tpOutcomes
            // 
            this.tpOutcomes.Controls.Add(this.panel4);
            this.tpOutcomes.Controls.Add(this.lblCustomerOutcomes);
            this.tpOutcomes.Controls.Add(this.panel5);
            this.tpOutcomes.Location = new System.Drawing.Point(4, 22);
            this.tpOutcomes.Name = "tpOutcomes";
            this.tpOutcomes.Padding = new System.Windows.Forms.Padding(3);
            this.tpOutcomes.Size = new System.Drawing.Size(768, 213);
            this.tpOutcomes.TabIndex = 1;
            this.tpOutcomes.Text = "Outcomes";
            this.tpOutcomes.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dgvCustomerOutcomes);
            this.panel4.Location = new System.Drawing.Point(3, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(762, 141);
            this.panel4.TabIndex = 9;
            // 
            // dgvCustomerOutcomes
            // 
            this.dgvCustomerOutcomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerOutcomes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerOutcomes.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomerOutcomes.Name = "dgvCustomerOutcomes";
            this.dgvCustomerOutcomes.Size = new System.Drawing.Size(762, 141);
            this.dgvCustomerOutcomes.TabIndex = 0;
            // 
            // lblCustomerOutcomes
            // 
            this.lblCustomerOutcomes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerOutcomes.AutoSize = true;
            this.lblCustomerOutcomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerOutcomes.Location = new System.Drawing.Point(302, 0);
            this.lblCustomerOutcomes.Name = "lblCustomerOutcomes";
            this.lblCustomerOutcomes.Size = new System.Drawing.Size(200, 24);
            this.lblCustomerOutcomes.TabIndex = 10;
            this.lblCustomerOutcomes.Text = "Customer Outcomes";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Location = new System.Drawing.Point(548, 172);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 40);
            this.panel5.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(21, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(122, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // formCustomerDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.tcCustomerServiceDetails);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblCustomerReferrals);
            this.Controls.Add(this.panelReferralDGV);
            this.Name = "formCustomerDetailView";
            this.Text = "Customer Record Details";
            this.panelReferralDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerServices)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tcCustomerServiceDetails.ResumeLayout(false);
            this.tpServices.ResumeLayout(false);
            this.tpServices.PerformLayout();
            this.tpOutcomes.ResumeLayout(false);
            this.tpOutcomes.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOutcomes)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelReferralDGV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lblCustomerReferrals;
        private System.Windows.Forms.Label lblCustomerServices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCustomerServices;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tcCustomerServiceDetails;
        private System.Windows.Forms.TabPage tpServices;
        private System.Windows.Forms.TabPage tpOutcomes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvCustomerOutcomes;
        private System.Windows.Forms.Label lblCustomerOutcomes;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}