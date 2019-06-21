using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CustomerRecordsApp.Data
{
    public abstract class ConnectionAccess
    {
        /// <summary>
        /// Gets connection strings
        /// </summary>
        /// 

        public static string connString // alias for default string set programmatically (just so it only changes in one place)
        {
            get
            {
                return ListingsString;
            }
        }

        public static string AzureString
        {
            get
            {
                return ConfigurationManager
                    .ConnectionStrings["AzureTestDB"]
                    .ToString();
            }
        }

        public static string AccessString
        {
            get
            {
                return ConfigurationManager
                    .ConnectionStrings["AccessDB"]
                    .ToString();
            }
        }

        public static string ListingsString
        {
            get
            {
                return ConfigurationManager
                    .ConnectionStrings["AzureListingsDB"]
                    .ToString();
            }
        }
    }
}
