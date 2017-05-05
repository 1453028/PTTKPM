using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS
{
    public class LoaiDichVuDTO
    {
        private string _TenDV;
        private string _GiaCa;
        private string _TinhTrang;
        private int _SoLuong;

        public string TenDV
        {
            get { return _TenDV; }
            set
            {
                if (value == null)
                    throw new Exception("Ten loai dich vu khong duoc rong");
                _TenDV = value;
            }
        }

        public string GiaCa
        {
            get { return _GiaCa; }
            set { _GiaCa = value; }
        }

        public string TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
    }
}
