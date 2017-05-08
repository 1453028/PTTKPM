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
    public partial class LoaiPhongInterface : Form
    {
        LoaiPhongCTL loaiPhongControl;
        public LoaiPhongInterface()
        {
            InitializeComponent();
        }

        private void LoaiPhongInterface_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            string DBFullPathName = Application.StartupPath + "\\QLKS.mdb";
            DataProvider.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFullPathName;

            loaiPhongControl = new LoaiPhongCTL();

            dataGridViewLoaiPhong.DataSource = loaiPhongControl.getTableLoaiPhong();
            // panelCapNhat.Enabled = false;
            //btnCapNhat.Enabled = true;
            disableCapNhapPanel();
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            // ktra du lieu nhap co hop le
            if (isValidThemPanel() == false) { return; }
            LoaiPhongDTO loaiPhong = new LoaiPhongDTO();
            layThongTinThem(ref loaiPhong);
            loaiPhongControl.insert(loaiPhong);
            dataGridViewLoaiPhong.DataSource = loaiPhongControl.getTableLoaiPhong();
        }

        private void txtGiaCaThem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void disableCapNhapPanel()
        {
            foreach (Control ctrl in panelCapNhat.Controls)
            {
                ctrl.Enabled = false;
            }
            btnCapNhat.Enabled = true;
        }
        private void enableCapNhapPanel()
        {
            foreach (Control ctrl in panelCapNhat.Controls)
            {
                ctrl.Enabled = true;
            }
            btnCapNhat.Enabled = false;
        }


        private bool isEmptyCapNhatPanel()
        {
            if (txtTenLoaiCapNhat.Text == "")
            {
                txtTenLoaiCapNhat.Select();
                return true;
            }
            else if (txtGiaCaCapNhat.Text == "")
            {
                txtGiaCaCapNhat.Select();
                return true;
            }

            return false;
        }
        private bool isValidThemPanel()
        {
            if (txtTenLoaiThem.Text == "")
            {
                txtTenLoaiThem.Select();
                return false;
            }
            else if (loaiPhongControl.isExist(txtTenLoaiThem.Text) == true)
            {
                MessageBox.Show("Loại phòng này đã tồn tại", "Thông báo");
                txtTenLoaiThem.Select();
                return false;
            }
            else if (txtGiaCaThem.Text == "")
            {
                txtGiaCaThem.Select();
                return false;
            }
            return true;
        }

        private void layThongTinCapNhat(ref LoaiPhongDTO loaiPhong)
        {
            loaiPhong.TenLoai = txtTenLoaiCapNhat.Text;
            loaiPhong.GiaCa = int.Parse(txtGiaCaCapNhat.Text);
        }
        private void layThongTinThem(ref LoaiPhongDTO loaiPhong)
        {
            loaiPhong.TenLoai = txtTenLoaiThem.Text;
            loaiPhong.GiaCa = int.Parse(txtGiaCaThem.Text);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = dataGridViewLoaiPhong.SelectedRows.Count;
            if (selectedRowsCount == 1)
            {
                enableCapNhapPanel();
                txtTenLoaiCapNhat.Text = dataGridViewLoaiPhong.SelectedRows[0].Cells["TenLoai"].Value.ToString();
                txtGiaCaCapNhat.Text = dataGridViewLoaiPhong.SelectedRows[0].Cells["GiaCa"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Xin chỉ chọn 1 dòng");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtGiaCaCapNhat.Text = "";
            txtTenLoaiCapNhat.Text = "";
            disableCapNhapPanel();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // ktra du lieu cap nhat co trong
           if (isEmptyCapNhatPanel() == true){ return; }


            LoaiPhongDTO loaiPhong = new LoaiPhongDTO();
            layThongTinCapNhat(ref loaiPhong);
            loaiPhongControl.updateGia(loaiPhong);
            txtGiaCaCapNhat.Text = "";
            txtTenLoaiCapNhat.Text = "";
            disableCapNhapPanel();
            dataGridViewLoaiPhong.DataSource = loaiPhongControl.getTableLoaiPhong();
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


        private void rbtnPhieuDat_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new PhieuDatInterface();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
