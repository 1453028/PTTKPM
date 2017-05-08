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
        private int _GiaCa;
        private string _TinhTrang;

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

        public int GiaCa
        {
            get { return _GiaCa; }
            set { _GiaCa = value; }
        }

        public string TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }

    }
}
