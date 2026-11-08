using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tugas_1
{
    // Menyimpan informasi user yang sedang login agar transaksi siswa dan pengurus terhubung.
    public static class AppSession
    {
        public static int CurrentUserId { get; set; }
        public static string CurrentUserName { get; set; }
        public static string CurrentUserRole { get; set; }

        public static void Clear()
        {
            CurrentUserId = 0;
            CurrentUserName = null;
            CurrentUserRole = null;
        }
    }

    // Menyediakan koneksi terpusat ke database inventaris MySQL.
    internal class DatabaseConnection
    {
        private readonly string connectionString = "Server=localhost;Port=3306;Database=Inventaris;Uid=root;Pwd=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

    }

}