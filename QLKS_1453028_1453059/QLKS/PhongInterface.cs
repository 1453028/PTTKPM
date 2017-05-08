using System;
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
    public partial class PhongInterface : Form
    {
        PhongCTL PhongControl;
        LoaiPhongCTL LoaiPhongControl;
        PhongDTO phong = null;

        public PhongInterface()
        {
            InitializeComponent();

            string[] LoaiTimKiem = new string[] { "Mã phòng", "Loại phòng", "Tình trạng" };
            cmbSearchType.DataSource = LoaiTimKiem;
            cmbSearchType.SelectedIndex = cmbSearchType.FindString("Mã phòng");
            labMaPhong.Visible = true;
            SearchMaPhong.Visible = true;

            cmbType.Visible = false;

            btnCapNhat.Visible = false;
            btnThemPhong.Visible = false;

            //if (GlobalFunction.ReadAppSetting("QuyenHan") == "NhanVien")
            //{
            //    labQuyen.Text = "Quyền hạn: Nhân viên";
            //}else
            //{
            //    if (GlobalFunction.ReadAppSetting("QuyenHan") == "NhanVien")
            //    {
            //        labQuyen.Text = "Quyền hạn: Admin";
            //    }
            //    else
            //    {
            //        labQuyen.Text = "Quyền hạn: Error AppSetting";
            //    }
            //}

            //labNgayThang.Text = GlobalFunction.ReadAppSetting("NgayThang");
        }

        private void PhongInterface_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            string DBFullPathName = Application.StartupPath + "\\QLKS.mdb";
            DataProvider.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFullPathName;

            PhongControl = new PhongCTL();
            LoaiPhongControl = new LoaiPhongCTL();

            dataGridViewPhong.DataSource = PhongControl.getTablePhong();
            
        }

        private void cmbSearchType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedType = (string)cmbSearchType.SelectedItem;
            if (selectedType == "Mã phòng")
            {
                labMaPhong.Visible = true;
                SearchMaPhong.Visible = true;
                cmbType.Visible = false;
            }
            else {
                if (selectedType == "Loại phòng")
                {
                    labMaPhong.Visible = false;
                    SearchMaPhong.Visible = false;
                    cmbType.Visible = true;
                    ArrayList dsLoai = LoaiPhongControl.getDsLoaiPhong();

                    cmbType.DataSource = null;
                    cmbType.DataSource = dsLoai;
                    cmbType.DisplayMember = "TenLoai";
                }
                else {
                    if (selectedType == "Tình trạng")
                    {
                        labMaPhong.Visible = false;
                        SearchMaPhong.Visible = false;
                        cmbType.Visible = true;

                        cmbType.DataSource = null;
                        string[] LoaiTinhTrang = new string[] { "Trống", "Thuê", "Đặt" };
                        cmbType.DataSource = LoaiTinhTrang;
                    }
                    
                }
            }
        }

        private void SearchMaPhong_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //nothing here now
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            dataGridViewPhong.DataSource = PhongControl.getTablePhong();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            string selectedType = (string)cmbSearchType.SelectedItem;
            if (selectedType != "Mã phòng" && selectedType != "Loại phòng" && selectedType != "Tình trạng")
            {
                MessageBox.Show("Hình thức tra cứu không hợp lệ", "Thông báo");

                cmbSearchType.SelectedIndex = cmbSearchType.FindString("Mã Phòng");
                labMaPhong.Visible = true;
                SearchMaPhong.Visible = true;
                cmbType.Visible = false;

            }
            if (selectedType == "Mã phòng")
            {
                dataGridViewPhong.DataSource = PhongControl.search(SearchMaPhong.Text);
            }
            else
            {
                string selected = cmbType.GetItemText(cmbType.SelectedItem);
                dataGridViewPhong.DataSource = PhongControl.search(selected);
            }
        }

        private void btn_LapPhieuDat_Click(object sender, EventArgs e)
        {
            layThongTinPhongChon();
            if (phong == null) { return; }
            using (var form = new CTDat_Interface(phong))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //phong.TinhTrang = "Đặt";
                    //dataGridViewPhong.DataSource = PhongControl.getTablePhong();
                }
            }
        }

        private void rbtnLoaiPhong_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new LoaiPhongInterface();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void btnLapPhieuThue_Click(object sender, EventArgs e)
        {
            layThongTinPhongChon();
            if (phong == null || phong.TinhTrang=="Đặt") { return; }
            using (var form = new CTThue_Interface(phong))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    phong.TinhTrang = "Đặt";
                    dataGridViewPhong.DataSource = PhongControl.getTablePhong();
                }
            }
            //CTThue_Interface ctthue = new CTThue_Interface();
            //ctthue.ShowDialog();

        }

        private PhongDTO layThongTinPhongChon()
        {
            phong = new PhongDTO();
            phong.MaPhong = dataGridViewPhong.CurrentRow.Cells["MaPhong"].Value.ToString();
            phong.LoaiPhong = dataGridViewPhong.CurrentRow.Cells["LoaiPhong"].Value.ToString();
            phong.TinhTrang = dataGridViewPhong.CurrentRow.Cells["TinhTrang"].Value.ToString();
            return phong;
        }
    }
}
