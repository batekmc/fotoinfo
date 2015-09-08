using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Security
{
    class Autentificate
    {
        private static String user;

        //String representing user
        public static String User { get { return user; } }


        /// <summary>
        /// Autentificate user via windows autentification
        /// </summary>
        /// <returns>True if autentificated.</returns>
        public static bool autentificate()
        {
            try
            {
                System.Data.SqlClient.SqlCommand sqlCommand = SmartISLib.Session.CreateCommand();
                sqlCommand.CommandText = "SELECT SYSTEM_USER";
                object obj = sqlCommand.ExecuteScalar();

                if (obj != null)
                {
                    user = Convert.ToString(obj);
                    return true;

                }
                return false;

            }
            catch (Exception e)
            {
                SmartISLib.Messages.Error(e.StackTrace);//TODO print user redable message
                return false;

            }
        }
    }
}
