using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS
{
    public class PhongDTO
    {
        private string _MaPhong;
        private string _LoaiPhong;
        private string _TinhTrang;

        public string MaPhong
        {
            get { return _MaPhong; }
            set
            {
                if (value == null)
                    throw new Exception("Ma phong khong duoc rong");
                _MaPhong = value;
            }
        }

        public string LoaiPhong
        {
            get { return _LoaiPhong; }
            set { _LoaiPhong = value; }
        }

        public string TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }
    }
}
