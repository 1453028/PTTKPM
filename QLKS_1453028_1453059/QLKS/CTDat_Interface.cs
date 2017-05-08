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
    public partial class CTDat_Interface : Form
    {
        PhongDTO phong;
        KhachHangDTO khachHang = null;
        CTPhongDatDAO ctPhongDatControl = new CTPhongDatDAO();
        public CTDat_Interface()
        {
            InitializeComponent();
        }
        public CTDat_Interface(PhongDTO phong)
        {
            LoaiPhongCTL loaiPhongControl = new LoaiPhongCTL();
            this.phong = phong;
            InitializeComponent();
            txtMaPhong.Text = phong.MaPhong;           
        }
        private void CTDat_Interface_Load(object sender, EventArgs e)
        {
            PickNgayNhan.MinDate = DateTime.Now;
            PickNgayTra.MinDate = DateTime.Now;
            //dateTimePickerGioTra.MinDate = DateTime.Parse(DateTime.Now.ToString("HH:mm:ss tt")); ;
            PickGioNhan.ShowUpDown = true;
            PickGioTra.ShowUpDown = true;
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

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (khachHang == null)
            {
                MessageBox.Show("Xin hãy thêm khách hàng vào form", "Thông báo");
                return;
            }
            else if (PickNgayTra.Value.Date == PickNgayNhan.Value.Date && PickGioTra.Value.TimeOfDay <= PickGioNhan.Value.AddHours(1).TimeOfDay)// kiem tra thoi gian tra
            {
                MessageBox.Show("Thời điểm trả phòng phải sau thời điểm đặt phòng", "Thông báo");
                return;
            }
            else if (PickNgayTra.Value.Date < PickNgayNhan.Value.Date)// kiem tra thoi gian tra
            {
                MessageBox.Show("Thời điểm trả phòng phải sau thời điểm đặt phòng ít nhất 1 tiếng", "Thông báo");
                return;
            }

            CTPhongDatDTO ctDat = new CTPhongDatDTO();
            layThongTinPhieuDat(ref ctDat);
            ctPhongDatControl.insert(ctDat);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void layThongTinPhieuDat(ref CTPhongDatDTO ctDat)
        {
            ctDat.HoTen = txtHoTen.Text;
            ctDat.CMND = txtCMND.Text;
            ctDat.MaPhongDat = txtMaPhong.Text;
            ctDat.NgayNhanDK = PickNgayNhan.Value;
            ctDat.GioNhanDK = PickGioNhan.Value;
            ctDat.NgayTraDK = PickNgayTra.Value;
            ctDat.GioTraDK = PickGioTra.Value;
            ctDat.NgayDat = DateTime.Now;
            ctDat.TinhTrang = "Chưa xử lí";
        }

    }
}
