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

namespace CustomerRecordsApp
{
    public partial class formAlertView : Form
    {
        Customer customer;        
        DataTable alertsTable = new DataTable();
        public formAlertView(Customer cust)
        {
            customer = cust;            
            InitializeComponent();
            RefreshAlerts();
        }

        private void RefreshAlerts()
        {
            dgvCustomerAlerts.DataSource = null;
            Customer.getCustomerAlertsList(alertsTable, customer.Customer_ID);
            dgvCustomerAlerts.DataSource = alertsTable;
            dgvCustomerAlerts.Columns["Details"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCustomerAlerts.Columns["CustomerAlert_ID"].Visible = false;
            dgvCustomerAlerts.Columns["Customer_ID"].Visible = false;
            dgvCustomerAlerts.Columns["AlertType_ID"].Visible = false;
        }

        private void BtSave_Click(object sender, EventArgs e)
        {

        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            using (InputForms.formNewAlert newAlertForm = new InputForms.formNewAlert(customer))
            {
                newAlertForm.ShowDialog();
                RefreshAlerts();
            }            
        }
    }
}
