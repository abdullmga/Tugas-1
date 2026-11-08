using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_1
{
    // Menjadi titik awal aplikasi Windows Forms.
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Mengaktifkan visual style Windows Forms sebelum membuka form awal.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Form SelamatDatang menjadi halaman pertama yang dilihat pengguna.
            Application.Run(new SelamatDatang());

        }
    }
}
