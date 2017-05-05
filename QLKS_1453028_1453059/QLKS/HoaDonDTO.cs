using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS
{
    public class HoaDonDTO
    {
        private string _MaHD;
        private string _MaThue;
        private DateTime _NgayLap;

        public string MaHD
        {
            get { return _MaHD; }
            set
            {
                if (value == null)
                    throw new Exception("Ma hoa don khong duoc rong");
                _MaHD = value;
            }
        }

        public string MaThue
        {
            get { return _MaThue; }
            set { _MaThue = value; }
        }

        public DateTime NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
        }
    }
}
