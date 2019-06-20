using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// DBConstants static class contains sql string constants
/// </summary>
namespace CustomerRecordsApp.Data
{
    public static class Scripts
    {
        /// <summary>
        /// Sql to get client/customer details (either all or by ID)
        /// </summary>
        public static readonly string sqlGetCustomerDetails = "SELECT "
            + "Customer_ID, FirstName, MiddleInitial, "
            + "LastName, DOB, PhoneNumber, StreetAddress, "
            + "CityName, StateName, Zip, ISIS_ID, AlertCount "
            + "FROM Customers WHERE Customer_ID = @Customer_ID OR @Customer_ID IS NULL;";

        public static readonly string sqlUpdateCustomer = "UPDATE Customers "
            + "SET "
            + "FirstName = ISNULL(@FirstName, FirstName)"
	        + ",MiddleInitial = ISNULL(@MiddleInitial, MiddleInitial)"
	        + ",LastName = ISNULL(@LastName, LastName)"
	        + ",DOB = ISNULL(@DOB, DOB)"
	        + ",PhoneNumber = ISNULL(@PhoneNumber, PhoneNumber)"
	        + ",StreetAddress = ISNULL(@StreetAddress, StreetAddress)"
	        + ",CityName = ISNULL(@CityName, CityName)"
	        + ",StateName = ISNULL(@StateName, StateName)"
	        + ",Zip = ISNULL(@Zip, Zip)"
	        + ",ISIS_ID = ISNULL(@ISIS_ID, ISIS_ID)"
            + " WHERE Customer_ID = @Customer_ID";

        public static readonly string sqlAddCustomer = "INSERT INTO "
            + "Customers(FirstName, MiddleInitial, LastName, DOB, PhoneNumber, StreetAddress"
            + ", CityName, StateName, Zip, ISIS_ID)\n"
            + " VALUES(@FirstName, @MiddleInitial, @LastName, @DOB, @PhoneNumber, @StreetAddress"
            + ", @CityName, @StateName, @Zip, @ISIS_ID)";

        public static readonly string sqlgetCustomerAlerts = "SELECT ca.CustomerAlert_ID, ca.Customer_ID,ca.AlertType_ID"
            + ", ca.Details,ca.CreateDate \nFROM   Customers cust INNER JOIN CustomerAlerts ca ON     cust.Customer_ID = ca.Customer_ID\n "
            + "WHERE(cust.Customer_ID = @Customer_ID OR @Customer_ID IS NULL)";

        public static readonly string sqlgetCustomerReferrals = "SELECT Referral_ID,age.AgencyName,age.AgencyAddress"
            + ",ref.AppointmentDate,ref.AppointmentTime,ref.ReferralContact	 ,ref.ReferralOriginator\n FROM   (Customers cust"
            + "\n INNER JOIN Referrals ref ON cust.Customer_ID = ref.Customer_ID) \nINNER JOIN Agencies age "
            + "ON ref.Agency_ID = age.Agency_ID WHERE   (@Customer_ID = 42 OR @Customer_ID IS NULL)";
    }
}
