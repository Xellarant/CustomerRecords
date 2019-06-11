namespace CustomerRecordsApp.InputForms
{
    partial class NewNotes
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
            this.panelNotesBox = new System.Windows.Forms.Panel();
            this.lblCustomerNotes = new System.Windows.Forms.Label();
            this.tbNotesBox = new System.Windows.Forms.TextBox();
            this.panelSaveButton = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.panelNotesBox.SuspendLayout();
            this.panelSaveButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNotesBox
            // 
            this.panelNotesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNotesBox.Controls.Add(this.tbNotesBox);
            this.panelNotesBox.Location = new System.Drawing.Point(24, 52);
            this.panelNotesBox.Name = "panelNotesBox";
            this.panelNotesBox.Size = new System.Drawing.Size(736, 328);
            this.panelNotesBox.TabIndex = 0;
            // 
            // lblCustomerNotes
            // 
            this.lblCustomerNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerNotes.AutoSize = true;
            this.lblCustomerNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNotes.Location = new System.Drawing.Point(331, 9);
            this.lblCustomerNotes.Name = "lblCustomerNotes";
            this.lblCustomerNotes.Size = new System.Drawing.Size(145, 24);
            this.lblCustomerNotes.TabIndex = 1;
            this.lblCustomerNotes.Text = "Customer Notes";
            // 
            // tbNotesBox
            // 
            this.tbNotesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNotesBox.Location = new System.Drawing.Point(0, 0);
            this.tbNotesBox.Multiline = true;
            this.tbNotesBox.Name = "tbNotesBox";
            this.tbNotesBox.Size = new System.Drawing.Size(736, 328);
            this.tbNotesBox.TabIndex = 0;
            // 
            // panelSaveButton
            // 
            this.panelSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSaveButton.Controls.Add(this.btSave);
            this.panelSaveButton.Location = new System.Drawing.Point(596, 390);
            this.panelSaveButton.Name = "panelSaveButton";
            this.panelSaveButton.Size = new System.Drawing.Size(164, 48);
            this.panelSaveButton.TabIndex = 2;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(45, 9);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(118, 28);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // NewNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSaveButton);
            this.Controls.Add(this.lblCustomerNotes);
            this.Controls.Add(this.panelNotesBox);
            this.Name = "NewNotes";
            this.Text = "NewNotes";
            this.panelNotesBox.ResumeLayout(false);
            this.panelNotesBox.PerformLayout();
            this.panelSaveButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNotesBox;
        private System.Windows.Forms.Label lblCustomerNotes;
        private System.Windows.Forms.TextBox tbNotesBox;
        private System.Windows.Forms.Panel panelSaveButton;
        private System.Windows.Forms.Button btSave;
    }
}