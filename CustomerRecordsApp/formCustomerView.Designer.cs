namespace CustomerRecordsApp
{
    partial class formCustomerView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCustomerData = new System.Windows.Forms.DataGridView();
            this.lblCustomerRecords = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btAdd = new System.Windows.Forms.Button();
            this.lblDoubleClick = new System.Windows.Forms.Label();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btViewAlerts = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerData)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvCustomerData);
            this.panel1.Location = new System.Drawing.Point(12, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 238);
            this.panel1.TabIndex = 0;
            // 
            // dgvCustomerData
            // 
            this.dgvCustomerData.AllowUserToAddRows = false;
            this.dgvCustomerData.AllowUserToDeleteRows = false;
            this.dgvCustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerData.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomerData.MultiSelect = false;
            this.dgvCustomerData.Name = "dgvCustomerData";
            this.dgvCustomerData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerData.Size = new System.Drawing.Size(885, 234);
            this.dgvCustomerData.TabIndex = 0;
            this.dgvCustomerData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomerData_CellDoubleClick);
            this.dgvCustomerData.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomerData_CellLeave);
            this.dgvCustomerData.SelectionChanged += new System.EventHandler(this.DgvCustomerData_SelectionChanged);
            // 
            // lblCustomerRecords
            // 
            this.lblCustomerRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerRecords.AutoSize = true;
            this.lblCustomerRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerRecords.Location = new System.Drawing.Point(371, 9);
            this.lblCustomerRecords.Name = "lblCustomerRecords";
            this.lblCustomerRecords.Size = new System.Drawing.Size(183, 24);
            this.lblCustomerRecords.TabIndex = 1;
            this.lblCustomerRecords.Text = "Customer Records";
            // 
            // btUpdate
            // 
            this.btUpdate.Enabled = false;
            this.btUpdate.Location = new System.Drawing.Point(134, 8);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(111, 23);
            this.btUpdate.TabIndex = 2;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.btUpdate);
            this.panel2.Location = new System.Drawing.Point(650, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 34);
            this.panel2.TabIndex = 3;
            // 
            // btAdd
            // 
            this.btAdd.Enabled = false;
            this.btAdd.Location = new System.Drawing.Point(11, 8);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(112, 23);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // lblDoubleClick
            // 
            this.lblDoubleClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDoubleClick.AutoSize = true;
            this.lblDoubleClick.Location = new System.Drawing.Point(12, 366);
            this.lblDoubleClick.Name = "lblDoubleClick";
            this.lblDoubleClick.Size = new System.Drawing.Size(140, 13);
            this.lblDoubleClick.TabIndex = 4;
            this.lblDoubleClick.Text = "Double Click to View Details";
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(12, 72);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 25);
            this.btRefresh.TabIndex = 5;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.BtRefresh_Click);
            // 
            // btViewAlerts
            // 
            this.btViewAlerts.Enabled = false;
            this.btViewAlerts.Location = new System.Drawing.Point(782, 72);
            this.btViewAlerts.Name = "btViewAlerts";
            this.btViewAlerts.Size = new System.Drawing.Size(117, 24);
            this.btViewAlerts.TabIndex = 6;
            this.btViewAlerts.Text = "View Alerts";
            this.btViewAlerts.UseVisualStyleBackColor = true;
            this.btViewAlerts.Click += new System.EventHandler(this.BtViewAlerts_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(375, 75);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(179, 20);
            this.tbSearch.TabIndex = 7;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(322, 77);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 13);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Search: ";
            // 
            // formCustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 400);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btViewAlerts);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.lblDoubleClick);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblCustomerRecords);
            this.Controls.Add(this.panel1);
            this.Name = "formCustomerView";
            this.Text = "Customer Managemend System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCustomerData;
        private System.Windows.Forms.Label lblCustomerRecords;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lblDoubleClick;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btViewAlerts;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}

