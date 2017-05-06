using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS
{
    public class LoaiPhongDTO
    {
        private string _TenLoai;
        private int _GiaCa;

        public string TenLoai
        {
            get { return _TenLoai; }
            set
            {
                if (value == null)
                    throw new Exception("Ten loai khong duoc rong");
                _TenLoai = value;
            }
        }

        public int GiaCa
        {
            get { return _GiaCa; }
            set { _GiaCa = value; }
        }
    }
}
