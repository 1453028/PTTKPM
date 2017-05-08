using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
namespace QLKS
{
    class CTPhongDatCTL
    {
        private CTPhongDatDAO dataAccess = new CTPhongDatDAO();
        public DataTable getTableCTPhongDat()
        {
            return dataAccess.getTableCTPhongDat();
        }

        public ArrayList getDsPhongDat()
        {
            return dataAccess.getDsPhongDat();
        }

        public void insert(CTPhongDatDTO info)
        {
            dataAccess.insert(info);
        }

        public void update(CTPhongDatDTO info)
        {
            dataAccess.update(info);
        }

        public DataTable search(string str)
        {
            return dataAccess.search(str);
        }

        public bool isExist(string MaPhong, string CMND, DateTime Ngay)
        {
            return dataAccess.isExist(MaPhong, CMND, Ngay);
        }
    }
}
