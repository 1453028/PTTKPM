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
        public CTThue_Interface()
        {
            InitializeComponent();
        }

        public CTThue_Interface(PhongDTO phong)
        {
            this.phong = phong;
            InitializeComponent();
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
            //khachHang
        }

       


    }
}
