using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;

namespace QLKS
{
    class PhongCTL
    {
        private PhongDAO dataAccess = new PhongDAO();

        public ArrayList getDsPhong()
        {
            return dataAccess.getDsPhong();
        }

        public DataTable getTablePhong()
        {
            return dataAccess.getTablePhong();
        }

        public void insert(PhongDTO info)
        {
            dataAccess.insert(info);
        }


        public void update(PhongDTO info)
        {
            dataAccess.update(info);
        }

        public bool isExist(string MaPhong)
        {
            return dataAccess.isExist(MaPhong);
        }

        public DataTable search(string str)
        {
            return dataAccess.search(str);
        }
    }
}
