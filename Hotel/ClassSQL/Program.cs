using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
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
            //Application.Run(new QLForm());
            Application.Run(new LoginForm());
           //Autofill at = new Autofill();
            //MessageBox.Show(at.addl());
            // at.ThemKhachHang();
            //at.AutoBill();
           // Application.Run(new Setting(2));
        }
    }
}
