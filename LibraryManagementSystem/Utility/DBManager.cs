using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Utility
{
    class DBManager
    {
        private string Server = "localhost";
        private string Database = "newlibrarydb";
        private string Username ="root";
        private string Password = "root";

        public MySqlConnection Conn;
        public MySqlCommand cmd;
        public MySqlDataReader reader;
        
        public DBManager()
        {
            InitConnection();
        }

        public void InitConnection()
        {
            Conn = new MySqlConnection($"SERVER={Server}; DATABASE={Database}; UID={Username}; PASSWORD={Password};");
        }
        
    }
}
