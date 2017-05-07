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
    class CTPhongDatDAO
    {

        private DataProvider provider = new DataProvider();

        public CTPhongDatDAO()
        {
            provider.connect();
        }

        public DataTable getTableCTPhongDat()
        {
            string sqlString = "SELECT * FROM ChiTietPhongDat";
            return provider.executeQueryToTable(sqlString);
        }

        public ArrayList getDsPhongDat()
        {
            string query = "SELECT * FROM ChiTietPhongDat";
            OleDbDataReader reader = (OleDbDataReader)provider.executeQuery(query);

            ArrayList arr = new ArrayList();
            CTPhongDatDTO PhongDat;
            while (reader.Read())
            {
                PhongDat = new CTPhongDatDTO();

                PhongDat.MaPhongDat = reader["MaPhongDat"].ToString();
                PhongDat.HoTen = reader["HoTen"].ToString();
                PhongDat.CMND = reader["CMND"].ToString();
                PhongDat.NgayNhanDK = DateTime.Parse(reader["NgayNhanPhongDK"].ToString());
                PhongDat.GioNhanDK = DateTime.Parse(reader["GioNhanPhongDK"].ToString());
                PhongDat.NgayTraDK = DateTime.Parse(reader["NgayTraPhongDK"].ToString());
                PhongDat.GioTraDK = DateTime.Parse(reader["GioTraPhongDK"].ToString());
                PhongDat.NgayDat = DateTime.Parse(reader["NgayDat"].ToString());
                PhongDat.TinhTrang = reader["TinhTrang"].ToString();
                
                arr.Add(PhongDat);
            }

            reader.Close();
            return arr;
        }

        public void insert(CTPhongDatDTO info)
        {
            string insertCommand = "INSERT INTO ChiTietPhongDat (MaPhongDat, HoTen, CMND, NgayNhanPhongDK, GioNhanPhongDK, NgayTraPhongDK, GioTraPhongDK, NgayDat, TinhTrang) VALUES('" +
                info.MaPhongDat + "', '" +
                info.HoTen + "', '" +
                info.CMND + "', '" +
                info.NgayNhanDK + "', '" +
                info.GioNhanDK + "', '" +
                info.NgayTraDK + "', '" +
                info.GioTraDK + "', '" +
                info.NgayDat + "', '" +
                info.TinhTrang + "')";

            provider.executeNonQuery(insertCommand);
        }

        public void update(CTPhongDatDTO info)
        {
            string updateCommand = "UPDATE ChiTietPhongDat (MaPhongDat, HoTen, CMND, NgayNhanPhongDK, GioNhanPhongDK, NgayTraPhongDK, GioTraPhongDK, NgayDat, TinhTrang) " +
                                    "SET MaPhongDat = '" + info.MaPhongDat + "', " +
                                    " HoTen = '" + info.HoTen + "', " +
                                    " CMND = '" + info.CMND + "', " +
                                    " NgayNhanPhongDK = " + info.NgayNhanDK + ", " +
                                    " GioNhanPhongDK = '" + info.GioNhanDK + "', " +
                                    " NgayTraPhongDK = '" + info.NgayTraDK + "', " +
                                    " GioTraPhongDK = '" + info.GioTraDK + "', " +
                                    " NgayDat = '" + info.NgayDat + "', " +
                                    " TinhTrang = '" + info.TinhTrang + "'";

            provider.executeNonQuery(updateCommand);
        }

        public DataTable search(string str)
        {
            string sqlString = "SELECT * FROM ChiTietPhongDat WHERE MaPhongDat LIKE '%" + str + "%' or TinhTrang LIKE '%" + str + "%' or CMND = '" + str + "'";
            return provider.executeQueryToTable(sqlString);
        }

        public bool isExist(string MaPhong, string CMND, DateTime Ngay)
        {
            string sqlString = "SELECT * FROM KhachHang WHERE MaPhongDat LIKE '%" + MaPhong + "%' and CMND = '" + CMND + "' and NgayDat LIKE '%" + Ngay + "%'";
            return provider.executeQueryToTable(sqlString).Rows.Count == 0 ? false : true;
        }
    }
}
