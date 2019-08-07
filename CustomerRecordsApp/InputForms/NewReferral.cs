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
    public partial class NewReferral : Form
    {
        public NewReferral(int CustomerID)
        {            
            InitializeComponent();
            CustomerRoster customer = CustomerRoster.getCustomerList()
                                        .FirstOrDefault(x => x.Customer_ID == CustomerID);
            lblCustomerName.Text = customer.FirstName + " " + customer.LastName;
        }
    }
}
