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
    public partial class LoaiDichVu_Interface : Form
    {
        LoaiDichVuCTL loaiDVControl;
        public LoaiDichVu_Interface()
        {
            InitializeComponent();
            string[] LoaiTinhTrang = new string[] { "Còn", "Hết", "Ngưng" };
            string[] LoaiTinhTrangCN = new string[] { "Còn", "Hết", "Ngưng" };
            cmbTinhTrang.DataSource = LoaiTinhTrang;
            cmbTinhTrangCapNhat.DataSource = LoaiTinhTrangCN;
        }

        private void LoaiDichVu_Interface_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            string DBFullPathName = Application.StartupPath + "\\QLKS.mdb";
            DataProvider.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFullPathName;

            loaiDVControl = new LoaiDichVuCTL();

            dataGridViewLoaiPhong.DataSource = loaiDVControl.getTableLoaiDV();
            // panelCapNhat.Enabled = false;
            //btnCapNhat.Enabled = true;
            disableCapNhapPanel();
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            // ktra du lieu nhap co hop le
            if (isValidThemPanel() == false) { return; }
            LoaiDichVuDTO loaiDV = new LoaiDichVuDTO();
            layThongTinThem(ref loaiDV);
            loaiDVControl.insert(loaiDV);
            dataGridViewLoaiPhong.DataSource = loaiDVControl.getTableLoaiDV();
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

        private void txtGiaCaThem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
            else if(txtSLCapNhat.Text == "")
            {
                txtSLCapNhat.Select();
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
            else if (loaiDVControl.isExist(txtTenLoaiThem.Text) == true)
            {
                MessageBox.Show("Loại dịch vụ này đã tồn tại", "Thông báo");
                txtTenLoaiThem.Select();
                return false;
            }
            else if (txtGiaCaThem.Text == "")
            {
                txtGiaCaThem.Select();
                return false;
            }
            else if (txtSLThem.Text == "")
            {
                txtSLThem.Select();
                return false;
            }
            return true;
        }

        private void layThongTinCapNhat(ref LoaiDichVuDTO loaiDV)
        {
            loaiDV.TenDV = txtTenLoaiCapNhat.Text;
            loaiDV.GiaCa = int.Parse(txtGiaCaCapNhat.Text);
            loaiDV.TinhTrang = (string)cmbTinhTrangCapNhat.SelectedItem;
            //loaiDV.SoLuong = int.Parse(txtSLCapNhat.Text);
        }
        private void layThongTinThem(ref LoaiDichVuDTO loaiDV)
        {
            loaiDV.TenDV = txtTenLoaiThem.Text;
            loaiDV.GiaCa = int.Parse(txtGiaCaThem.Text);
            loaiDV.TinhTrang = (string)cmbTinhTrang.SelectedItem;
            //loaiDV.SoLuong = int.Parse(txtSLThem.Text);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = dataGridViewLoaiPhong.SelectedRows.Count;
            if (selectedRowsCount == 1)
            {
                enableCapNhapPanel();
                txtTenLoaiCapNhat.Text = dataGridViewLoaiPhong.SelectedRows[0].Cells["TenDichVu"].Value.ToString();
                txtGiaCaCapNhat.Text = dataGridViewLoaiPhong.SelectedRows[0].Cells["GiaCa"].Value.ToString();
                cmbTinhTrangCapNhat.SelectedItem = dataGridViewLoaiPhong.SelectedRows[0].Cells["TinhTrang"].Value.ToString();
                txtSLCapNhat.Text = dataGridViewLoaiPhong.SelectedRows[0].Cells["SoLuong"].Value.ToString();
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

            txtSLCapNhat.Text = "";
            disableCapNhapPanel();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // ktra du lieu cap nhat co trong
            if (isEmptyCapNhatPanel() == true) { return; }


            LoaiDichVuDTO loaiDV = new LoaiDichVuDTO();
            layThongTinCapNhat(ref loaiDV);
            loaiDVControl.update(loaiDV);
            txtGiaCaCapNhat.Text = "";
            txtTenLoaiCapNhat.Text = "";

            txtSLCapNhat.Text = "";
            disableCapNhapPanel();
            dataGridViewLoaiPhong.DataSource = loaiDVControl.getTableLoaiDV();
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
