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
    public partial class DangNhapInterface : Form
    {
        public const string Username = "admin";
        public const string Password = "AdminXXX";

        public DangNhapInterface()
        {
            InitializeComponent();
            string[] QuyenHan = new string[] { "Nhân viên", "Admin"};
            cmbQuyenHan.DataSource = QuyenHan;
            cmbQuyenHan.SelectedIndex = cmbQuyenHan.FindString("Nhân viên");
            txtTen.Enabled = false;
            txtMatKhau.Enabled = false;
            btnDangNhap.Enabled = true;

        }


        private void cmbQuyenHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = (string)cmbQuyenHan.SelectedItem;
            if (selectedType == "Nhân viên")
            {
                txtTen.Enabled = false;
                txtMatKhau.Enabled = false;
                btnDangNhap.Enabled = true;
            }
            else {
                txtTen.Enabled = true;
                txtMatKhau.Enabled = true;
                btnDangNhap.Enabled = false;
            }
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            if (checkEmpty() == false)
            {
                btnDangNhap.Enabled = false;
            }
            else
            {
                btnDangNhap.Enabled = true;
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (checkEmpty() == false)
            {
                btnDangNhap.Enabled = false;
            }
            else {
                btnDangNhap.Enabled = true;
            }
        }

        private void DangNhapInterface_Load(object sender, EventArgs e)
        {

        }

        private bool checkEmpty()
        {
            if (txtTen.Text == "")
            {
                return false;
            }
            else if (txtMatKhau.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string selectedType = (string)cmbQuyenHan.SelectedItem;
            if (selectedType == "Nhân viên")
            {
                var frm = new PhongInterface();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide();

                //GlobalFunction.UpdateAppSetting("QuyenHan", "NhanVien");
            }
            else
            {
                if (Username == txtTen.Text)
                {
                    if (Password == txtMatKhau.Text)
                    {
                        var frm = new PhongInterface();
                        frm.Location = this.Location;
                        frm.StartPosition = FormStartPosition.Manual;
                        frm.FormClosing += delegate { this.Show(); };
                        frm.Show();
                        this.Hide();

                        //GlobalFunction.UpdateAppSetting("QuyenHan", "Admin");
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập!", "Thông báo");
                }
            }
        }

        
    }
}
