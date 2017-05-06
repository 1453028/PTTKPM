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

        public PhongInterface()
        {
            InitializeComponent();

            string[] LoaiTimKiem = new string[] { "Mã phòng", "Loại phòng", "Tình trạng" };
            cmbSearchType.DataSource = LoaiTimKiem;
            cmbSearchType.SelectedIndex = cmbSearchType.FindString("Mã Phòng");
            labMaPhong.Visible = true;
            SearchMaPhong.Visible = true;

            cmbType.Visible = false;

            btnCapNhat.Visible = false;
            btnThemPhong.Visible = false;
        }

        private void PhongInterface_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            string DBFullPathName = Application.StartupPath + "\\QLKS.mdb";
            DataProvider.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFullPathName;

            PhongControl = new PhongCTL();
            LoaiPhongControl = new LoaiPhongCTL();

            dataGridView.DataSource = PhongControl.getTablePhong();
            
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
            dataGridView.DataSource = PhongControl.getTablePhong();
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
                dataGridView.DataSource = PhongControl.search(SearchMaPhong.Text);
            }
            else
            {
                string selected = cmbType.GetItemText(cmbType.SelectedItem);
                dataGridView.DataSource = PhongControl.search(selected);
            }
        }
    }
}
