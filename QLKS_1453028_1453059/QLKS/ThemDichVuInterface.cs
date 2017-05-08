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
    public partial class ThemDichVuInterface : Form
    {
        LoaiDichVuCTL loaiDVControl;
        CTDKDichVuCTL ctDichVuControl;
        public ThemDichVuInterface()
        {
            InitializeComponent();
        }

        public ThemDichVuInterface(string maThue)
        {
            InitializeComponent();
            txtMaPhieuThue.Text = maThue;
        }
        private void ThemDichVuInterface_Load(object sender, EventArgs e)
        {
            string DBFullPathName = Application.StartupPath + "\\QLKS.mdb";
            DataProvider.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFullPathName;

            loaiDVControl = new LoaiDichVuCTL();
            ctDichVuControl = new CTDKDichVuCTL();
            cmbType.DataSource = null;
            cmbType.DataSource = loaiDVControl.getDsLoaiDV();
            cmbType.DisplayMember = "TenDV";
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "")
            {
                txtSoLuong.Select();
                MessageBox.Show("Xin hãy nhập số lượng", "Thông báo");
                return;
            }
            CTDKDichVuDTO ctDichVu = new CTDKDichVuDTO();
            ctDichVu.MaThue = txtMaPhieuThue.Text;
            ctDichVu.SoLuong = int.Parse(txtSoLuong.Text);
            ctDichVu.TenDV = cmbType.Text;

            
            ctDichVu.ThoiGianDK = DateTime.Now;
            ctDichVuControl.insert(ctDichVu);
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
