using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.OleDb;

namespace QLKS
{
    class KhachHangCTL
    {
        private KhachHangDAO dataAccess = new KhachHangDAO();

        public ArrayList getDsKH()
        {
            return dataAccess.getDsKH();
        }

        public DataTable getTableKH()
        {
            return dataAccess.getTableKH();
        }

        public void insert(KhachHangDTO info)
        {
            dataAccess.insert(info);
        }


        public void update(KhachHangDTO info)
        {
            dataAccess.update(info);
        }

        public DataTable search(string str)
        {
            return dataAccess.search(str);
        }

        public bool isExistCMND(string cmnd)
        {
            return dataAccess.isExistCMND(cmnd);
        }
    }
}
