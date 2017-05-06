using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS
{
    public class CTPhongThueDTO
    {
        private string _MaThue;
        private string _HoTen;
        private string _CMND;
        private string _MaPhong;
        private DateTime _NgayNhan;
        private DateTime _GioNhan;
        private DateTime _NgayTra;
        private DateTime _GioTra;
        private int _TienDatCoc;
        private int _GiaCaTDT;

        public string MaThue
        {
            get { return _MaThue; }
            set
            {
                if (value == null)
                    throw new Exception("Ma thue khong duoc rong");
                _MaThue = value;
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
                _CMND = value;
            }
        }

        public string MaPhong
        {
            get { return _MaPhong; }
            set { _MaPhong = value; }
        }

        public DateTime NgayNhan
        {
            get { return _NgayNhan; }
            set { _NgayNhan = value; }
        }

        public DateTime GioNhan
        {
            get { return _GioNhan; }
            set { _GioNhan = value; }
        }
        public DateTime NgayTra
        {
            get { return _NgayTra; }
            set { _NgayTra = value; }
        }
        public DateTime GioTra
        {
            get { return _GioTra; }
            set { _GioTra = value; }
        }

        public int TienDatCoc
        {
            get { return _TienDatCoc; }
            set { _TienDatCoc = value; }
        }
        public int GiaCaTDT
        {
            get { return _GiaCaTDT; }
            set { _GiaCaTDT = value; }
        }
    }
}
