using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pc_shop.Singleton
{
    internal class Connector
    {
        private string Servername = "DESKTOP-LNQF7KP";
        private string Username = "";
        private string Passwored = "";
        private string DataBase = "PCShopManagementSystem";
        private static SqlConnection _conn = new SqlConnection();
        private static Connector _connector = new Connector();

        private Connector()
        {

        }

        public static Connector GetConnector()
        {
            return _connector;
        }

        public SqlConnection Connection()
        {
            if (string.IsNullOrEmpty(Passwored) && string.IsNullOrEmpty(Username))
            {
                _conn.ConnectionString = $"server={Servername};database={DataBase};Integrated Security=True";
            }
            else
                _conn.ConnectionString = $"server={Servername};database={DataBase};uid={Username};password={Passwored}";
            return _conn ;
        }






    }
   
}

