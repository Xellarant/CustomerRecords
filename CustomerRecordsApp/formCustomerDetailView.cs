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
using CustomerRecordsApp.Data;

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
            Customer.getCustomerServicesList(customerServicesTable, customerID);

            dgvCustomerServices.DataSource = customerServicesTable;
            dgvCustomerServices.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void RefreshOutcomes()
        {
            dgvCustomerOutcomes.DataSource = null;
            Customer.getCustomerOutcomesList(customerOutcomesTable, customerID);
            dgvCustomerOutcomes.DataSource = customerOutcomesTable;
            dgvCustomerOutcomes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void RefreshNotes()
        {
            dgvCustomerNotes.DataSource = null;
            Customer.getCustomerNotesList(customerNotesTable, customerID);
            dgvCustomerNotes.DataSource = customerNotesTable;
            dgvCustomerNotes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }
    }
}
