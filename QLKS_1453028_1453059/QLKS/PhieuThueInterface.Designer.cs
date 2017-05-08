namespace QLKS
{
    partial class PhieuThueInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.dataGridViewPhieuThue = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelCapNhat = new System.Windows.Forms.Panel();
            this.btnHienTatCa = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labNgayThang = new System.Windows.Forms.Label();
            this.labQuyen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.rbtnLoaiDV = new System.Windows.Forms.RadioButton();
            this.rbtnPhieuThue = new System.Windows.Forms.RadioButton();
            this.rbtnPhieuDat = new System.Windows.Forms.RadioButton();
            this.rbtnLoaiPhong = new System.Windows.Forms.RadioButton();
            this.rbtnHoaDon = new System.Windows.Forms.RadioButton();
            this.rbtnKhachHang = new System.Windows.Forms.RadioButton();
            this.rbtnDichVu = new System.Windows.Forms.RadioButton();
            this.rbtnPhong = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuThue)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelCapNhat.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(381, 27);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(80, 27);
            this.btnTim.TabIndex = 19;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.Location = new System.Drawing.Point(774, 27);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(125, 27);
            this.btnXuatHoaDon.TabIndex = 18;
            this.btnXuatHoaDon.Text = "Xuất hóa đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = true;
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(101, 27);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(252, 22);
            this.txtTuKhoa.TabIndex = 14;
            // 
            // dataGridViewPhieuThue
            // 
            this.dataGridViewPhieuThue.AllowUserToAddRows = false;
            this.dataGridViewPhieuThue.AllowUserToDeleteRows = false;
            this.dataGridViewPhieuThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhieuThue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewPhieuThue.Location = new System.Drawing.Point(0, 79);
            this.dataGridViewPhieuThue.Name = "dataGridViewPhieuThue";
            this.dataGridViewPhieuThue.ReadOnly = true;
            this.dataGridViewPhieuThue.RowTemplate.Height = 24;
            this.dataGridViewPhieuThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPhieuThue.Size = new System.Drawing.Size(1263, 525);
            this.dataGridViewPhieuThue.TabIndex = 20;
            this.dataGridViewPhieuThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhieuThue_CellClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1263, 716);
            this.panel4.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelCapNhat);
            this.panel3.Controls.Add(this.dataGridViewPhieuThue);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1263, 604);
            this.panel3.TabIndex = 6;
            // 
            // panelCapNhat
            // 
            this.panelCapNhat.Controls.Add(this.btnThemDV);
            this.panelCapNhat.Controls.Add(this.btnHienTatCa);
            this.panelCapNhat.Controls.Add(this.btnTim);
            this.panelCapNhat.Controls.Add(this.btnXuatHoaDon);
            this.panelCapNhat.Controls.Add(this.label9);
            this.panelCapNhat.Controls.Add(this.txtTuKhoa);
            this.panelCapNhat.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCapNhat.Location = new System.Drawing.Point(0, 0);
            this.panelCapNhat.Name = "panelCapNhat";
            this.panelCapNhat.Size = new System.Drawing.Size(1263, 77);
            this.panelCapNhat.TabIndex = 22;
            this.panelCapNhat.TabStop = true;
            // 
            // btnHienTatCa
            // 
            this.btnHienTatCa.Location = new System.Drawing.Point(480, 27);
            this.btnHienTatCa.Name = "btnHienTatCa";
            this.btnHienTatCa.Size = new System.Drawing.Size(129, 27);
            this.btnHienTatCa.TabIndex = 20;
            this.btnHienTatCa.Text = "Hiện tất cả";
            this.btnHienTatCa.UseVisualStyleBackColor = true;
            this.btnHienTatCa.Click += new System.EventHandler(this.btnHienTatCa_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Từ khóa:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.rbtnLoaiDV);
            this.panel2.Controls.Add(this.rbtnPhieuThue);
            this.panel2.Controls.Add(this.rbtnPhieuDat);
            this.panel2.Controls.Add(this.rbtnLoaiPhong);
            this.panel2.Controls.Add(this.rbtnHoaDon);
            this.panel2.Controls.Add(this.rbtnKhachHang);
            this.panel2.Controls.Add(this.rbtnDichVu);
            this.panel2.Controls.Add(this.rbtnPhong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1263, 112);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.labNgayThang);
            this.panel1.Controls.Add(this.labQuyen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 35);
            this.panel1.TabIndex = 9;
            // 
            // labNgayThang
            // 
            this.labNgayThang.AutoSize = true;
            this.labNgayThang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labNgayThang.Location = new System.Drawing.Point(1069, 9);
            this.labNgayThang.Name = "labNgayThang";
            this.labNgayThang.Size = new System.Drawing.Size(80, 17);
            this.labNgayThang.TabIndex = 3;
            this.labNgayThang.Text = "30/04/2017";
            // 
            // labQuyen
            // 
            this.labQuyen.AutoSize = true;
            this.labQuyen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labQuyen.Location = new System.Drawing.Point(796, 9);
            this.labQuyen.Name = "labQuyen";
            this.labQuyen.Size = new System.Drawing.Size(150, 17);
            this.labQuyen.TabIndex = 2;
            this.labQuyen.Text = "Quyền hạn: Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1028, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách sạn ABC";
            // 
            // btnThemDV
            // 
            this.btnThemDV.Location = new System.Drawing.Point(628, 27);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(124, 27);
            this.btnThemDV.TabIndex = 21;
            this.btnThemDV.Text = "Thêm dịch vụ";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // rbtnLoaiDV
            // 
            this.rbtnLoaiDV.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rbtnLoaiDV.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnLoaiDV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnLoaiDV.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbtnLoaiDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnLoaiDV.Image = global::QLKS.Properties.Resources.wine_menu;
            this.rbtnLoaiDV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnLoaiDV.Location = new System.Drawing.Point(557, 0);
            this.rbtnLoaiDV.Name = "rbtnLoaiDV";
            this.rbtnLoaiDV.Size = new System.Drawing.Size(116, 112);
            this.rbtnLoaiDV.TabIndex = 23;
            this.rbtnLoaiDV.TabStop = true;
            this.rbtnLoaiDV.Text = "Loại dịch vụ";
            this.rbtnLoaiDV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnLoaiDV.UseMnemonic = false;
            this.rbtnLoaiDV.UseVisualStyleBackColor = false;
            this.rbtnLoaiDV.CheckedChanged += new System.EventHandler(this.rbtnLoaiDV_CheckedChanged);
            // 
            // rbtnPhieuThue
            // 
            this.rbtnPhieuThue.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rbtnPhieuThue.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnPhieuThue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtnPhieuThue.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbtnPhieuThue.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnPhieuThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnPhieuThue.Image = global::QLKS.Properties.Resources.mortgage;
            this.rbtnPhieuThue.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnPhieuThue.Location = new System.Drawing.Point(224, 0);
            this.rbtnPhieuThue.Name = "rbtnPhieuThue";
            this.rbtnPhieuThue.Size = new System.Drawing.Size(112, 112);
            this.rbtnPhieuThue.TabIndex = 22;
            this.rbtnPhieuThue.TabStop = true;
            this.rbtnPhieuThue.Text = "Phiếu thuê";
            this.rbtnPhieuThue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnPhieuThue.UseMnemonic = false;
            this.rbtnPhieuThue.UseVisualStyleBackColor = false;
            // 
            // rbtnPhieuDat
            // 
            this.rbtnPhieuDat.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rbtnPhieuDat.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnPhieuDat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnPhieuDat.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbtnPhieuDat.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnPhieuDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnPhieuDat.Image = global::QLKS.Properties.Resources.notes;
            this.rbtnPhieuDat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnPhieuDat.Location = new System.Drawing.Point(112, 0);
            this.rbtnPhieuDat.Name = "rbtnPhieuDat";
            this.rbtnPhieuDat.Size = new System.Drawing.Size(112, 112);
            this.rbtnPhieuDat.TabIndex = 21;
            this.rbtnPhieuDat.TabStop = true;
            this.rbtnPhieuDat.Text = "Phiếu đặt";
            this.rbtnPhieuDat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnPhieuDat.UseMnemonic = false;
            this.rbtnPhieuDat.UseVisualStyleBackColor = false;
            this.rbtnPhieuDat.CheckedChanged += new System.EventHandler(this.rbtnPhieuDat_CheckedChanged);
            // 
            // rbtnLoaiPhong
            // 
            this.rbtnLoaiPhong.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rbtnLoaiPhong.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnLoaiPhong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnLoaiPhong.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbtnLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnLoaiPhong.Image = global::QLKS.Properties.Resources.sofa;
            this.rbtnLoaiPhong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnLoaiPhong.Location = new System.Drawing.Point(333, 0);
            this.rbtnLoaiPhong.Name = "rbtnLoaiPhong";
            this.rbtnLoaiPhong.Size = new System.Drawing.Size(109, 112);
            this.rbtnLoaiPhong.TabIndex = 20;
            this.rbtnLoaiPhong.TabStop = true;
            this.rbtnLoaiPhong.Text = "Loại phòng";
            this.rbtnLoaiPhong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnLoaiPhong.UseMnemonic = false;
            this.rbtnLoaiPhong.UseVisualStyleBackColor = false;
            this.rbtnLoaiPhong.CheckedChanged += new System.EventHandler(this.rbtnLoaiPhong_CheckedChanged);
            // 
            // rbtnHoaDon
            // 
            this.rbtnHoaDon.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rbtnHoaDon.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnHoaDon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbtnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnHoaDon.Image = global::QLKS.Properties.Resources.money;
            this.rbtnHoaDon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnHoaDon.Location = new System.Drawing.Point(673, 0);
            this.rbtnHoaDon.Name = "rbtnHoaDon";
            this.rbtnHoaDon.Size = new System.Drawing.Size(121, 112);
            this.rbtnHoaDon.TabIndex = 19;
            this.rbtnHoaDon.TabStop = true;
            this.rbtnHoaDon.Text = "Hóa đơn";
            this.rbtnHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnHoaDon.UseMnemonic = false;
            this.rbtnHoaDon.UseVisualStyleBackColor = false;
            this.rbtnHoaDon.CheckedChanged += new System.EventHandler(this.rbtnHoaDon_CheckedChanged);
            // 
            // rbtnKhachHang
            // 
            this.rbtnKhachHang.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rbtnKhachHang.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnKhachHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnKhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbtnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnKhachHang.Image = global::QLKS.Properties.Resources.woman;
            this.rbtnKhachHang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnKhachHang.Location = new System.Drawing.Point(791, 0);
            this.rbtnKhachHang.Name = "rbtnKhachHang";
            this.rbtnKhachHang.Size = new System.Drawing.Size(118, 112);
            this.rbtnKhachHang.TabIndex = 18;
            this.rbtnKhachHang.TabStop = true;
            this.rbtnKhachHang.Text = "Khách hàng";
            this.rbtnKhachHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnKhachHang.UseMnemonic = false;
            this.rbtnKhachHang.UseVisualStyleBackColor = false;
            this.rbtnKhachHang.CheckedChanged += new System.EventHandler(this.rbtnKhachHang_CheckedChanged);
            // 
            // rbtnDichVu
            // 
            this.rbtnDichVu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rbtnDichVu.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnDichVu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnDichVu.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbtnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnDichVu.Image = global::QLKS.Properties.Resources.wine_bottle;
            this.rbtnDichVu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnDichVu.Location = new System.Drawing.Point(441, 0);
            this.rbtnDichVu.Name = "rbtnDichVu";
            this.rbtnDichVu.Size = new System.Drawing.Size(117, 112);
            this.rbtnDichVu.TabIndex = 17;
            this.rbtnDichVu.TabStop = true;
            this.rbtnDichVu.Text = "Dịch vụ";
            this.rbtnDichVu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnDichVu.UseMnemonic = false;
            this.rbtnDichVu.UseVisualStyleBackColor = false;
            this.rbtnDichVu.CheckedChanged += new System.EventHandler(this.rbtnDichVu_CheckedChanged);
            // 
            // rbtnPhong
            // 
            this.rbtnPhong.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rbtnPhong.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnPhong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnPhong.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbtnPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnPhong.Image = global::QLKS.Properties.Resources.bed;
            this.rbtnPhong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnPhong.Location = new System.Drawing.Point(0, 0);
            this.rbtnPhong.Name = "rbtnPhong";
            this.rbtnPhong.Size = new System.Drawing.Size(112, 112);
            this.rbtnPhong.TabIndex = 16;
            this.rbtnPhong.TabStop = true;
            this.rbtnPhong.Text = "Phòng";
            this.rbtnPhong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnPhong.UseMnemonic = false;
            this.rbtnPhong.UseVisualStyleBackColor = false;
            this.rbtnPhong.CheckedChanged += new System.EventHandler(this.rbtnPhong_CheckedChanged);
            // 
            // PhieuThueInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 751);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "PhieuThueInterface";
            this.Text = "PhieuThueInterface";
            this.Load += new System.EventHandler(this.PhieuThueInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuThue)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelCapNhat.ResumeLayout(false);
            this.panelCapNhat.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.DataGridView dataGridViewPhieuThue;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelCapNhat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labNgayThang;
        private System.Windows.Forms.Label labQuyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHienTatCa;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.RadioButton rbtnLoaiDV;
        private System.Windows.Forms.RadioButton rbtnPhieuThue;
        private System.Windows.Forms.RadioButton rbtnPhieuDat;
        private System.Windows.Forms.RadioButton rbtnLoaiPhong;
        private System.Windows.Forms.RadioButton rbtnHoaDon;
        private System.Windows.Forms.RadioButton rbtnKhachHang;
        private System.Windows.Forms.RadioButton rbtnDichVu;
        private System.Windows.Forms.RadioButton rbtnPhong;
    }
}