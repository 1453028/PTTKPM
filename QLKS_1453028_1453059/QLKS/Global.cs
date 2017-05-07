using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLKS
{
    static class Global
    {
        private static bool isAdmin = false;
        //private static Form loaiPhongInterface = new LoaiPhongInterface();
        //private static Form phongInterface = new PhongInterface();
        public static bool IsAdmin
        {
            get
            {
                return isAdmin;
            }

            set
            {
                isAdmin = value;
            }
        }

        //public static Form LoaiPhongInterface
        //{
        //    get
        //    {
        //        return loaiPhongInterface;
        //    }

        //    set
        //    {
        //        loaiPhongInterface = value;
        //    }
        //}

        //public static Form PhongInterface
        //{
        //    get
        //    {
        //        return phongInterface;
        //    }

        //    set
        //    {
        //        phongInterface = value;
        //    }
        //}
    }
}
