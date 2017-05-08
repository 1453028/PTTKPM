using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;
namespace QLKS
{
    class CTPhongThueDAO
    {
        private DataProvider provider = new DataProvider();

        public CTPhongThueDAO()
        {
            provider.connect();
        }


        public DataTable getTableCTPhongThue()
        {
            string sqlString = "SELECT * FROM ChiTietPhongThue";
            return provider.executeQueryToTable(sqlString);
        }

        public DataTable searchDate(DateTime date)
        {
            string sqlString = "SELECT * FROM ChiTietPhongThue WHERE NgayNhanPhong = '" + date + "'";
            return provider.executeQueryToTable(sqlString);
        }

        public DataTable searchTenOrCMND(string str)
        {
            string sqlString = "SELECT * FROM ChiTietPhongThue WHERE HoTen LIKE '%" + str + "%' or CMND = '" + str + "'";
            return provider.executeQueryToTable(sqlString);
        }

        //public ArrayList getDsCTPhongThue()
        //{
        //    string query = "SELECT * FROM ChiTietPhongThue";
        //    OleDbDataReader reader = (OleDbDataReader)provider.executeQuery(query);

        //    ArrayList arr = new ArrayList();
        //    CTPhongThueDTO ctPhongThue;
        //    while (reader.Read())
        //    {
        //        ctPhongThue = new CTPhongThueDTO();

        //        ctPhongThue.MaThue = reader["MaThue"].ToString();
        //        ctPhongThue.HoTen = reader["HoTen"].ToString();
        //        ctPhongThue.CMND = reader["CMND"].ToString();
        //        ctPhongThue.MaPhong = reader["MaPhong"].ToString();
        //        ctPhongThue.NgayNhan = reader["NgayNhanPhong"].ToString();
        //        ctPhongThue.GioNhan = reader["GioNhanPhong"].ToString();
        //        ctPhongThue.NgayTra = reader["NgayTraPhong"].ToString();
        //        ctPhongThue.GioTra = reader["GioTraPhong"].ToString();
        //        ctPhongThue.TienDatCoc = int.Parse(reader["TienDatCoc"].ToString());
        //        ctPhongThue.GiaCaTDT = int.Parse(reader["GiaCaTDT"].ToString());

        //        arr.Add(ctPhongThue);
        //    }

        //    reader.Close();
        //    return arr;
        //}

        public void insert(CTPhongThueDTO info)
        {
            info.MaThue = String.Format("{0:ddMM}", info.NgayNhan) + String.Format("{0:HHmmss}", info.GioNhan); ;
            //info.MaThue = "1";
            string insertCommand = "INSERT INTO ChiTietPhongThue (MaThue, HoTen, CMND, MaPhong, NgayNhanPhong, GioNhanPhong, NgayTraPhong, GioTraPhong, TienDatCoc, GiaCaTDT) VALUES('" +
                info.MaThue + "', '" +
                info.HoTen + "', '" +
                info.CMND + "', '" +
                info.MaPhong + "', '" +
                info.NgayNhan.ToShortDateString()+ "', '" +
                info.GioNhan.ToShortTimeString() + "', '" +
                info.NgayTra.ToShortDateString()+ "', '" +
                info.GioTra.ToShortTimeString() + "', '" +
                info.TienDatCoc + "', '" +
                info.GiaCaTDT + "')";
            
            provider.executeNonQuery(insertCommand);
            
        }

        public void update(CTPhongThueDTO info)
        {
            string updateCommand = "UPDATE ChiTietPhongThue (MaThue, HoTen, CMND, MaPhong, NgayNhanPhong, GioNhanPhong, NgayTraPhong, GioTraPhong, TienDatCoc, GiaCaTDT) " +
                                    "SET MaThue = '" + info.MaThue + "', " +
                                    " HoTen = '" + info.HoTen + "', " +
                                    " CMND = '" + info.CMND + "', " +
                                    " MaPhong = " + info.MaPhong + ", " +
                                    " NgayNhanPhong = " + info.NgayNhan.ToShortDateString() + ", " +
                                    " GioNhanPhong = " + info.GioNhan.ToShortTimeString() + ", " +
                                    " NgayTraPhong = " + info.NgayTra.ToShortDateString() + ", " +
                                    " GioTraPhong = " + info.GioTra.ToShortTimeString() + ", " +
                                    " TienDatCoc = " + info.TienDatCoc + ", " +
                                    " GiaCaTDT = '" + info.GiaCaTDT + "'";

            provider.executeNonQuery(updateCommand);
        }

        //public void delete(string id)
        //{
        //    string deleteCommand = "DELETE FROM ChiTietPhongThue WHERE MaThue = " + id;
        //    provider.executeNonQuery(deleteCommand);
        //}
    }

}
