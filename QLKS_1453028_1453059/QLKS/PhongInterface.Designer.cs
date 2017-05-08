namespace QLKS
{
    partial class PhongInterface
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labNgayThang = new System.Windows.Forms.Label();
            this.labQuyen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.SearchMaPhong = new System.Windows.Forms.TextBox();
            this.labMaPhong = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLapPhieuThue = new System.Windows.Forms.Button();
            this.btn_LapPhieuDat = new System.Windows.Forms.Button();
            this.dataGridViewPhong = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnLoaiDichVu = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnLoaiPhong = new System.Windows.Forms.Button();
            this.btnPhieuThue = new System.Windows.Forms.Button();
            this.btnPhieuDat = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 0;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.btnThemPhong);
            this.panel4.Controls.Add(this.btnDanhSach);
            this.panel4.Controls.Add(this.btnTimKiem);
            this.panel4.Controls.Add(this.btnCapNhat);
            this.panel4.Controls.Add(this.SearchMaPhong);
            this.panel4.Controls.Add(this.labMaPhong);
            this.panel4.Controls.Add(this.cmbType);
            this.panel4.Controls.Add(this.cmbSearchType);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.btnLapPhieuThue);
            this.panel4.Controls.Add(this.btn_LapPhieuDat);
            this.panel4.Controls.Add(this.dataGridViewPhong);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1263, 604);
            this.panel4.TabIndex = 3;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Font = new System.Drawing.Font("Arial", 10F);
            this.btnThemPhong.Location = new System.Drawing.Point(37, 105);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(464, 52);
            this.btnThemPhong.TabIndex = 26;
            this.btnThemPhong.Text = "Thêm phòng";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Font = new System.Drawing.Font("Arial", 10F);
            this.btnDanhSach.Location = new System.Drawing.Point(784, 154);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(425, 52);
            this.btnDanhSach.TabIndex = 25;
            this.btnDanhSach.Text = "Hiện toàn bộ danh sách";
            this.btnDanhSach.UseVisualStyleBackColor = true;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Arial", 10F);
            this.btnTimKiem.Location = new System.Drawing.Point(1008, 96);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(201, 52);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCapNhat.Location = new System.Drawing.Point(37, 163);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(464, 52);
            this.btnCapNhat.TabIndex = 23;
            this.btnCapNhat.Text = "Cập nhật tình trạng phòng";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // SearchMaPhong
            // 
            this.SearchMaPhong.Font = new System.Drawing.Font("Arial", 10F);
            this.SearchMaPhong.Location = new System.Drawing.Point(784, 106);
            this.SearchMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.SearchMaPhong.Name = "SearchMaPhong";
            this.SearchMaPhong.Size = new System.Drawing.Size(200, 27);
            this.SearchMaPhong.TabIndex = 22;
            this.SearchMaPhong.TextChanged += new System.EventHandler(this.SearchMaPhong_TextChanged);
            // 
            // labMaPhong
            // 
            this.labMaPhong.AutoSize = true;
            this.labMaPhong.Font = new System.Drawing.Font("Arial", 10F);
            this.labMaPhong.Location = new System.Drawing.Point(664, 110);
            this.labMaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMaPhong.Name = "labMaPhong";
            this.labMaPhong.Size = new System.Drawing.Size(86, 19);
            this.labMaPhong.TabIndex = 21;
            this.labMaPhong.Text = "Mã phòng:";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(1008, 42);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 27);
            this.cmbType.TabIndex = 20;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchType.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Location = new System.Drawing.Point(784, 42);
            this.cmbSearchType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(200, 27);
            this.cmbSearchType.TabIndex = 19;
            this.cmbSearchType.SelectedIndexChanged += new System.EventHandler(this.cmbSearchType_SelectedIndexChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(663, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tra cứu:";
            // 
            // btnLapPhieuThue
            // 
            this.btnLapPhieuThue.Font = new System.Drawing.Font("Arial", 10F);
            this.btnLapPhieuThue.Location = new System.Drawing.Point(283, 42);
            this.btnLapPhieuThue.Name = "btnLapPhieuThue";
            this.btnLapPhieuThue.Size = new System.Drawing.Size(218, 52);
            this.btnLapPhieuThue.TabIndex = 7;
            this.btnLapPhieuThue.Text = "Thuê phòng";
            this.btnLapPhieuThue.UseVisualStyleBackColor = true;
            this.btnLapPhieuThue.Click += new System.EventHandler(this.btnLapPhieuThue_Click);
            // 
            // btn_LapPhieuDat
            // 
            this.btn_LapPhieuDat.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_LapPhieuDat.Location = new System.Drawing.Point(37, 42);
            this.btn_LapPhieuDat.Name = "btn_LapPhieuDat";
            this.btn_LapPhieuDat.Size = new System.Drawing.Size(228, 52);
            this.btn_LapPhieuDat.TabIndex = 6;
            this.btn_LapPhieuDat.Text = "Đặt phòng";
            this.btn_LapPhieuDat.UseVisualStyleBackColor = true;
            this.btn_LapPhieuDat.Click += new System.EventHandler(this.btn_LapPhieuDat_Click);
            // 
            // dataGridViewPhong
            // 
            this.dataGridViewPhong.AllowUserToAddRows = false;
            this.dataGridViewPhong.AllowUserToDeleteRows = false;
            this.dataGridViewPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewPhong.Location = new System.Drawing.Point(0, 248);
            this.dataGridViewPhong.Name = "dataGridViewPhong";
            this.dataGridViewPhong.ReadOnly = true;
            this.dataGridViewPhong.RowTemplate.Height = 24;
            this.dataGridViewPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPhong.Size = new System.Drawing.Size(1263, 356);
            this.dataGridViewPhong.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btnKhachHang);
            this.panel2.Controls.Add(this.btnHoaDon);
            this.panel2.Controls.Add(this.btnLoaiDichVu);
            this.panel2.Controls.Add(this.btnDichVu);
            this.panel2.Controls.Add(this.btnLoaiPhong);
            this.panel2.Controls.Add(this.btnPhieuThue);
            this.panel2.Controls.Add(this.btnPhieuDat);
            this.panel2.Controls.Add(this.btnPhong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1263, 112);
            this.panel2.TabIndex = 1;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.AutoSize = true;
            this.btnKhachHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKhachHang.Image = global::QLKS.Properties.Resources.woman;
            this.btnKhachHang.Location = new System.Drawing.Point(721, 0);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(103, 112);
            this.btnKhachHang.TabIndex = 23;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKhachHang.UseCompatibleTextRendering = true;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.AutoSize = true;
            this.btnHoaDon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHoaDon.Image = global::QLKS.Properties.Resources.money;
            this.btnHoaDon.Location = new System.Drawing.Point(618, 0);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(103, 112);
            this.btnHoaDon.TabIndex = 22;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHoaDon.UseCompatibleTextRendering = true;
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnLoaiDichVu
            // 
            this.btnLoaiDichVu.AutoSize = true;
            this.btnLoaiDichVu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoaiDichVu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoaiDichVu.Image = global::QLKS.Properties.Resources.wine_menu;
            this.btnLoaiDichVu.Location = new System.Drawing.Point(515, 0);
            this.btnLoaiDichVu.Name = "btnLoaiDichVu";
            this.btnLoaiDichVu.Size = new System.Drawing.Size(103, 112);
            this.btnLoaiDichVu.TabIndex = 21;
            this.btnLoaiDichVu.Text = "Loại dịch vụ";
            this.btnLoaiDichVu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoaiDichVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLoaiDichVu.UseCompatibleTextRendering = true;
            this.btnLoaiDichVu.UseVisualStyleBackColor = false;
            this.btnLoaiDichVu.Click += new System.EventHandler(this.btnLoaiDichVu_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.AutoSize = true;
            this.btnDichVu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDichVu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDichVu.Image = global::QLKS.Properties.Resources.wine_bottle;
            this.btnDichVu.Location = new System.Drawing.Point(412, 0);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(103, 112);
            this.btnDichVu.TabIndex = 20;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDichVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDichVu.UseCompatibleTextRendering = true;
            this.btnDichVu.UseVisualStyleBackColor = false;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnLoaiPhong
            // 
            this.btnLoaiPhong.AutoSize = true;
            this.btnLoaiPhong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoaiPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoaiPhong.Image = global::QLKS.Properties.Resources.sofa;
            this.btnLoaiPhong.Location = new System.Drawing.Point(309, 0);
            this.btnLoaiPhong.Name = "btnLoaiPhong";
            this.btnLoaiPhong.Size = new System.Drawing.Size(103, 112);
            this.btnLoaiPhong.TabIndex = 19;
            this.btnLoaiPhong.Text = "Loại phòng";
            this.btnLoaiPhong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoaiPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLoaiPhong.UseCompatibleTextRendering = true;
            this.btnLoaiPhong.UseVisualStyleBackColor = false;
            this.btnLoaiPhong.Click += new System.EventHandler(this.btnLoaiPhong_Click);
            // 
            // btnPhieuThue
            // 
            this.btnPhieuThue.AutoSize = true;
            this.btnPhieuThue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPhieuThue.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPhieuThue.Image = global::QLKS.Properties.Resources.mortgage;
            this.btnPhieuThue.Location = new System.Drawing.Point(206, 0);
            this.btnPhieuThue.Name = "btnPhieuThue";
            this.btnPhieuThue.Size = new System.Drawing.Size(103, 112);
            this.btnPhieuThue.TabIndex = 18;
            this.btnPhieuThue.Text = "Phiếu thuê";
            this.btnPhieuThue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhieuThue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPhieuThue.UseCompatibleTextRendering = true;
            this.btnPhieuThue.UseVisualStyleBackColor = false;
            this.btnPhieuThue.Click += new System.EventHandler(this.btnPhieuThue_Click);
            // 
            // btnPhieuDat
            // 
            this.btnPhieuDat.AutoSize = true;
            this.btnPhieuDat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPhieuDat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPhieuDat.Image = global::QLKS.Properties.Resources.notes;
            this.btnPhieuDat.Location = new System.Drawing.Point(103, 0);
            this.btnPhieuDat.Name = "btnPhieuDat";
            this.btnPhieuDat.Size = new System.Drawing.Size(103, 112);
            this.btnPhieuDat.TabIndex = 17;
            this.btnPhieuDat.Text = "Phiếu đặt";
            this.btnPhieuDat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhieuDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPhieuDat.UseCompatibleTextRendering = true;
            this.btnPhieuDat.UseVisualStyleBackColor = false;
            this.btnPhieuDat.Click += new System.EventHandler(this.btnPhieuDat_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.AutoSize = true;
            this.btnPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPhong.Image = global::QLKS.Properties.Resources.bed;
            this.btnPhong.Location = new System.Drawing.Point(0, 0);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(103, 112);
            this.btnPhong.TabIndex = 16;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPhong.UseCompatibleTextRendering = true;
            this.btnPhong.UseVisualStyleBackColor = false;
            // 
            // PhongInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 751);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PhongInterface";
            this.Text = "PhongInterface";
            this.Load += new System.EventHandler(this.PhongInterface_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labNgayThang;
        private System.Windows.Forms.Label labQuyen;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewPhong;
        private System.Windows.Forms.Button btnLapPhieuThue;
        private System.Windows.Forms.Button btn_LapPhieuDat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.TextBox SearchMaPhong;
        private System.Windows.Forms.Label labMaPhong;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnLoaiDichVu;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnLoaiPhong;
        private System.Windows.Forms.Button btnPhieuThue;
        private System.Windows.Forms.Button btnPhieuDat;
        private System.Windows.Forms.Button btnPhong;
    }
}