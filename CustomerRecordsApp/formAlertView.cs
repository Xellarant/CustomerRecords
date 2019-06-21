using CustomerRecordsApp.Data.Azure;
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
        int customerID;
        DataTable alertsTable = new DataTable();
        public formAlertView(int CustomerID)
        {
            customerID = CustomerID;
            InitializeComponent();
            
            Customer.getCustomerAlertsList(alertsTable, customerID);
            dgvCustomerAlerts.DataSource = alertsTable;
        }
    }
}
