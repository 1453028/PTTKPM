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
    class LoadDichVuDAO
    {
        private DataProvider provider = new DataProvider();

        public LoadDichVuDAO()
        {
            provider.connect();
        }


        public DataTable getTableLoaiDV()
        {
            string sqlString = "SELECT * FROM LoaiDichVu";
            return provider.executeQueryToTable(sqlString);
        }

        public ArrayList getDsLoaiDV()
        {
            string query = "SELECT * FROM LoaiDichVu";
            OleDbDataReader reader = (OleDbDataReader)provider.executeQuery(query);

            ArrayList arr = new ArrayList();
            LoaiDichVuDTO loaiDV;
            while (reader.Read())
            {
                loaiDV = new LoaiDichVuDTO();

                loaiDV.TenDV = reader["TenDichVu"].ToString();
                loaiDV.GiaCa = int.Parse(reader["GiaCa"].ToString());
                loaiDV.TinhTrang = reader["TinhTrang"].ToString();
                loaiDV.SoLuong = int.Parse(reader["SoLuong"].ToString());

                arr.Add(loaiDV);
            }

            reader.Close();
            return arr;
        }

        public void insert(LoaiDichVuDTO info)
        {
            string insertCommand = "INSERT INTO LoaiDichVu (TenDichVu, GiaCa, TinhTrang, SoLuong) VALUES('" +
                info.TenDV + "', '" +
                info.GiaCa + "', '" +
                info.TinhTrang + "', '" +
                info.SoLuong + "')";

            provider.executeNonQuery(insertCommand);
        }

        public void update(LoaiDichVuDTO info)
        {
            string updateCommand = "UPDATE LoaiDichVu (TenDichVu, GiaCa, TinhTrang, SoLuong) " +
                                    " SET TenDichVu = '" + info.TenDV + "'," +
                                    "TenGiaCa = '" + info.GiaCa + "'," +
                                    "TinhTrang = '" + info.TinhTrang + "'," +
                                    "SoLuong = '" + info.SoLuong + "'";

            provider.executeNonQuery(updateCommand);
        }


        public bool isExist(string tenDV)
        {
            string sqlString = "SELECT * FROM LoaiDichVu WHERE TenDichVu = '" + tenDV + "'";
            return provider.executeQueryToTable(sqlString).Rows.Count == 0 ? false : true;
        }
    }
}
