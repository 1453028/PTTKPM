using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS
{
    public class CTDKDichVuDTO
    {
        private string _MaThue;
        private string _TenDV;
        private int _SoLuong;
        private DateTime _ThoiGianDK;

        public string MaThue
        {
            get { return _MaThue; }
            set { _MaThue = value; }
        }
        public string TenDV
        {
            get { return _TenDV; }
            set { _TenDV = value; }
        }
        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        public DateTime ThoiGianDK
        {
            get { return _ThoiGianDK; }
            set { _ThoiGianDK = value; }
        }
    }
}
