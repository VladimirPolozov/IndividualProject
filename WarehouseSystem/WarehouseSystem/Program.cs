using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WarehouseSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
