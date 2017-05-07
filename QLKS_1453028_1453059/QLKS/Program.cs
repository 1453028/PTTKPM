using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace QLKS
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
            Application.Run(new DangNhapInterface());
            GlobalFunction.UpdateAppSetting("QuyenHan", "NhanVien");

            DateTime dateToDisplay = DateTime.Today;
            string display = dateToDisplay.ToShortDateString();
            GlobalFunction.UpdateAppSetting("NgayThang", display);

        }

       
    }
}
