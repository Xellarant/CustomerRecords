using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerRecordsApp.Data.Access;

namespace CustomerRecordsApp.InputForms
{
    public partial class formNewAlert : Form
    {
        int customerID;
        DataTable alertsTypeTable = new DataTable();
        public formNewAlert(Customer cust)
        {
            InitializeComponent();

            tbCustomerName.Text = cust.FirstName + " " + cust.MiddleInitial + " " + cust.LastName;
            customerID = cust.Customer_ID;
            Customer.getCustomerAlertTypesList(alertsTypeTable);
            cbAlertType.DataSource = alertsTypeTable;
            cbAlertType.DisplayMember = "TypeName";
            cbAlertType.ValueMember = "AlertType_ID";            
        }

        private void BtSubmit_Click(object sender, EventArgs e)
        {
            int alertTypeID;
            if (Int32.TryParse(cbAlertType.SelectedValue.ToString(), out alertTypeID))
            {
                try
                {
                    Customer.addCustomerAlert(customerID, alertTypeID, rtbDetails.Text);
                    this.Close();
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine("Error submitting new alert!\nException: " + ex);
                    MessageBox.Show($"Error entering new alert!\n\nexception: {ex}", 
                        "Alert entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }            
        }
    }
}
