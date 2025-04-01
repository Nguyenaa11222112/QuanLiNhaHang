using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class Connect
    {
        public static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["string"] + "");
        public static void openConnect()
        {
            try
            {
                connect.Open();
            }
            catch (Exception ex) { }
        }
        public static void closeConnect()
        {
            try
            {
                connect.Close();
            }
            catch (Exception ex) { }
        }
    }
}
