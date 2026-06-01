using System;
using System.Windows.Forms;
using BibitKu.Views;

namespace BibitKu
{
    // ================================================================
    //  Entry Point aplikasi BibitKu
    // ================================================================
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Buka FormLogin sebagai halaman pertama
            Application.Run(new FormLogin());
        }
    }
}