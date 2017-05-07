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

<<<<<<< HEAD
//            //DateTime dateToDisplay = DateTime.Today;
//            //string display = dateToDisplay.ToShortDateString();
//            //GlobalFunction.UpdateAppSetting("NgayThang", display);
//            //Application.Run(Global.LoaiPhongInterface);
//=======
//            Application.Run(new DangNhapInterface());

//            //GlobalFunction.UpdateAppSetting("QuyenHan", "NhanVien");

//            //DateTime dateToDisplay = DateTime.Today;
//            //string display = dateToDisplay.ToShortDateString();
//            //GlobalFunction.UpdateAppSetting("NgayThang", display);
//>>>>>>> 6557281d2abd2deec2b869016a6feabb29d35d92

            Application.Run(new PhongInterface());
=======
            Application.Run(new CTDKDV_Interface());
>>>>>>> 8f9629ae8ef332ef757d855467a26bcc7fed8994
        }

       
    }
}
