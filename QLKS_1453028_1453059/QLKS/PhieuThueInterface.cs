﻿using System;
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
    public partial class PhieuThueInterface : Form
    {
        CTPhongThueCTL ctThueControl;
        public PhieuThueInterface()
        {
            InitializeComponent();
            
        }

        private void PhieuThueInterface_Load(object sender, EventArgs e)
        {
            string DBFullPathName = Application.StartupPath + "\\QLKS.mdb";
            DataProvider.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFullPathName;

            ctThueControl = new CTPhongThueCTL();
            DataTable phongThueTable = ctThueControl.getTableCTPhongThue();
            dataGridViewPhieuThue.DataSource = phongThueTable;
            btnThemDV.Enabled = false;
            btnXuatHoaDon.Enabled = false;
            if (phongThueTable.Rows.Count > 0)
            {
                if (dataGridViewPhieuThue.CurrentRow.Cells["DaXuatHoaDon"].Value.ToString() == "True")
                {
                    btnThemDV.Enabled = false;
                    btnXuatHoaDon.Enabled = false;
                }
                else
                {
                    btnThemDV.Enabled = true;
                    btnXuatHoaDon.Enabled = true;
                }
            }
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text == "")
            {
                txtTuKhoa.Select();
                MessageBox.Show("Xin hãy nhập từ khóa", "Thông báo");
                return;
            }
            dataGridViewPhieuThue.DataSource =  ctThueControl.searchTenOrCMND(txtTuKhoa.Text);
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            dataGridViewPhieuThue.DataSource = ctThueControl.getTableCTPhongThue();
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            string maThue = dataGridViewPhieuThue.CurrentRow.Cells["MaThue"].Value.ToString();
            ThemDichVuInterface themDVInterface = new ThemDichVuInterface(maThue);
            themDVInterface.ShowDialog();
        }

        private void dataGridViewPhieuThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPhieuThue.CurrentRow.Cells["DaXuatHoaDon"].Value.ToString() == "True")
            {
                btnThemDV.Enabled = false;
                btnXuatHoaDon.Enabled = false;
            }else
            {
                btnThemDV.Enabled = true;
                btnXuatHoaDon.Enabled = true;
            }
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
