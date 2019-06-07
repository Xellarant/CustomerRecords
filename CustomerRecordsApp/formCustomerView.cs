using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DatabaseAccess;

namespace CustomerRecordsApp
{
    public partial class formCustomerView : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        DataTable customerTable = new DataTable();
        public formCustomerView()
        {           
            Initialize();
            


        }

        public void Initialize()
        {
            InitializeComponent();

            try
            {
                using (conn = new SqlConnection(ShowMeDB.connString))
                {
                    //access SQL Server and run your command
                    conn.Open();
                    Console.WriteLine("Connection Open.");
                }
            }
            catch (Exception ex)
            {
                //display error message
                Console.WriteLine("Exception: " + ex.Message);
            }
            
        }

        public void SetCommand(String query)
        {
            cmd = new SqlCommand(query, conn);
        }

        public void getCustomers(DataTable dt)
        {
            Customer.getCustomersTable(dt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getCustomers(customerTable);
            dgvCustomerData.DataSource = customerTable;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            Console.WriteLine("Connection closed.");
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {

        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {

        }

        private void DgvCustomerData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int CustomerID;
            if (Int32.TryParse(dgvCustomerData.SelectedRows[0].Cells["Customer_ID"].Value.ToString(), out CustomerID))
            {
                formCustomerDetailView detailView = new formCustomerDetailView(CustomerID);
                detailView.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error: Couldn't find the CustomerID for the selected record.", 
                                "CustomerID error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }

}
