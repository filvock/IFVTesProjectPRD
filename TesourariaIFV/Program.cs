using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace TesourariaIFV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            TesourariaIFV.Forms.LoginForm login = new TesourariaIFV.Forms.LoginForm();

            if (login.ShowDialog() == DialogResult.OK) 
            { 
                Application.Run(new TesourariaIFV.Forms.MainWindow());
            }
            
            

        }
    }
}
