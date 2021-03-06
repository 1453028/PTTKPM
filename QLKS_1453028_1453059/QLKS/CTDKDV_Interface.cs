﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace QLKS
{
    public partial class CTDKDV_Interface : Form
    {
        CTDKDichVuCTL DVControl;
        LoaiDichVuCTL LoaiDVControl;
        public CTDKDV_Interface()
        {
            InitializeComponent();

            string[] LoaiTimKiem = new string[] { "Mã thuê", "Tên dịch vụ"};
            cmbSearchType.DataSource = LoaiTimKiem;
            cmbSearchType.SelectedIndex = cmbSearchType.FindString("Mã thuê");
            labMaThue.Visible = true;
            SearchMaThue.Visible = true;

            cmbType.Visible = false;

            btnCapNhat.Visible = false;
            btnXoa.Visible = false;
        }

        private void btn_ThemCT_Click(object sender, EventArgs e)
        {

        }

        private void btnLapPhieuThue_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void cmbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = (string)cmbSearchType.SelectedItem;
            if (selectedType == "Mã thuê")
            {
                labMaThue.Visible = true;
                SearchMaThue.Visible = true;
                cmbType.Visible = false;
            }
            else
            {
                if (selectedType == "Tên dịch vụ")
                {
                    labMaThue.Visible = false;
                    SearchMaThue.Visible = false;
                    cmbType.Visible = true;
                    ArrayList dsLoai = LoaiDVControl.getDsLoaiDV();

                    cmbType.DataSource = null;
                    cmbType.DataSource = dsLoai;
                    cmbType.DisplayMember = "TenDV";
                }
               
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchMaThue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string selectedType = (string)cmbSearchType.SelectedItem;

            if (selectedType == "Mã thuê")
            {
                dataGridView.DataSource = DVControl.search(SearchMaThue.Text);
            }
            else
            {
                string selected = cmbType.GetItemText(cmbType.SelectedItem);
                dataGridView.DataSource = DVControl.search(selected);
            }
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = DVControl.getTableDV();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CTDKDV_Interface_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            string DBFullPathName = Application.StartupPath + "\\QLKS.mdb";
            DataProvider.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFullPathName;

            DVControl = new CTDKDichVuCTL();
            LoaiDVControl = new LoaiDichVuCTL();

            dataGridView.DataSource = DVControl.getTableDV();
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
