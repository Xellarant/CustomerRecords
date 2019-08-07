using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CustomerRecordsApp.Data.Access
{
    public partial class CustomerRoster : Customer
    {
        #region Properties        
        // just said screw it and put all the properties in Customer. 
        // Not using reflection for the different types anymore(Just Customer), so it should be fine(?)

        #endregion End Properties

        #region Methods
        /// <summary>
        /// Returns a List of CustomerRoster objects (variant of DataTable Method)
        /// </summary>
        /// <param name="Customer_ID"></param>
        /// <returns></returns>
        public static List<CustomerRoster> getCustomerList(int? Customer_ID = null)
        {
            DataTable dt = new DataTable();
            List<CustomerRoster> customerRosterList = new List<CustomerRoster>();
            //string query = Scripts.sqlGetCustomerDetails;
            string query = Scripts.sqlGetCustomerRosterDetails;
            using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                dataAdapter.SelectCommand = new OleDbCommand();
                dataAdapter.SelectCommand.Connection = new OleDbConnection(ConnectionAccess.connString);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                // Assign the SQL to the command object
                dataAdapter.SelectCommand.CommandText = query;
                if (Customer_ID != null)
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Customer_ID", Customer_ID);
                }
                else
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Customer_ID", DBNull.Value);
                }
                // Fill the datatable from adapter
                try
                {
                    dataAdapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine($"An Error Occured trying to retrieve the data!.\n\nException: {ex}");
                }
            } // end using scope
            foreach (DataRow row in dt.Rows)
            {
                CustomerRoster tempCust = new CustomerRoster();
                foreach (PropertyInfo property in typeof(CustomerRoster).GetProperties())
                {
                    var rowVal = row[$"{property.Name}"];
                    if (rowVal.GetType() == typeof(DBNull))
                    {
                        rowVal = null;
                    }
                    property.SetValue(tempCust, rowVal);
                }
                customerRosterList.Add(tempCust);
            }
            return customerRosterList;
        }

        /// <summary>
        /// Function to do a Customer Search in SQL (for now until in-memory option is figured out).
        /// </summary>
        /// <param name="SearchText"></param>        
        public static DataTable getFilteredCustomerList(string SearchText)
        {
            DataTable filteredTable = new DataTable();
            string query = Scripts.sqlGetFilteredCustomerList;
            using (
                OleDbCommand dbCommand = new OleDbCommand()
                {
                    Connection = new OleDbConnection(ConnectionAccess.connString),
                    CommandType = CommandType.Text,
                    CommandText = query,
                    Parameters =
                        {
                            new OleDbParameter("@Customer_ID", SearchText),
                            new OleDbParameter("@Roster_ID", SearchText),
                            new OleDbParameter("@FirstName", SearchText),
                            new OleDbParameter("@MiddleInitial", SearchText),
                            new OleDbParameter("@LastName", SearchText),
                            new OleDbParameter("@DOB", SearchText),
                            new OleDbParameter("@DateOfService", SearchText),
                            new OleDbParameter("@Staff", SearchText),
                            new OleDbParameter("@EnrollmentType", SearchText),
                            new OleDbParameter("@StreetAddress", SearchText),
                            new OleDbParameter("@CityName", SearchText),
                            new OleDbParameter("@StateName", SearchText),
                            new OleDbParameter("@Zip", SearchText),
                            new OleDbParameter("@ReferredBy", SearchText),
                            new OleDbParameter("@ReasonForVisit", SearchText),
                            new OleDbParameter("@SubmissionDate", SearchText),
                            new OleDbParameter("@ISIS_ID", SearchText),
                            new OleDbParameter("@SelfCertified", SearchText),
                            new OleDbParameter("@IntakeDate", SearchText),
                            new OleDbParameter("@AgeGroup", SearchText),
                            new OleDbParameter("@PSAExpDate", SearchText),
                            new OleDbParameter("@YouthSchool", SearchText),
                            new OleDbParameter("@Notes", SearchText),
                            new OleDbParameter("@PhoneNumber", SearchText),
                            new OleDbParameter("@Email", SearchText),
                            new OleDbParameter("@PY_ID", SearchText),
                        }
                }) // end using parenthetical
            { // begin using scope
                foreach (OleDbParameter param in dbCommand.Parameters)
                {
                    param.Value = String.IsNullOrWhiteSpace(param.Value.ToString()) ? null : param.Value;
                    if (param.Value == null)
                    {
                        param.Value = DBNull.Value;
                    }
                }
                using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(dbCommand))
                {
                    try
                    {
                        dataAdapter.Fill(filteredTable);
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine($"An Error Occured trying to retrieve the data!.\n\nException: {ex}");
                    }
                }
            } // end cmd using scope
            return filteredTable;
        } // end getFilteredCustomerList

        public static void addCustomerRoster(CustomerRoster cust)
        {
            addCustomer(cust);
            string query = Scripts.sqlAddCustomerRoster;
            using (
                OleDbCommand dbCommand = new OleDbCommand()
                {
                    Connection = new OleDbConnection(ConnectionAccess.connString),
                    CommandType = CommandType.Text,
                    CommandText = query,
                    Parameters =
                        {
                            new OleDbParameter("@DateOfService", OleDbType.Date),
                            new OleDbParameter("@FirstName", cust.FirstName),
                            new OleDbParameter("@MiddleInitial", cust.MiddleInitial),
                            new OleDbParameter("@LastName", cust.LastName),
                            new OleDbParameter("@DOB", OleDbType.Date),
                            new OleDbParameter("@PhoneNumber", cust.PhoneNumber),
                            new OleDbParameter("@Staff", cust.Staff),
                            new OleDbParameter("@EnrollmentType", cust.EnrollmentType),
                            new OleDbParameter("@ReasonForVisit", cust.ReasonForVisit),
                            new OleDbParameter("@IntakeDate", OleDbType.Date),
                            new OleDbParameter("@ISIS_ID", cust.ISIS_ID),
                            new OleDbParameter("@AgeGroup", cust.AgeGroup),
                            new OleDbParameter("@SelfCertified", cust.SelfCertified),
                            new OleDbParameter("@PSAExpDate", OleDbType.Date),
                            new OleDbParameter("@YouthSchool", cust.YouthSchool),
                            new OleDbParameter("@Email", cust.Email),
                            new OleDbParameter("@Notes", cust.Notes)                        
                        }
                }) // end using parenthetical
            { // begin using scope
                dbCommand.Parameters[0].Value = cust.DateOfService;
                dbCommand.Parameters[4].Value = cust.DOB;
                dbCommand.Parameters[9].Value = cust.IntakeDate;
                dbCommand.Parameters[13].Value = cust.PSAExpDate;

                foreach (OleDbParameter param in dbCommand.Parameters)
                { // replace ambiguous null values with explicit DBNulls.
                    if (param.Value == null)
                    {
                        param.Value = DBNull.Value;
                    }
                }
                dbCommand.Connection.Open();
                int rowsAffected = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();
                Console.WriteLine($"Rows affected: {rowsAffected}");
            }
        }

        #endregion  End Methods
    }
    public partial class Customer
    {
        public int Customer_ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public DateTime? DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string StreetAddress { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public string Zip { get; set; }
        public int? ISIS_ID { get; set; }
        public DateTime DateOfService { get; set; }
        public string Staff { get; set; }
        public string EnrollmentType { get; set; }
        public string ReferredBy { get; set; }
        public string ReasonForVisit { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string SelfCertified { get; set; }
        public DateTime IntakeDate { get; set; }
        public string AgeGroup { get; set; }
        public DateTime PSAExpDate { get; set; }
        public string YouthSchool { get; set; }
        public string Notes { get; set; }
        public string Email { get; set; }
        public int? PY_ID { get; set; }
        public int? Roster_ID { get; set; }

        //OleDbConnection conn = new OleDbConnection(ConnectionAccess.connString);

        /// <summary>
        /// Pulls a list of all customers (if not given a customer ID. Else, pulls specific Customer details.
        /// </summary>
        /// <param name="dt"></param>
        public static DataTable getCustomerTable(int? Customer_ID = null)
        {
            DataTable dt = new DataTable();
            //string query = Scripts.sqlGetCustomerDetails;
            string query = Scripts.sqlGetCustomerRosterDetails;
            using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                dataAdapter.SelectCommand = new OleDbCommand();
                dataAdapter.SelectCommand.Connection = new OleDbConnection(ConnectionAccess.connString);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                // Assign the SQL to the command object
                dataAdapter.SelectCommand.CommandText = query;
                if (Customer_ID != null)
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Customer_ID", Customer_ID);
                }
                else
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Customer_ID", DBNull.Value);
                }
                // Fill the datatable from adapter
                try
                {
                    dataAdapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine($"An Error Occured trying to retrieve the data!.\n\nException: {ex}");
                }
            } // end using scope
            return dt;
        }

        public static void addCustomer(Customer cust)
        {
            string query = Scripts.sqlAddCustomer;
            using (
                OleDbCommand dbCommand = new OleDbCommand()
                {
                    Connection = new OleDbConnection(ConnectionAccess.connString),
                    CommandType = CommandType.Text,
                    CommandText = query,
                    Parameters =
                        {
                            new OleDbParameter("@FirstName", cust.FirstName),
                            new OleDbParameter("@MiddleInitial", cust.MiddleInitial),
                            new OleDbParameter("@LastName", cust.LastName),
                            new OleDbParameter("@DOB", OleDbType.Date),
                            new OleDbParameter("@PhoneNumber", cust.PhoneNumber),
                            new OleDbParameter("@StreetAddress", cust.StreetAddress),
                            new OleDbParameter("@CityName", cust.CityName),
                            new OleDbParameter("@StateName", cust.StateName),
                            new OleDbParameter("@Zip", cust.Zip),
                            new OleDbParameter("@ISIS_ID", cust.ISIS_ID)
                        }
                }) // end using parenthetical
            { // begin using scope
                dbCommand.Parameters[3].Value = cust.DOB;
                foreach (OleDbParameter param in dbCommand.Parameters)
                { // replace ambiguous null values with explicit DBNulls.
                    if (param.Value == null)
                    {
                        param.Value = DBNull.Value;
                    }
                }
                dbCommand.Connection.Open();
                int rowsAffected = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();
                Console.WriteLine($"Rows affected: {rowsAffected}");
            }
        }

        public static void updateCustomer(Customer cust)
        {
            string query = Scripts.sqlUpdateCustomer;
            using (
                OleDbCommand dbCommand = new OleDbCommand()
                {
                    Connection = new OleDbConnection(ConnectionAccess.connString),
                    CommandType = CommandType.Text,
                    CommandText = query,
                    Parameters =
                        {                            
                            new OleDbParameter("@FirstName", cust.FirstName),
                            new OleDbParameter("@MiddleInitial", cust.MiddleInitial),
                            new OleDbParameter("@LastName", cust.LastName),
                            new OleDbParameter("@DOB", OleDbType.Date),
                            new OleDbParameter("@PhoneNumber", cust.PhoneNumber),
                            new OleDbParameter("@StreetAddress", cust.StreetAddress),
                            new OleDbParameter("@CityName", cust.CityName),
                            new OleDbParameter("@StateName", cust.StateName),
                            new OleDbParameter("@Zip", cust.Zip),
                            new OleDbParameter("@ISIS_ID", cust.ISIS_ID),
                            new OleDbParameter("@Customer_ID", cust.Customer_ID)
                        }
                }) // end using parenthetical
            { // begin using scope
                dbCommand.Parameters[3].Value = cust.DOB;
                foreach (OleDbParameter param in dbCommand.Parameters)
                {
                    if (param.Value == null)
                    {
                        param.Value = DBNull.Value;
                    }
                }
                dbCommand.Connection.Open();
                int rowsAffected = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();
                Console.WriteLine($"Rows affected: {rowsAffected}");
            }
        }

        public static void getCustomerAlertsList(DataTable dt, int? Customer_ID = null)
        {
            string query = Scripts.sqlgetCustomerAlerts;
            using (
                OleDbCommand dbCommand = new OleDbCommand()
                {
                    Connection = new OleDbConnection(ConnectionAccess.connString),
                    CommandType = CommandType.Text,
                    CommandText = query,
                    Parameters =
                        {
                            new OleDbParameter("@Customer_ID", Customer_ID)
                        }
                }) // end using parenthetical
            { // begin using scope
                foreach (OleDbParameter param in dbCommand.Parameters)
                {
                    if (param.Value == null)
                    {
                        param.Value = DBNull.Value;
                    }
                }
                using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(dbCommand))
                {
                    try
                    {
                        dataAdapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine($"An Error Occured trying to retrieve the data!.\n\nException: {ex}");
                    }
                }
            } // end cmd using scope
        } // end getCustomerAlertsList

        /// <summary>
        /// Method for getting the types of Alerts
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="Customer_ID"></param>
        public static void getCustomerAlertTypesList(DataTable dt)
        {
            string query = Scripts.sqlgetCustomerAlertTypes;
            using (
                OleDbCommand dbCommand = new OleDbCommand()
                {
                    Connection = new OleDbConnection(ConnectionAccess.connString),
                    CommandType = CommandType.Text,
                    CommandText = query
                }) // end using parenthetical
            { // begin using scope                
                using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(dbCommand))
                {
                    try
                    {
                        dataAdapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine($"An Error Occured trying to retrieve the data!.\n\nException: {ex}");
                    }
                }
            } // end cmd using scope
        } // end getCustomerAlertsList

        /// <summary>
        /// Adds an alert for a selected customer with given text.
        /// </summary>
        /// <param name="customerID"></param>
        /// <param name="alertTypeID"></param>
        /// <param name="text"></param>
        public static void addCustomerAlert(int customerID, int alertTypeID, string details)
        {

            string query = Scripts.sqlAddCustomerAlert;
            using (
                OleDbCommand dbCommand = new OleDbCommand()
                {
                    Connection = new OleDbConnection(ConnectionAccess.connString),
                    CommandType = CommandType.Text,
                    CommandText = query,
                    Parameters =
                        {
                            new OleDbParameter("@Customer_ID", customerID),
                            new OleDbParameter("@AlertType_ID", alertTypeID),
                            new OleDbParameter("@Details", details)
                        }
                }) // end using parenthetical
            { // begin using scope
                foreach (OleDbParameter param in dbCommand.Parameters)
                { // replace ambiguous null values with explicit DBNulls.
                    if (param.Value == null)
                    {
                        param.Value = DBNull.Value;
                    }
                }
                dbCommand.Connection.Open();
                int rowsAffected = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();
                Console.WriteLine($"Rows affected: {rowsAffected}");
            }
        } // end addCustomerAlert

        public static DataTable getNotes(int customerNotesID)
        {
            DataTable dt = new DataTable();
            string query = Scripts.sqlgetCustomerNotesByID;
            using (
                OleDbCommand dbCommand = new OleDbCommand()
                {
                    Connection = new OleDbConnection(ConnectionAccess.connString),
                    CommandType = CommandType.Text,
                    CommandText = query,
                    Parameters =
                        {
                            new OleDbParameter("@CustomerNotes_ID", customerNotesID)
                        }
                }) // end using parenthetical
            { // begin using scope
                using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(dbCommand))
                {
                    try
                    {
                        dataAdapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine($"An Error Occured trying to retrieve the data!.\n\nException: {ex}");
                    }
                }
            }
            return dt;
        } // end getCustomerNotes


        /// <summary>
        /// Adds Notes for a given customer.
        /// </summary>
        /// <param name="customerID"></param>
        /// <param name="notes"></param>
        /// /// <param name="notesDate"></param>
        public static void addNotes(int customerID, string notes, DateTime notesDate)
        {
            string query = Scripts.sqlAddCustomerNotes;
            using (
                OleDbCommand dbCommand = new OleDbCommand()
                {
                    Connection = new OleDbConnection(ConnectionAccess.connString),
                    CommandType = CommandType.Text,
                    CommandText = query,
                    Parameters =
                        {
                            new OleDbParameter("@Customer_ID", OleDbType.Integer),
                            new OleDbParameter("@Notes", OleDbType.LongVarChar),
                            new OleDbParameter("@NotesDate", OleDbType.Date) // captures date AND Time.
                        }
                }) // end using parenthetical
            { // begin using scope
                dbCommand.Parameters[0].Value = customerID;
                dbCommand.Parameters[1].Value = notes;
                dbCommand.Parameters[2].Value = notesDate;
                foreach (OleDbParameter param in dbCommand.Parameters)
                { // replace ambiguous null values with explicit DBNulls.
                    if (param.Value == null)
                    {
                        param.Value = DBNull.Value;
                    }
                }
                dbCommand.Connection.Open();
                int rowsAffected = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();
                Console.WriteLine($"Rows affected: {rowsAffected}");
            }
        } // end addCustomerNotes

        /// <summary>
        /// Method for updating a particular CustomerNotes record (changing the date or note itself)
        /// </summary>
        /// <param name="customerNotesID"></param>
        /// <param name="notes"></param>
        /// <param name="notesDate"></param>
        public static void updateNotes(int customerNotesID, string notes, DateTime notesDate)
        {
            string query = Scripts.sqlUpdateCustomerNotes;
            using (
                OleDbCommand dbCommand = new OleDbCommand()
                {
                    Connection = new OleDbConnection(ConnectionAccess.connString),
                    CommandType = CommandType.Text,
                    CommandText = query,
                    Parameters =
                        {
                            new OleDbParameter("@Notes", OleDbType.LongVarChar),
                            new OleDbParameter("@NotesDate", OleDbType.Date), // captures date AND Time.
                            new OleDbParameter("@CustomerNotes_ID", OleDbType.Integer)
                        }
                }) // end using parenthetical
            { // begin using scope                
                dbCommand.Parameters[0].Value = notes;
                dbCommand.Parameters[1].Value = notesDate;
                dbCommand.Parameters[2].Value = customerNotesID;
                foreach (OleDbParameter param in dbCommand.Parameters)
                { // replace ambiguous null values with explicit DBNulls.
                    if (param.Value == null)
                    {
                        param.Value = DBNull.Value;
                    }
                }
                dbCommand.Connection.Open();
                int rowsAffected = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();
                Console.WriteLine($"Rows affected: {rowsAffected}");
            }
        } // end updateCustomerNotes


        /// <summary>
        /// Method for getting the types of Alerts
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="Customer_ID"></param>
        public static void getCustomerNotesList(DataTable dt, int customerID)
        {
            string query = Scripts.sqlgetCustomerNotes;
            using (
                OleDbCommand dbCommand = new OleDbCommand()
                {
                    Connection = new OleDbConnection(ConnectionAccess.connString),
                    CommandType = CommandType.Text,
                    CommandText = query,
                    Parameters =
                    {
                        new OleDbParameter("@Customer_ID", customerID)
                    }
                }) // end using parenthetical
            { // begin using scope                
                using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(dbCommand))
                {
                    try
                    {
                        dataAdapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine($"An Error Occured trying to retrieve the data!.\n\nException: {ex}");
                    }
                }
            } // end cmd using scope
        } // end getCustomerNotesList


        public static void getCustomerReferralsList(DataTable dt, int? Customer_ID = null)
        {
            string query = Scripts.sqlgetCustomerReferrals;
            using (
                OleDbCommand dbCommand = new OleDbCommand()
                {
                    Connection = new OleDbConnection(ConnectionAccess.connString),
                    CommandType = CommandType.Text,
                    CommandText = query,
                    Parameters =
                        {
                            new OleDbParameter("@Customer_ID", Customer_ID)
                        }
                }) // end using parenthetical
            { // begin using scope
                foreach (OleDbParameter param in dbCommand.Parameters)
                {
                    if (param.Value == null)
                    {
                        param.Value = DBNull.Value;
                    }
                }
                using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(dbCommand))
                {
                    try
                    {
                        dataAdapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine($"An Error Occured trying to retrieve the data!.\n\nException: {ex}");
                    }
                }
            } // end cmd using scope
        } // end getReferralsList function
        

    }    

}
