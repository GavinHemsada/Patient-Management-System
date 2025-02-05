using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_clinic_Management_system
{
    class Connection
    {
        private MySqlConnection con = new MySqlConnection("server=localhost;database=clinic_management;username=root;password=gavin123");

        public void OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return con;
        }
    }
}
