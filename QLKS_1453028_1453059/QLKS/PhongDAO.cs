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
    class PhongDAO
    {
        private DataProvider provider = new DataProvider();

        public PhongDAO()
        {
            provider.connect();
        }


        public DataTable getTablePhong()
        {
            string sqlString = "SELECT * FROM Phong";
            return provider.executeQueryToTable(sqlString);
        }

        public ArrayList getDsPhong()
        {
            string query = "SELECT * FROM Phong";
            OleDbDataReader reader = (OleDbDataReader)provider.executeQuery(query);

            ArrayList arr = new ArrayList();
            PhongDTO Phong;
            while (reader.Read())
            {
                Phong = new PhongDTO();

                Phong.MaPhong = reader["MaPhong"].ToString();
                Phong.LoaiPhong = reader["LoaiPhong"].ToString();
                Phong.TinhTrang = reader["TinhTrang"].ToString();

                arr.Add(Phong);
            }

            reader.Close();
            return arr;
        }

        public void insert(PhongDTO info)
        {
            string insertCommand = "INSERT INTO Phong (MaPhong, LoaiPhong, TinhTrang) VALUES('" +
                info.MaPhong + "', '" +
                info.LoaiPhong + "', '" +
                info.TinhTrang + "')";

            provider.executeNonQuery(insertCommand);
        }

        public void update(PhongDTO info)
        {
            string updateCommand = "UPDATE Phong (MaPhong, LoaiPhong, TinhTrang) " +
                                    "SET TenLoai = '" + info.MaPhong + "'," +
                                    "TenLoai = '" + info.LoaiPhong + "'," +
                                    "GiaCa = '" + info.TinhTrang + "'";

            provider.executeNonQuery(updateCommand);
        }

        public DataTable search(string str)
        {
            string sqlString = "SELECT * FROM Phong WHERE MaPhong LIKE '%" + str + "%' or LoaiPhong LIKE '%" + str + "%' or TinhTrang LIKE '%" + str + "%'";
            return provider.executeQueryToTable(sqlString);
        }

        public bool isExist(string MaPhong)
        {
            string sqlString = "SELECT * FROM Phong WHERE MaPhong = '" + MaPhong + "'";
            return provider.executeQueryToTable(sqlString).Rows.Count == 0 ? false : true;
        }


    }
}
