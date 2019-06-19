using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CustomerRecordsApp.UtilityClasses
{
    public abstract class ConnectionAccess
    {
        /// <summary>
        /// Gets connection strings
        /// </summary>
        /// 

        public string connString
        {
            get
            {
                return AzureString;
            }
        }

        protected string AzureString
        {
            get
            {
                return ConfigurationManager
                    .ConnectionStrings["AzureTestDB"]
                    .ToString();
            }
        }

        protected string AccessString
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
