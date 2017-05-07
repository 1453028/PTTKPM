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
    class CTDKDichVuDAO
    {
        private DataProvider provider = new DataProvider();

        public CTDKDichVuDAO()
        {
            provider.connect();
        }

        public DataTable getTableCTDV()
        {
            string sqlString = "SELECT * FROM ChiTietDKDichVu";
            return provider.executeQueryToTable(sqlString);
        }

        public ArrayList getDsCTDV()
        {
            string query = "SELECT * FROM ChiTietDKDichVu";
            OleDbDataReader reader = (OleDbDataReader)provider.executeQuery(query);

            ArrayList arr = new ArrayList();
            CTDKDichVuDTO CTDV;
            while (reader.Read())
            {
                CTDV = new CTDKDichVuDTO();

                CTDV.MaThue = reader["MaThue"].ToString();
                CTDV.TenDV = reader["TenDichVu"].ToString();
                CTDV.SoLuong = int.Parse(reader["SoLuong"].ToString());
                CTDV.ThoiGianDK = DateTime.Parse(reader["ThoiGianDK"].ToString());
                
                arr.Add(CTDV);
            }

            reader.Close();
            return arr;
        }

        public void insert(CTDKDichVuDTO info)
        {
            string insertCommand = "INSERT INTO ChiTietDKDichVu (MaThue, TenDichVu, SoLuong, ThoiGianDK) VALUES('" +
                info.MaThue + "', '" +
                info.TenDV + "', '" +
                info.SoLuong + "', '" +
                info.ThoiGianDK + "')";

            provider.executeNonQuery(insertCommand);
        }

        public void update(CTDKDichVuDTO info)
        {
            string updateCommand = "UPDATE ChiTietDKDichVu (MaThue, TenDichVu, SoLuong, ThoiGianDK) " +
                                    "SET MaThue = '" + info.MaThue + "', " +
                                    " TenDichVu = '" + info.TenDV + "', " +
                                    " SoLuong = '" + info.SoLuong + "', " +
                                    " ThoiGianDK = '" + info.ThoiGianDK + "'";

            provider.executeNonQuery(updateCommand);
        }

        public DataTable search(string str)
        {
            string sqlString = "SELECT * FROM ChiTietDKDichVu WHERE MaThue LIKE '%" + str + "%' or TenDichVu LIKE '%" + str + "%'";
            return provider.executeQueryToTable(sqlString);
        }
    }
}
