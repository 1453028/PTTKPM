using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Collections;
using System.Data;

namespace QLKS
{
    class LoaiPhongCTL
    {
        private LoaiPhongDAO dataAccess = new LoaiPhongDAO();

        public ArrayList getDsLoaiPhong()
        {
            return dataAccess.getDsLoaiPhong();
        }

        public DataTable getTableLoaiPhong()
        {
            return dataAccess.getTableLoaiPhong();
        }

        public void insert(LoaiPhongDTO info)
        {
            dataAccess.insert(info);
        }


        public void update(LoaiPhongDTO info)
        {
           dataAccess.update(info);
        }

        public bool isExist(string tenLoai)
        {
            return dataAccess.isExist(tenLoai);
        }
    }
}
