using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tugas_1
{
    internal class DatabaseConnection
    {
        private readonly string connectionString = "Server=localhost;Port=3306;Database=Inventaris;Uid=root;Pwd=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

    }

}