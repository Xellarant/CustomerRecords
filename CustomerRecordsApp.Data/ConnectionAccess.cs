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

        public static string connString
        {
            get
            {
                return AzureString;
            }
        }

        private static string AzureString
        {
            get
            {
                return ConfigurationManager
                    .ConnectionStrings["AzureTestDB"]
                    .ToString();
            }
        }

        private static string AccessString
        {
            get
            {
                return ConfigurationManager
                    .ConnectionStrings["AccessDB"]
                    .ToString();
            }
        }
    }
}
