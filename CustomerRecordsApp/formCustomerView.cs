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
using System.Reflection;

namespace CustomerRecordsApp
{
    public partial class formCustomerView : Form
    {
        SqlConnection conn;
        // SqlCommand cmd;
        DataTable customerTable = new DataTable();
        List<Customer> modifiedCustomers = new List<Customer>();
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
                MessageBox.Show($"Error! Could not open a connection to the database!\n\nException: {ex}", 
                                "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //public void SetCommand(String query)
        //{
        //    cmd = new SqlCommand(query, conn);
        //}

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
            foreach (Customer customer in modifiedCustomers)
            {
                Customer.updateCustomer(customer);
            }
            modifiedCustomers.Clear();
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

        private void DgvCustomerData_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            if (gridView.IsCurrentCellDirty)
            {
                DataRowView currentRowView = (DataRowView)gridView.Rows[e.RowIndex].DataBoundItem;
                DataRow currentRow = currentRowView.Row;
                Customer currentCustomer = new Customer();
                CustomerRowToObject(currentRow, currentCustomer);
                modifiedCustomers.Add(currentCustomer);
                gridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aqua;
                if (!btUpdate.Enabled)
                {
                    btUpdate.Enabled = true;
                }                    
            }
        }

        static void CloneCustomer<T>(T item) where T : new()
        {
            var type = item.GetType();

            var properties = type.GetProperties();

            foreach (var property in properties)
            {

            }
        }
        private void CustomerRowToObject(DataRow row, Customer customer)
        {
            PropertyInfo[] customerProperties = typeof(Customer).GetProperties();

            foreach (var property in customerProperties)
            {
                var rowVal = row[$"{property.Name}"];
                if (rowVal.GetType() == typeof(DBNull))
                {
                    rowVal = null;
                }
                property.SetValue(customer, rowVal);
            }

            //customer.Customer_ID = (int?)row["Customer_ID"];
            //customer.FirstName = row["FirstName"].ToString();
            //customer.MiddleInitial = row["MiddleInitial"].ToString();
            //customer.LastName = row["LastName"].ToString();
            //customer.DOB = (DateTime?)row["DOB"];
            //customer.PhoneNumber = row["PhoneNumber"].ToString();
            //customer.StreetAddress = row["StreetAddress"].ToString();
            //customer.CityName = row["CityName"].ToString();
            //customer.StateName = row["StateName"].ToString();
            //customer.Zip = row["Zip"].ToString();
            //customer.ISIS_ID = (int?)row["ISIS_ID"];
        }
    }    
}
