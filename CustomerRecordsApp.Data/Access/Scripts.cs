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

        /// <summary>
        /// Sql script to get customer details from roster table
        /// </summary>
        public static readonly string sqlGetCustomerRosterDetails = "SELECT "
            + "cust.Roster_ID, cust.Customer_ID, cust.FirstName, cust.MiddleInitial, " +
            "cust.LastName, cust.DOB, crost.DateOfService, crost.Staff, crost.EnrollmentType, " +
            "cust.StreetAddress, cust.CityName, cust.StateName, cust.Zip, "
            + "crost.ReferredBy, crost.ReasonForVisit, crost.SubmissionDate, crost.ISIS_ID, "
            + "crost.SelfCertified, crost.IntakeDate, crost.AgeGroup, crost.PSAExpDate, crost.YouthSchool, "
            + "crost.Notes, crost.PhoneNumber, crost.Email, crost.PY_ID"
            + " FROM CustomerRosterDenormalized crost " +
            "RIGHT JOIN Customers cust ON crost.RosterID = cust.Roster_ID" +
            " WHERE cust.Customer_ID = @Customer_ID OR @Customer_ID IS NULL;";


        public static readonly string sqlUpdateCustomer = "UPDATE Customers "
            + "SET "
            + "FirstName = IIF(IsNull(@FirstName), FirstName, @FirstName)"
	        + ",MiddleInitial = IIF(IsNull(@MiddleInitial), MiddleInitial, @MiddleInitial)"
	        + ",LastName = IIF(IsNull(@LastName), LastName, @LastName)"
	        + ",DOB = IIF(IsNull(@DOB), DOB, @DOB)"
	        + ",PhoneNumber = IIF(IsNull(@PhoneNumber), PhoneNumber, @PhoneNumber)"
	        + ",StreetAddress = IIF(IsNull(@StreetAddress), StreetAddress, @StreetAddress)"
	        + ",CityName = IIF(IsNull(@CityName), CityName, @CityName)"
	        + ",StateName = IIF(IsNull(@StateName), StateName, @StateName)"
	        + ",Zip = IIF(IsNull(@Zip), Zip, @Zip)"
	        + ",ISIS_ID = IIF(IsNull(@ISIS_ID), ISIS_ID, @ISIS_ID)"
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
            + "ON ref.Agency_ID = age.Agency_ID WHERE   (cust.Customer_ID = @Customer_ID OR @Customer_ID IS NULL)";

        public static readonly string sqlAddCustomerAlert = "INSERT INTO CustomerAlerts (Customer_ID, AlertType_ID, Details) \n"
            + "VALUES(@Customer_ID, @AlertType_ID, @Details)";

        public static readonly string sqlgetCustomerAlertTypes = "SELECT AlertType_ID, TypeName FROM AlertTypes";

        public static readonly string sqlAddCustomerNotes = "INSERT INTO CustomerNotes(Customer_ID, Notes, NotesDate) \n"
            + "VALUES(@Customer_ID, @Notes, @NotesDate);";

        public static readonly string sqlgetCustomerNotes = "SELECT CustomerNotes_ID, Customer_ID, Notes, NotesDate, "
            + "CreateDate \nFROM CustomerNotes WHERE (Customer_ID = @Customer_ID OR @Customer_ID IS NULL)";

        public static readonly string sqlGetFilteredCustomerList = "SELECT "
            + "cust.Roster_ID, cust.Customer_ID, cust.FirstName, cust.MiddleInitial, " +
            "cust.LastName, cust.DOB, crost.DateOfService, crost.Staff, crost.EnrollmentType, " +
            "cust.StreetAddress, cust.CityName, cust.StateName, cust.Zip, "
            + "crost.ReferredBy, crost.ReasonForVisit, crost.SubmissionDate, crost.ISIS_ID, "
            + "crost.SelfCertified, crost.IntakeDate, crost.AgeGroup, crost.PSAExpDate, crost.YouthSchool, "
            + "crost.Notes, crost.PhoneNumber, crost.Email, crost.PY_ID"
            + " FROM CustomerRosterDenormalized crost " +
            "RIGHT JOIN Customers cust ON crost.RosterID = cust.Roster_ID" +
            " WHERE (cust.Customer_ID = @Customer_ID OR @Customer_ID IS NULL) " +
            "OR    (cust.Roster_ID = @Roster_ID OR @Roster_ID IS NULL) " +
            "OR    (cust.FirstName LIKE '*' + @FirstName + '*' OR @FirstName IS NULL) " +
            "OR    (cust.MiddleInitial LIKE '*' + @MiddleInitial + '*' OR @MiddleInitial IS NULL) " +
            "OR    (cust.LastName LIKE '*' + @LastName + '*' OR @LastName IS NULL) " +
            "OR    (cust.DOB LIKE '*' + @DOB + '*' OR @DOB IS NULL) " +
            "OR    (crost.DateOfService LIKE '*' + @DateOfService + '*' OR @DateOfService IS NULL) " +
            "OR    (crost.Staff LIKE '*' + @Staff + '*' OR @Staff IS NULL) " +
            "OR    (crost.EnrollmentType LIKE '*' + @EnrollmentType + '*' OR @EnrollmentType IS NULL) " +
            "OR    (cust.StreetAddress LIKE '*' + @StreetAddress + '*' OR @StreetAddress IS NULL) " +
            "OR    (cust.CityName LIKE '*' + @CityName + '*' OR @CityName IS NULL) " +
            "OR    (cust.StateName LIKE '*' + @StateName + '*' OR @StateName IS NULL) " +
            "OR    (cust.Zip LIKE '*' + @Zip + '*' OR @Zip IS NULL) " +
            "OR    (crost.ReferredBy LIKE '*' + @ReferredBy + '*' OR @ReferredBy IS NULL) " +
            "OR    (crost.ReasonForVisit LIKE '*' + @ReasonForVisit + '*' OR @ReasonForVisit IS NULL) " +
            "OR    (crost.SubmissionDate LIKE '*' + @SubmissionDate + '*' OR @SubmissionDate IS NULL) " +
            "OR    (crost.ISIS_ID LIKE '*' + @ISIS_ID + '*' OR @ISIS_ID IS NULL) " +
            "OR    (crost.SelfCertified LIKE '*' + @SelfCertified + '*' OR @SelfCertified IS NULL) " +
            "OR    (crost.IntakeDate LIKE '*' + @IntakeDate + '*' OR @IntakeDate IS NULL) " +
            "OR    (crost.AgeGroup LIKE '*' + @AgeGroup + '*' OR @AgeGroup IS NULL) " +
            "OR    (crost.PSAExpDate LIKE '*' + @PSAExpDate + '*' OR @PSAExpDate IS NULL) " +
            "OR    (crost.YouthSchool LIKE '*' + @YouthSchool + '*' OR @YouthSchool IS NULL) " +
            "OR    (crost.Notes LIKE '*' + @Notes + '*' OR @Notes IS NULL) " +
            "OR    (crost.PhoneNumber LIKE '*' + @PhoneNumber + '*' OR @PhoneNumber IS NULL) " +
            "OR    (crost.Email LIKE '*' + @Email + '*' OR @Email IS NULL) " +
            "OR    (cust.PY_ID = @PY_ID OR @PY_ID IS NULL) ";

        public static readonly string sqlAddCustomerRoster = "INSERT INTO CustomerRosterDenormalized " +
            "(DateOfService, FirstName, MiddleInitial, LastName, " +
            "DOB, PhoneNumber, Staff, EnrollmentType, ReasonForVisit, " +
            "IntakeDate, ISIS_ID, AgeGroup, SelfCertified, PSAExpDate, " +
            "YouthSchool, Email, Notes) " +
            "VALUES (@DateOfService, @FirstName, @MiddleInitial, " +
            "@LastName, @DOB, @PhoneNumber, @Staff, @EnrollmentType, " +
            "@ReasonForVisit, @IntakeDate, @ISIS_ID, @AgeGroup, " +
            "@SelfCertified, @PSAExpDate, @YouthSchool, @Email, @Notes);";

        public static readonly string sqlUpdateCustomerNotes = "UPDATE CustomerNotes " +
            "SET Notes = @Notes, NotesDate = @NotesDate WHERE CustomerNotes_ID = @CustomerNotes_ID";
        public static readonly string sqlgetCustomerNotesByID = "SELECT CustomerNotes_ID, Customer_ID, Notes, NotesDate, "
            + "CreateDate \nFROM CustomerNotes WHERE CustomerNotes_ID = @CustomerNotes_ID";
    }
}
