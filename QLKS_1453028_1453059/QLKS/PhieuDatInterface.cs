using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class PhieuDatInterface : Form
    {
        CTPhongDatCTL ctDatControl;
        public PhieuDatInterface()
        {
            InitializeComponent();
            string DBFullPathName = Application.StartupPath + "\\QLKS.mdb";
            DataProvider.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFullPathName;

            ctDatControl = new CTPhongDatCTL();
            DataTable phongDatTable = ctDatControl.getTableCTPhongDat();
            dataGridViewPhieuDat.DataSource = phongDatTable;           
        }

        private void rbtnPhong_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new PhongInterface();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void rbtnPhieuThue_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new PhieuThueInterface();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void rbtnLoaiPhong_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new LoaiPhongInterface();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void rbtnDichVu_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new CTDKDV_Interface();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void rbtnLoaiDV_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new LoaiDichVu_Interface();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void rbtnHoaDon_CheckedChanged(object sender, EventArgs e)
        {
            //this.Hide();
            //var form2 = new HoaDonInterface();
            //form2.Closed += (s, args) => this.Close();
            //form2.Show();
        }

        private void rbtnKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            //this.Hide();
            //var form2 = new KhachHangInterface();
            //form2.Closed += (s, args) => this.Close();
            //form2.Show();
        }
    }
}
