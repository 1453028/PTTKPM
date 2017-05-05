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
    public partial class ThemKhachHang : Form
    {
        KhachHangCTL khachHangControl;
        public ThemKhachHang()
        {
            InitializeComponent();
            string[] gioiTinh = new string[] { "Nam", "Nữ" };
            cmbGioiTinh.DataSource = gioiTinh;
            
        }
        private void ThemKhachHang_Load(object sender, EventArgs e)
        {
            string DBFullPathName = Application.StartupPath + "\\QLKS.mdb";
            DataProvider.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFullPathName;

            khachHangControl = new KhachHangCTL();

            dataGridViewKH.DataSource = khachHangControl.getTableKH();
        }
        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private bool checkEmpty()
        {
            if (txtHoTen.Text == "")
            {
                txtHoTen.Select();
                return false;
            }
            else if (txtCMND.Text == "")
            {
                txtCMND.Select();
                return false;
            }
            else if (txtDienThoai.Text == "")
            {
                txtDienThoai.Select();
                return false;
            }
            return true;
        }
        private void getDataFromForm (ref KhachHangDTO khachHang)
        {
            khachHang.HoTen = txtHoTen.Text;
            khachHang.CMND = txtCMND.Text;
            khachHang.GioiTinh = cmbGioiTinh.SelectedValue.ToString();
            khachHang.DienThoai = txtDienThoai.Text;
            khachHang.Email = txtEmail.Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHangDTO khachHang = new KhachHangDTO();
            if (checkEmpty() == false)
            {
                MessageBox.Show("Xin hãy điền đủ thông tin");
                return;
            }
            

            getDataFromForm(ref khachHang);

            if (khachHangControl.isExistCMND(khachHang.CMND)==true)// trùng khóa chính
            {
                MessageBox.Show("Đã có khách hàng có số CMND này", "Thông báo");
                txtCMND.Select();
                return;
            }
            khachHangControl.insert(khachHang);

            MessageBox.Show("Thêm dữ liệu thành công", "Thông báo");
            resetForm();
            dataGridViewKH.DataSource = khachHangControl.getTableKH();
            dataGridViewKH.CurrentCell = dataGridViewKH.Rows[dataGridViewKH.RowCount - 1].Cells[0];

        }
        private void resetForm()
        {
            txtHoTen.Text = "";
            txtCMND.Text = "";
            cmbGioiTinh.SelectedItem = "Nam";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            dataGridViewKH.DataSource = khachHangControl.getTableKH();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            KhachHangDTO khachHang = new KhachHangDTO();
            khachHang.HoTen = dataGridViewKH.CurrentRow.Cells["HoTen"].Value.ToString();
            khachHang.CMND = dataGridViewKH.CurrentRow.Cells["CMND"].Value.ToString();
            khachHang.GioiTinh = dataGridViewKH.CurrentRow.Cells["GioiTinh"].Value.ToString();
            khachHang.DienThoai = dataGridViewKH.CurrentRow.Cells["DienThoai"].Value.ToString();
            khachHang.Email = dataGridViewKH.CurrentRow.Cells["Email"].Value.ToString();
            MessageBox.Show("Da cHon");
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            dataGridViewKH.DataSource = khachHangControl.search(txtTraCuu.Text);
        }
    }
}
