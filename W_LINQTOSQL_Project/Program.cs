using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQTOSQL
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
            //Application.Run(new LinqToSQL_1());
            //Application.Run(new LinqToSQL_2());
            //Application.Run(new LinqToSQL_3());
            Application.Run(new LinqToSQL_4());
            }
        }
    }
