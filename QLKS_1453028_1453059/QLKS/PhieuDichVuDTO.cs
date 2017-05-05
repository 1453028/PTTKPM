using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS
{
    public class PhieuDichVuDTO
    {
        private string _MaThue;
        CTDKDichVuDTO[] DanhSachDK;

        public string MaThue
        {
            get { return _MaThue; }
            set { _MaThue = value; }
        }
    }
}
