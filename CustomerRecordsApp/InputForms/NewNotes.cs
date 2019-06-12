using DatabaseAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerRecordsApp.InputForms
{
    public partial class NewNotes : Form
    {
        int customer_ID;
        public NewNotes(int Customer_ID)
        {
            customer_ID = Customer_ID;
            InitializeComponent();
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            try
            {
                Customer.addNotes(customer_ID, tbNotesBox.Text, dtpNotesDate.Value);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to save Customer Notes!\n\nException: {ex}", "Error saving notes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
