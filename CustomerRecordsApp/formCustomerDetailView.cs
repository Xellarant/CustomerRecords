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
        DataTable customerServicesTable = new DataTable(), customerReferralsTable = new DataTable();
        public formCustomerDetailView(int CustomerID)
        {
            customerID = CustomerID;
            Initialize();
            
        }

        private void BtAddNotes_Click(object sender, EventArgs e)
        {
            NewNotes notesView = new NewNotes(CustomerID);
        }

        private void Initialize()
        {
            InitializeComponent();
            Customer.getCustomerReferralsList(customerReferralsTable, customerID);
            dgvCustomerReferrals.DataSource = customerReferralsTable;
            
            Customer.getCustomerServicesList(customerServicesTable, customerID);
            dgvCustomerServices.DataSource = customerServicesTable;

            

        }
    }
}
