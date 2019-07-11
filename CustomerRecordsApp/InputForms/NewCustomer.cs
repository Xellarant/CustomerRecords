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
    public partial class formNewCustomer : Form
    {
        CustomerRoster cust = new CustomerRoster();
        public formNewCustomer()
        {
            InitializeComponent();
        }

        private void BtSubmit_Click(object sender, EventArgs e)
        {
            int testInt;
            try
            {
                cust.AgeGroup = chbYouth.Checked ? "Y" : "A";
                cust.SelfCertified = chbSelfCert.Checked ? "Yes" : "No";
                cust.FirstName = tbFirstName.Text;
                cust.MiddleInitial = tbMiddleInitial.Text;
                cust.LastName = tbLastName.Text;
                cust.DOB = dtpDOB.Value;
                cust.PhoneNumber = tbPhoneNumber.Text;
                cust.Staff = tbStaff.Text;
                if (cbEnrollmentType.SelectedItem != null)
                {
                    cust.EnrollmentType = cbEnrollmentType.SelectedItem.ToString();
                }
                else
                {
                    cust.EnrollmentType = "New";
                }
                cust.ReasonForVisit = tbReasonForVisit.Text;
                cust.IntakeDate = dtpIntake.Value;
                if (int.TryParse(tbISIS_ID.Text, out testInt))
                {
                    cust.ISIS_ID = testInt;
                }
                else
                {
                    cust.ISIS_ID = null;
                }
                cust.PSAExpDate = dtpPSAExp.Value;
                cust.YouthSchool = tbYouthSchool.Text;
                cust.StreetAddress = tbAddress.Text;
                cust.CityName = tbCity.Text;
                cust.StateName = tbState.Text;
                cust.Zip = tbZip.Text;
                cust.Email = tbEmail.Text;
                cust.Notes = rtbNotes.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error capturing customer",
                    "There was a problem reading the data! \n\n" +
                    $"Exception: {ex}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);                
            }
            

            try
            {
                CustomerRoster.addCustomerRoster(cust);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error adding customer",
                    "There was a problem adding to the database! \n\n " +
                    $"Exception: {ex}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ChbYouth_CheckedChanged(object sender, EventArgs e)
        {
            if (chbYouth.Checked)
            {
                dtpPSAExp.Checked = true;
            }
            else
            {
                dtpPSAExp.Checked = false;
            }
        }
    }
}
