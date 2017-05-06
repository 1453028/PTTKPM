using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;

namespace QLKS
{
    class CTPhongThueCTL
    {
        private CTPhongThueDAO dataAccess = new CTPhongThueDAO();
        public DataTable getTableCTPhongThue()
        {
            return dataAccess.getTableCTPhongThue();
        }

        public DataTable searchDate(DateTime date)
        {
            return dataAccess.searchDate(date);
        }

        public DataTable searchTenOrCMND(string str)
        {
            return dataAccess.searchTenOrCMND(str);
        }

        public void insert(CTPhongThueDTO info)
        {
            dataAccess.insert(info);
        }

        public void update(CTPhongThueDTO info)
        {
            dataAccess.update(info);
        }
    }
}
