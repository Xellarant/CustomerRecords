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
using DatabaseAccess;

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

        }

        private void Initialize()
        {
            InitializeComponent();
            Customer.getCustomerReferralsList(customerReferralsTable, customerID);
            dgvCustomerReferrals.DataSource = customerReferralsTable;
            dgvCustomerReferrals.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            
            Customer.getCustomerServicesList(customerServicesTable, customerID);
            dgvCustomerServices.DataSource = customerServicesTable;
            dgvCustomerServices.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            Customer.getCustomerOutcomesList(customerOutcomesTable, customerID);
            dgvCustomerOutcomes.DataSource = customerOutcomesTable;
            dgvCustomerOutcomes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            Customer.getCustomerNotesList(customerNotesTable, customerID);
            dgvCustomerNotes.DataSource = customerNotesTable;
            dgvCustomerNotes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }
    }
}
