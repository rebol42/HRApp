using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HumanResourcesApp
{
    static class Program
    {
        public static string FilePath = Path.Combine(Environment.CurrentDirectory, "Employee.txt");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
      

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmHR());
        }
    }
}
