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
    class LoaiPhongDAO
    {
        private DataProvider provider = new DataProvider();

        public LoaiPhongDAO()
        {
            provider.connect();
        }


        public DataTable getTableLoaiPhong()
        {
            string sqlString = "SELECT * FROM LoaiPhong";
            return provider.executeQueryToTable(sqlString);
        }

        public ArrayList getDsLoaiPhong()
        {
            string query = "SELECT * FROM LoaiPhong";
            OleDbDataReader reader = (OleDbDataReader)provider.executeQuery(query);

            ArrayList arr = new ArrayList();
            LoaiPhongDTO loaiPhong;
            while (reader.Read())
            {
                loaiPhong = new LoaiPhongDTO();

                loaiPhong.TenLoai = reader["TenLoai"].ToString();
                loaiPhong.GiaCa = int.Parse(reader["GiaCa"].ToString());

                arr.Add(loaiPhong);
            }

            reader.Close();
            return arr;
        }

        public void insert(LoaiPhongDTO info)
        {
            string insertCommand = "INSERT INTO LoaiPhong (TenLoai, GiaCa) VALUES('" +
                info.TenLoai + "', '" +
                info.GiaCa + "')";

            provider.executeNonQuery(insertCommand);
        }

        public void update(LoaiPhongDTO info)
        {
            string updateCommand = "UPDATE LoaiPhong (TenLoai, GiaCa) " +
                                    " SET TenLoai = '" + info.TenLoai +  "',"+
                                    "GiaCa = '" + info.GiaCa + "'";

            provider.executeNonQuery(updateCommand);
        }

        public void updateGia(LoaiPhongDTO info)
        {
            string updateCommand = "UPDATE LoaiPhong" +
                                    " SET GiaCa = '" + info.GiaCa + "' WHERE TenLoai = '" + info.TenLoai + "'";

            provider.executeNonQuery(updateCommand);
        }

        public bool isExist(string tenLoai)
        {
            string sqlString = "SELECT * FROM LoaiPhong WHERE TenLoai = '" + tenLoai + "'";
            return provider.executeQueryToTable(sqlString).Rows.Count == 0 ? false : true;
        }

        public int getGia(string loaiPhong)
        {
            int gia = 0;
            string query = "SELECT * FROM LoaiPhong WHERE TenLoai = '" + loaiPhong + "'";
            OleDbDataReader reader = (OleDbDataReader)provider.executeQuery(query);
            while (reader.Read())
            {
                gia = int.Parse(reader["GiaCa"].ToString());
            }
            reader.Close();
            return gia;
        }
    }
}
