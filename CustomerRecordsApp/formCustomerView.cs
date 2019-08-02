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
using System.Reflection;
using CustomerRecordsApp.InputForms;

namespace CustomerRecordsApp
{
    public partial class formCustomerView : Form
    {
        //DataTable customerTable = Customer.getCustomerTable();
        List<CustomerRoster> customerList = CustomerRoster.getCustomerList();
        //DataTable filteredTable = new DataTable();
        Customer currentCustomer = new Customer();
        List<CustomerRoster> modifiedCustomers = new List<CustomerRoster>();
        public formCustomerView()
        {
            Initialize();
        }

        public void Initialize()
        {
            try
            {
                InitializeComponent();
                dgvCustomerData.DataSource = customerList;
                FormatGridView();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Exception: {ex}");
            }
            

            //TODO: any additional things that might need to happen here?            
        }


        #region ///////////////      Private Methods   /////////////////////////

        public void FormatGridView()
        {
            if (dgvCustomerData.DataSource != null)
            {
                dgvCustomerData.Columns["Roster_ID"].Visible = false;
                dgvCustomerData.Columns["PY_ID"].Visible = false;
                dgvCustomerData.Columns["Roster_ID"].Visible = false;
                dgvCustomerData.Columns["PY_ID"].Visible = false;
                dgvCustomerData.Columns["Customer_ID"].DefaultCellStyle.BackColor = Color.DeepSkyBlue;
                dgvCustomerData.Columns["DOB"].DefaultCellStyle.BackColor = Color.BlanchedAlmond;
                dgvCustomerData.Columns["ISIS_ID"].DefaultCellStyle.BackColor = Color.BurlyWood;
                dgvCustomerData.Columns["EnrollmentType"].DefaultCellStyle.BackColor = Color.CornflowerBlue;
                dgvCustomerData.Columns["SubmissionDate"].DefaultCellStyle.BackColor = Color.Bisque;
                dgvCustomerData.Columns["IntakeDate"].DefaultCellStyle.BackColor = Color.LavenderBlush;
                dgvCustomerData.Columns["Notes"].DefaultCellStyle.BackColor = Color.PaleGreen;
            }
        }

        public void RefreshCustomers()
        {
            dgvCustomerData.DataSource = null;
            customerList = CustomerRoster.getCustomerList();
            dgvCustomerData.DataSource = customerList;
            FormatGridView();
        }

        //private void CustomerRowToObject(DataRow row, Customer customer)
        //{
        //    PropertyInfo[] customerProperties = typeof(Customer).GetProperties();

        //    foreach (var property in customerProperties)
        //    {
        //        var rowVal = row[$"{property.Name}"];
        //        if (rowVal.GetType() == typeof(DBNull))
        //        {
        //            rowVal = null;
        //        }
        //        property.SetValue(customer, rowVal);
        //    }
        //    // The above code should be able to utilize reflection to avoid all the stuff below.

        //    //customer.Customer_ID = (int?)row["Customer_ID"];
        //    //customer.FirstName = row["FirstName"].ToString();
        //    //customer.MiddleInitial = row["MiddleInitial"].ToString();
        //    //customer.LastName = row["LastName"].ToString();
        //    //customer.DOB = (DateTime?)row["DOB"];
        //    //customer.PhoneNumber = row["PhoneNumber"].ToString();
        //    //customer.StreetAddress = row["StreetAddress"].ToString();
        //    //customer.CityName = row["CityName"].ToString();
        //    //customer.StateName = row["StateName"].ToString();
        //    //customer.Zip = row["Zip"].ToString();
        //    //customer.ISIS_ID = (int?)row["ISIS_ID"];
        //}
        
        //private void ClearDirtyRows()
        //{
        //    foreach (CustomerRoster cust in modifiedCustomers)
        //    {
        //        DataGridViewRow row = dgvCustomerData.Rows.Cast<DataGridViewRow>() // find the matching gridview row for a given Customer_ID.
        //                                        .Where(r => r.Cells["Customer_ID"].Value as int? == cust.Customer_ID)
        //                                        .First();
        //        row.DefaultCellStyle.BackColor = DefaultBackColor;
        //    }
        //    modifiedCustomers.Clear();
        //}

        #endregion ///////////////      Private Methods   /////////////////////////

        #region ///////////////      Form Events   /////////////////////////

        private void BtAdd_Click(object sender, EventArgs e)
        {
            //TODO: Create and integrate a form to add a new Customer/Client.
            using (formNewCustomer newCustomer = new formNewCustomer())
            {
                newCustomer.ShowDialog();
            }
            //MessageBox.Show(
            //    "Not Yet Available",
            //    "Sorry! That feature has not yet been implemented or is not fully functional.",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information);
            //// TODO: Implement this
            //throw new NotImplementedException();
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            foreach (CustomerRoster customer in modifiedCustomers)
            {
                CustomerRoster.updateCustomer(customer);
            }
            //ClearDirtyRows(); // clears the selection collection and resets rows to default colors.
            RefreshCustomers();
        }

        private void DgvCustomerData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Int32.TryParse(dgvCustomerData.SelectedRows[0].Cells["Customer_ID"].Value.ToString(), out int customerID))
            {
                formCustomerDetailView detailView = new formCustomerDetailView(customerID);
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
                gridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
                //DataRowView currentRowView = (DataRowView)gridView.Rows[e.RowIndex].DataBoundItem;
                //DataRow currentRow = currentRowView.Row;
                CustomerRoster modifiedCustomer = (CustomerRoster)gridView.Rows[e.RowIndex].DataBoundItem;
                //CustomerRowToObject(currentRow, modifiedCustomer);
                CustomerRoster match = modifiedCustomers.Where(cust => cust.Customer_ID == modifiedCustomer.Customer_ID).FirstOrDefault();
                if (modifiedCustomers.Contains(match)) // if we captured this customer before, delete the previous snapshot.
                {
                    modifiedCustomers.Remove(match);
                }
                modifiedCustomers.Add(modifiedCustomer); // add the new changes to the queue regardless.

                gridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aqua;
                if (!btUpdate.Enabled)
                {
                    btUpdate.Enabled = true;
                }
            }
        }

        private void BtRefresh_Click(object sender, EventArgs e)
        {
            RefreshCustomers();
        }

        private void DgvCustomerData_SelectionChanged(object sender, EventArgs e)
        {
            DataRow currentRow = null;
            if (dgvCustomerData.SelectedRows.Count > 0)
            try
            {
                if (dgvCustomerData.SelectedRows[0].DataBoundItem.GetType() == typeof(CustomerRoster))
                {
                    currentCustomer = (CustomerRoster)dgvCustomerData.SelectedRows[0].DataBoundItem;
                }
                // The following fails on datarow.select() results (array of DataRow objects)
                //else if (dgvCustomerData.SelectedRows[0].DataBoundItem.GetType() == typeof(DataRowView))
                //{
                //    DataRowView currentRowView = (DataRowView)dgvCustomerData.SelectedRows[0].DataBoundItem;
                //    currentRow = currentRowView.Row;
                //}
                //else if (dgvCustomerData.SelectedRows[0].DataBoundItem.GetType() == typeof(DataRow))
                //{
                //    currentRow = (DataRow)dgvCustomerData.SelectedRows[0].DataBoundItem;
                //}
                //CustomerRowToObject(currentRow, currentCustomer);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Exception: {ex}");
            }
        }

        private void BtViewAlerts_Click(object sender, EventArgs e)
        {
            if (dgvCustomerData.SelectedRows.Count > 0)
            {
                if (Int32.TryParse(dgvCustomerData.SelectedRows[0].Cells["Customer_ID"].Value.ToString(), out int customerID))
                {
                    using (formAlertView alertForm = new formAlertView(currentCustomer))
                    {
                        alertForm.ShowDialog();
                    }
                }
            }            
        }

        private void TbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {                        
            // When user presses Enter in the search box, initiate search/filter.
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                this.Cursor = Cursors.WaitCursor;
                string searchText = tbSearch.Text.ToLower();
                dgvCustomerData.DataSource = customerList
                    .Where(
                            c => (c.FirstName ?? "").ToLower().Contains(searchText)
                            || (c.LastName ?? "").ToLower().Contains(searchText)
                            || (c.ISIS_ID ?? 0).ToString().ToLower().Contains(searchText)
                            || (c.CityName ?? "").ToLower().Contains(searchText)
                            || c.Customer_ID.ToString().ToLower().Contains(searchText)
                            || c.DateOfService.ToString().ToLower().Contains(searchText)
                            || (c.DOB ?? DateTime.MinValue).ToString().ToLower().Contains(searchText)
                            || (c.Email ?? "").ToLower().Contains(searchText)
                            || (c.EnrollmentType ?? "").ToLower().Contains(searchText)
                            || c.IntakeDate.ToString().ToLower().Contains(searchText)
                            || (c.MiddleInitial ?? "").ToLower().Contains(searchText)
                            || (c.Notes ?? "").ToLower().Contains(searchText)
                            || (c.PhoneNumber ?? "").ToLower().Contains(searchText)
                            || c.PSAExpDate.ToString().ToLower().Contains(searchText)
                            || (c.ReasonForVisit ?? "").ToLower().Contains(searchText)
                            || (c.StateName ?? "").ToLower().Contains(searchText)
                            || (c.StreetAddress ?? "").ToLower().Contains(searchText)
                            || c.SubmissionDate.ToString().ToLower().Contains(searchText)
                            || (c.YouthSchool ?? "").ToLower().Contains(searchText)
                            || (c.Zip ?? "").ToLower().Contains(searchText)).ToList();

                this.Cursor = Cursors.Default;
            }
        }

        #endregion ///////////////      Form Events   /////////////////////////        

    }
}
