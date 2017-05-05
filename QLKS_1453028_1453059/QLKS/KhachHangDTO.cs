using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS
{
    public class KhachHangDTO
    {
        private string _HoTen;
        private string _CMND;
        private string _GioiTinh;
        private string _DienThoai;
        private string _Email;

        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }

        public string CMND
        {
            get { return _CMND; }
            set
            {
                if (value == null)
                    throw new Exception("CMND khong duoc rong");
                _CMND = value;
            }
        }

        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }

        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }


    }
}
