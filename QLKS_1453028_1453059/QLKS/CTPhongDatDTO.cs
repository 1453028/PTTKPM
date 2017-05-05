using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS
{
    public class CTPhongDatDTO
    {
        private string _MaPhongDat;
        private string _HoTen;
        private string _CMND;
        private DateTime _NgayNhanDK;
        private DateTime _GioNhanDK;
        private DateTime _NgayTraDK;
        private DateTime _GioTraDK;
        private DateTime _NgayDat;


        public string MaPhongDat
        {
            get { return _MaPhongDat; }
            set
            {
                if (value == null)
                    throw new Exception("Ma phong dat khong duoc rong");
                _MaPhongDat = value;
            }
        }
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


        public DateTime NgayNhanDK
        {
            get { return _NgayNhanDK; }
            set { _NgayNhanDK = value; }
        }

        public DateTime GioNhanDK
        {
            get { return _GioNhanDK; }
            set { _GioNhanDK = value; }
        }
        public DateTime NgayTraDK
        {
            get { return _NgayTraDK; }
            set { _NgayTraDK = value; }
        }
        public DateTime GioTraDK
        {
            get { return _GioTraDK; }
            set { _GioTraDK = value; }
        }

        public DateTime NgayDat
        {
            get { return _NgayDat; }
            set {
                if (value == null)
                    throw new Exception("Ngay dat khong duoc rong");
                _NgayDat = value;
            }
        }

    }
}
