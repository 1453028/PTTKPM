using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;

namespace QLKS
{
    class CTDKDichVuCTL
    {
        private CTDKDichVuDAO dataAccess = new CTDKDichVuDAO();

        public ArrayList getDsDV()
        {
            return dataAccess.getDsCTDV();
        }

        public DataTable getTableDV()
        {
            return dataAccess.getTableCTDV();
        }

        public void insert(CTDKDichVuDTO info)
        {
            dataAccess.insert(info);
        }


        public void update(CTDKDichVuDTO info)
        {
            dataAccess.update(info);
        }

        //public bool isExist(string MaPhong)
        //{
        //    return dataAccess.isExist(MaPhong);
        //}

        public DataTable search(string str)
        {
            return dataAccess.search(str);
        }
    }
}
