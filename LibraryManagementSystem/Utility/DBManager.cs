using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Utility
{
    /// <summary>
    ///  Initalises and creates a mysql database connection.
    /// </summary>
    class DBManager
    {
        private string Server = "localhost";
        private string Database = "lms_sql";
        private string Username = "root";
        private string Password = "root";


        /// <summary>
        /// opens connections
        /// </summary>
        public MySqlConnection Conn;

        /// <summary>
        /// The command to build queries
        /// </summary>
        public MySqlCommand cmd;

        /// <summary>
        /// The reader for queries
        /// </summary>
        public MySqlDataReader reader;

        /// <summary>
        /// Initializes a new instance of the <see cref="DBManager"/> class.
        /// </summary>
        public DBManager()
        {
            InitConnection();
        }


        /// <summary>
        /// Initializes the connection.
        /// </summary>
        public void InitConnection()
        {
            Conn = new MySqlConnection($"SERVER={Server}; DATABASE={Database}; UID={Username}; PASSWORD={Password};");
        }

    }
}
