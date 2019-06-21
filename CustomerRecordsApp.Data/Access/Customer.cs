using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRecordsApp.Data.Access
{
    public partial class Customer
    {
        public int? Customer_ID { get; set; }
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

        /// <summary>
        /// Pulls a list of all customers (if not given a customer ID. Else, pulls specific Customer details.
        /// </summary>
        /// <param name="dt"></param>
        public static DataTable getCustomerTable(int? Customer_ID = null)
        {
            DataTable dt = new DataTable();
            string query = Scripts.sqlGetCustomerDetails;
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
                            new OleDbParameter("@DOB", cust.DOB),
                            new OleDbParameter("@PhoneNumber", cust.PhoneNumber),
                            new OleDbParameter("@StreetAddress", cust.StreetAddress),
                            new OleDbParameter("@CityName", cust.CityName),
                            new OleDbParameter("@StateName", cust.StateName),
                            new OleDbParameter("@Zip", cust.Zip),
                            new OleDbParameter("@ISIS_ID", cust.ISIS_ID)
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
                            new OleDbParameter("@Customer_ID", cust.Customer_ID),
                            new OleDbParameter("@FirstName", cust.FirstName),
                            new OleDbParameter("@MiddleInitial", cust.MiddleInitial),
                            new OleDbParameter("@LastName", cust.LastName),
                            new OleDbParameter("@DOB", cust.DOB),
                            new OleDbParameter("@PhoneNumber", cust.PhoneNumber),
                            new OleDbParameter("@StreetAddress", cust.StreetAddress),
                            new OleDbParameter("@CityName", cust.CityName),
                            new OleDbParameter("@StateName", cust.StateName),
                            new OleDbParameter("@Zip", cust.Zip),
                            new OleDbParameter("@ISIS_ID", cust.ISIS_ID)
                        }
                }) // end using parenthetical
            { // begin using scope
                foreach(OleDbParameter param in dbCommand.Parameters)
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
