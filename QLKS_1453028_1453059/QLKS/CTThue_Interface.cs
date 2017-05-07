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
    public partial class CTThue_Interface: Form
    {
        PhongDTO phong;
        KhachHangDTO khachHang = null;
        CTPhongThueDAO ctPhongThueControl = new CTPhongThueDAO();
        public CTThue_Interface()
        {
            InitializeComponent();
            
        }

        private void CTThue_Interface_Load(object sender, EventArgs e)
        {
            dateTimePickerNgayTra.MinDate = DateTime.Today;
            //dateTimePickerGioTra.MinDate = DateTime.Parse(DateTime.Now.ToString("HH:mm:ss tt")); ;
            dateTimePickerGioTra.ShowUpDown = true;
        }

        public CTThue_Interface(PhongDTO phong)
        {
            LoaiPhongCTL loaiPhongControl = new LoaiPhongCTL();
            this.phong = phong;
            InitializeComponent();
            dateTimePickerGioTra.ShowUpDown = true;
            txtMaPhong.Text = phong.MaPhong;
            txtGiaCaTDT.Text = loaiPhongControl.getGia(phong.LoaiPhong).ToString();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            using (var form = new ThemKhachHang())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    khachHang = form.KhachHang;

                    this.txtHoTen.Text = khachHang.HoTen;
                    this.txtCMND.Text = khachHang.CMND.ToString();
                }
            }
        }

        private void btnLapPhieuThue_Click(object sender, EventArgs e)
        {
            if (khachHang == null)
            {
                MessageBox.Show("Xin hãy thêm khách hàng vào form", "Thông báo");
                return;
            }else if (txtTienDatCoc.Text == "")
            {
                txtTienDatCoc.Select();
                return;
            }else if (dateTimePickerNgayTra.Value.Date == DateTime.Today.Date && dateTimePickerGioTra.Value.TimeOfDay< DateTime.Now.TimeOfDay)// kiem tra thoi gian tra
            {
                MessageBox.Show("Thời điểm trả phòng phải sau thời điểm đặt phòng", "Thông báo");
                return;
            }

            CTPhongThueDTO ctThue = new CTPhongThueDTO();
            layThongTinPhieuThue(ref ctThue);
            ctPhongThueControl.insert(ctThue);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void layThongTinPhieuThue(ref CTPhongThueDTO ctThue)
        {
            ctThue.HoTen = txtHoTen.Text;
            ctThue.CMND = txtCMND.Text;
            ctThue.MaPhong = txtMaPhong.Text;
            ctThue.NgayNhan = DateTime.Today.Date;
            ctThue.GioNhan = DateTime.Now;
            ctThue.NgayTra = dateTimePickerNgayTra.Value;
            ctThue.GioTra = dateTimePickerGioTra.Value;
            ctThue.TienDatCoc = int.Parse(txtTienDatCoc.Text);
            ctThue.GiaCaTDT = int.Parse(txtGiaCaTDT.Text);
        }

        private void txtTienDatCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
