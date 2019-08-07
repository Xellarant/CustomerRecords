using CustomerRecordsApp.Data.Access;
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
        int customer_ID, customerNotes_ID;
        public NewNotes(int Customer_ID, int CustomerNotesID = 0)
        {
            customer_ID = Customer_ID;
            customerNotes_ID = CustomerNotesID;
            InitializeComponent();
            if (customerNotes_ID != 0)
            {
                DataTable notesTable = Customer.getNotes(customerNotes_ID);
                tbNotesBox.Text = notesTable.Rows[0]["Notes"].ToString();
                dtpNotesDate.Value = (DateTime)notesTable.Rows[0]["NotesDate"];
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            if (customerNotes_ID == 0)
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
            else
            {
                try
                {
                    Customer.updateNotes(customerNotes_ID, tbNotesBox.Text, dtpNotesDate.Value);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to save Customer Notes!\n\nException: {ex}", "Error saving notes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
