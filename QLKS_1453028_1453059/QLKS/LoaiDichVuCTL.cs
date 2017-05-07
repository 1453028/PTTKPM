using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;

namespace QLKS
{
    class LoaiDichVuCTL
    {
        private LoadDichVuDAO dataAccess = new LoadDichVuDAO();

        public ArrayList getDsLoaiDV()
        {
            return dataAccess.getDsLoaiDV();
        }

        public DataTable getTableLoaiDV()
        {
            return dataAccess.getTableLoaiDV();
        }

        public void insert(LoaiDichVuDTO info)
        {
            dataAccess.insert(info);
        }


        public void update(LoaiDichVuDTO info)
        {
            dataAccess.update(info);
        }
        //public void updateGia(LoaiDichVuDTO info)
        //{
        //    dataAccess.updateGia(info);
        //}

        public bool isExist(string tenDV)
        {
            return dataAccess.isExist(tenDV);
        }
    }
}
