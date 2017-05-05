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
    class KhachHangDAO
    {
        private DataProvider provider = new DataProvider();

        public KhachHangDAO()
        {
            provider.connect();
        }

        public DataTable getTableKH()
        {
            string sqlString = "SELECT * FROM KhachHang";
            return provider.executeQueryToTable(sqlString);
        }

        public ArrayList getDsKH()
        {
            string query = "SELECT * FROM KhachHang";
            OleDbDataReader reader = (OleDbDataReader)provider.executeQuery(query);

            ArrayList arr = new ArrayList();
            KhachHangDTO khachHang;
            while (reader.Read())
            {
                khachHang = new KhachHangDTO();

                khachHang.HoTen = reader["HoTen"].ToString();
                khachHang.CMND = reader["CMND"].ToString();
                khachHang.GioiTinh = reader["GioiTinh"].ToString();
                khachHang.DienThoai = reader["DienThoai"].ToString();
                khachHang.Email = reader["Email"].ToString();

                arr.Add(khachHang);
            }

            reader.Close();
            return arr;
        }

        public void insert(KhachHangDTO info)
        {

            string insertCommand = "INSERT INTO KhachHang (HoTen, CMND, GioiTinh, DienThoai, Email) VALUES('" +
                info.HoTen + "', '" +
                info.CMND + "', '" +
                info.GioiTinh + "', " +
                info.DienThoai + ", '" +
                info.Email + "')";

            provider.executeNonQuery(insertCommand);
        }

        public void update(KhachHangDTO info)
        {
            string updateCommand = "UPDATE KhachHang (HoTen, CMND, GioiTinh, DienThoai, Email) " +
                                    "SET HoTen = '" + info.HoTen + "', " +
                                    " CMND = '" + info.CMND + "', " +
                                    " GioiTinh = '" + info.GioiTinh + "', " +
                                    " DienThoai = " + info.DienThoai + ", " +
                                    " Email = '" + info.Email + "'";

            provider.executeNonQuery(updateCommand);
        }

        public DataTable search(string str)
        {
            string sqlString = "SELECT * FROM KhachHang WHERE HoTen LIKE '%"+ str + "%' or CMND = '" + str + "'";
            return provider.executeQueryToTable(sqlString);
        }

        public bool isExistCMND(string cmnd)
        {
            string sqlString = "SELECT * FROM KhachHang WHERE CMND = '" + cmnd + "'";
            return provider.executeQueryToTable(sqlString).Rows.Count==0?false:true;
        }

    }
}
