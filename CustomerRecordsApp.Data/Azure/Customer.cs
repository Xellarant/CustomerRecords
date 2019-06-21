using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRecordsApp.Data.Azure
{
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

        public static DataTable getCustomerTable()
        {
            DataTable dt = new DataTable();
            string query = "EXEC getCustomerList";
            SqlCommand cmd = new SqlCommand(query, new SqlConnection(ConnectionAccess.connString))
            {
                //List<CustomerRecords> CustomerList = new List<CustomerRecords>();
                //CustomerList = cmd.ExecuteReader();
                CommandType = CommandType.Text
            };
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            try
            {
                dataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Could not access data!\n\nException: {ex}");
            }
            return dt;
        }

        public static void addCustomer(Customer cust)
        {
            string query = "addCustomer";
            SqlConnection conn;
            using (SqlCommand cmd = new SqlCommand(query, conn = new SqlConnection(ConnectionAccess.connString))
                {
                    CommandType = CommandType.StoredProcedure,
                    Parameters =
                    {
                        new SqlParameter("@FirstName", cust.FirstName),
                        new SqlParameter("@MiddleInitial", cust.MiddleInitial),
                        new SqlParameter("@LastName", cust.LastName),
                        new SqlParameter("@DOB", cust.DOB),
                        new SqlParameter("@PhoneNumber", cust.PhoneNumber),
                        new SqlParameter("@StreetAddress", cust.StreetAddress),
                        new SqlParameter("@CityName", cust.CityName),
                        new SqlParameter("@StateName", cust.StateName),
                        new SqlParameter("@Zip", cust.Zip),
                        new SqlParameter("@ISIS_ID", cust.ISIS_ID)
                    }
                })
            {
                foreach (SqlParameter param in cmd.Parameters)
                {
                    if (param.Value == null)
                    {
                        param.Value = DBNull.Value;
                    }
                }
                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("Customer Added. Rows affected: " + rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                }
            }
            
        }

        public static void updateCustomer(Customer cust)
        {
            SqlConnection conn;
            string query = "updateCustomer";
            using (SqlCommand cmd = new SqlCommand(query, conn = new SqlConnection(ConnectionAccess.connString))
            {
                CommandType = CommandType.StoredProcedure,
                Parameters =
                {
                    new SqlParameter("@Customer_ID", cust.Customer_ID),
                    new SqlParameter("@FirstName", cust.FirstName),
                    new SqlParameter("@MiddleInitial", cust.MiddleInitial),
                    new SqlParameter("@LastName", cust.LastName),
                    new SqlParameter("@DOB", cust.DOB),
                    new SqlParameter("@PhoneNumber", cust.PhoneNumber),
                    new SqlParameter("@StreetAddress", cust.StreetAddress),
                    new SqlParameter("@CityName", cust.CityName),
                    new SqlParameter("@StateName", cust.StateName),
                    new SqlParameter("@Zip", cust.Zip),
                    new SqlParameter("@ISIS_ID", cust.ISIS_ID)
                }
            })
            {
                try
                {
                    foreach (SqlParameter param in cmd.Parameters)
                    {
                        if (param.Value == null)
                        {
                            param.Value = DBNull.Value;
                        }
                    }
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("Customer Updated. Rows affected: " + rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                }
            }
            
        }

        public static void addNotes(int Customer_ID, string Notes, DateTime NotesDate)
        {
            SqlConnection conn;
            string query = "addCustomerNotes";
            using (SqlCommand cmd = new SqlCommand(query, conn = new SqlConnection(ConnectionAccess.connString))
            {
                CommandType = CommandType.StoredProcedure,
                Parameters =
                {
                    new SqlParameter("@Customer_ID", Customer_ID),
                    new SqlParameter("@Notes", Notes),
                    new SqlParameter("@NotesDate", NotesDate)
                }
            })
            {
                try
                {
                    foreach (SqlParameter param in cmd.Parameters)
                    {
                        if (param.Value == null)
                        {
                            param.Value = DBNull.Value;
                        }
                    }
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("Notes Added. Rows affected: " + rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                }
            }

        }

        //TODO: Change all list methods to utilize StoredProcedure Command Type.
        public static void getCustomerReferralsList(DataTable dt, int CustomerID)
        {
            string query = $"EXEC getCustomerReferralsList {CustomerID}";
            SqlCommand cmd = new SqlCommand(query, new SqlConnection(ConnectionAccess.connString))
            {                
                CommandType = CommandType.Text
            };
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
        }
        public static void getCustomerServicesList (DataTable dt, int CustomerID)
        {
            string query = $"EXEC getCustomerServicesList {CustomerID}";
            SqlCommand cmd = new SqlCommand(query, new SqlConnection(ConnectionAccess.connString))
            {
                CommandType = CommandType.Text
            };
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
        }

        public static void getCustomerOutcomesList(DataTable dt, int CustomerID)
        {
            string query = $"EXEC getCustomerOutcomesList {CustomerID}";
            SqlCommand cmd = new SqlCommand(query, new SqlConnection(ConnectionAccess.connString))
            {
                CommandType = CommandType.Text
            };
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
        }

        public static void getOutcomeIndicatorsList(DataTable dt)
        {
            string query = $"EXEC getOutcomeIndicatorsList";
            SqlCommand cmd = new SqlCommand(query, new SqlConnection(ConnectionAccess.connString))
            {
                CommandType = CommandType.Text
            };
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
        }

        public static void getCustomerNotesList(DataTable dt, int CustomerID)
        {
            string query = $"EXEC getCustomerNotesList {CustomerID}";
            SqlCommand cmd = new SqlCommand(query, new SqlConnection(ConnectionAccess.connString))
            {
                CommandType = CommandType.Text
            };
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
        }

        public static void getCustomerAlertsList(DataTable dt, int CustomerID)
        {
            string query = $"EXEC getCustomerAlertsList {CustomerID}";
            SqlCommand cmd = new SqlCommand(query, new SqlConnection(ConnectionAccess.connString))
            {
                CommandType = CommandType.Text
            };
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
        }
    }    

}
