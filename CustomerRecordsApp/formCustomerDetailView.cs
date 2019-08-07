using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerRecordsApp.InputForms;
using CustomerRecordsApp.Data.Access;

namespace CustomerRecordsApp
{
    public partial class formCustomerDetailView : Form
    {
        int customerID;
        DataTable customerServicesTable = new DataTable();
        DataTable customerReferralsTable = new DataTable();
        DataTable customerOutcomesTable = new DataTable();
        DataTable customerNotesTable = new DataTable();
        public formCustomerDetailView(int CustomerID)
        {
            customerID = CustomerID;
            Initialize();
            
        }

        private void BtAddNotes_Click(object sender, EventArgs e)
        {
            using (NewNotes notesView = new NewNotes(customerID))
            {
                notesView.ShowDialog();
            }
            RefreshNotes();
        }

        private void Initialize()
        {
            InitializeComponent();

            RefreshReferrals();
            RefreshServices();
            RefreshOutcomes();
            RefreshNotes();
        }

        private void RefreshReferrals()
        {
            dgvCustomerReferrals.DataSource = null;
            customerReferralsTable.Clear();
            Customer.getCustomerReferralsList(customerReferralsTable, customerID);
            dgvCustomerReferrals.DataSource = customerReferralsTable;
            dgvCustomerReferrals.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void RefreshServices()
        {
            dgvCustomerServices.DataSource = null;
            //TODO: Reimplement for MS Access equivalent
            //Customer.getCustomerServicesList(customerServicesTable, customerID);
            dgvCustomerServices.DataSource = customerServicesTable;
            dgvCustomerServices.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void RefreshOutcomes()
        {
            dgvCustomerOutcomes.DataSource = null;
            //TODO: Reimplement for MS Access equivalent
            //Customer.getCustomerOutcomesList(customerOutcomesTable, customerID);
            dgvCustomerOutcomes.DataSource = customerOutcomesTable;
            dgvCustomerOutcomes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void RefreshNotes()
        {
            dgvCustomerNotes.DataSource = null;
            customerNotesTable.Clear();
            Customer.getCustomerNotesList(customerNotesTable, customerID);
            dgvCustomerNotes.DataSource = customerNotesTable;
            dgvCustomerNotes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvCustomerNotes.Columns["Notes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BtSaveNotes_Click(object sender, EventArgs e)
        {
            int notesID;
            string notes;
            DateTime notesDate;

            if (dgvCustomerNotes.SelectedRows.Count > 0
                && Int32.TryParse(dgvCustomerNotes.SelectedRows[0].Cells["CustomerNotes_ID"].Value.ToString(), out notesID))
            {
                if (!DateTime.TryParse(dgvCustomerNotes.SelectedRows[0].Cells["NotesDate"].Value.ToString(), out notesDate))
                {
                    MessageBox.Show(
                        "There was an issue capturing the date as entered. Please try again.",
                        "Invalid Date",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    notes = dgvCustomerNotes.SelectedRows[0].Cells["Notes"].Value.ToString();
                    Customer.updateNotes(notesID, notes, notesDate);
                    MessageBox.Show(
                        "Successfully updated notes record.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"There was an issue saving the record to the database!. \n\nException: {ex}",
                        "Data Access Failure",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    Console.Error.WriteLine($"Error with data access!\n\n{ex}");
                }
            }
                        
            // TODO: Test this
            //MessageBox.Show(
            //    "Sorry! That feature is not yet implemented.",
            //    "Not Implemented",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Warning);
        }

        private void BtAddReferral_Click(object sender, EventArgs e)
        {
            // TODO: Implement this
            MessageBox.Show(
                "Sorry! That feature is not yet implemented.",
                "Not Implemented",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            //throw new NotImplementedException();
        }

        private void BtSaveReferral_Click(object sender, EventArgs e)
        {
            // TODO: Implement this
            MessageBox.Show(
                "Sorry! That feature is not yet implemented.",
                "Not Implemented",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            //throw new NotImplementedException();
        }

        private void BtAddService_Click(object sender, EventArgs e)
        {
            // TODO: Implement this
            MessageBox.Show(
                "Sorry! That feature is not yet implemented.",
                "Not Implemented",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            //throw new NotImplementedException();
        }

        private void BtSaveService_Click(object sender, EventArgs e)
        {
            // TODO: Implement this
            MessageBox.Show(
                "Sorry! That feature is not yet implemented.",
                "Not Implemented",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            //throw new NotImplementedException();
        }

        private void BtAddOutcome_Click(object sender, EventArgs e)
        {
            // TODO: Implement this
            MessageBox.Show(
                "Sorry! That feature is not yet implemented.",
                "Not Implemented",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            //throw new NotImplementedException();
        }

        private void BtSaveOutcome_Click(object sender, EventArgs e)
        {
            // TODO: Implement this
            MessageBox.Show(
                "Sorry! That feature is not yet implemented.",
                "Not Implemented",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            //throw new NotImplementedException();
        }

        private void DgvCustomerNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;
            int customerNotesID = (int)gridView.Rows[e.RowIndex].Cells["CustomerNotes_ID"].Value;
            using (NewNotes notesView = new NewNotes(customerID, customerNotesID))
            {
                notesView.ShowDialog();
            }
            RefreshNotes();
        }
    }
}
