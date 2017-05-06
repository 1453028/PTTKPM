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
    public partial class LoaiPhongInterface : Form
    {
        LoaiPhongCTL loaiPhongControl;
        public LoaiPhongInterface()
        {
            InitializeComponent();
        }

        private void LoaiPhongInterface_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            string DBFullPathName = Application.StartupPath + "\\QLKS.mdb";
            DataProvider.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFullPathName;

            loaiPhongControl = new LoaiPhongCTL();

            dataGridViewThem.DataSource = loaiPhongControl.getTableLoaiPhong();
            dataGridViewTraCuu.DataSource = loaiPhongControl.getTableLoaiPhong();
        }



        private void btnTim_Click(object sender, EventArgs e)
        {
            string tenLoai = txtTenLoaiTraCuu.Text;
            if (tenLoai == "") { return; }
    


        }


    }
}
