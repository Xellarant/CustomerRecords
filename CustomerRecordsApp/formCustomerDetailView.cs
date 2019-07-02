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
            //TODO: Reimplement for MS Access equivalent
            Customer.getCustomerNotesList(customerNotesTable, customerID);
            dgvCustomerNotes.DataSource = customerNotesTable;
            dgvCustomerNotes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dgvCustomerNotes.Columns["Notes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BtSaveNotes_Click(object sender, EventArgs e)
        {
            // TODO: Implement this
            throw new NotImplementedException();
        }

        private void BtAddReferral_Click(object sender, EventArgs e)
        {
            // TODO: Implement this
            throw new NotImplementedException();
        }

        private void BtSaveReferral_Click(object sender, EventArgs e)
        {
            // TODO: Implement this
            throw new NotImplementedException();
        }

        private void BtAddService_Click(object sender, EventArgs e)
        {
            // TODO: Implement this
            throw new NotImplementedException();
        }

        private void BtSaveService_Click(object sender, EventArgs e)
        {
            // TODO: Implement this
            throw new NotImplementedException();
        }

        private void BtAddOutcome_Click(object sender, EventArgs e)
        {
            // TODO: Implement this
            throw new NotImplementedException();
        }

        private void BtSaveOutcome_Click(object sender, EventArgs e)
        {
            // TODO: Implement this
            throw new NotImplementedException();
        }
    }
}
