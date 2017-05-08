namespace QLKS
{
    partial class CTDKDV_Interface
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labMaThue = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.SearchMaThue = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btn_ThemCT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnLoaiDV = new System.Windows.Forms.RadioButton();
            this.rbtnLoaiPhong = new System.Windows.Forms.RadioButton();
            this.rbtnHoaDon = new System.Windows.Forms.RadioButton();
            this.rbtnKhachHang = new System.Windows.Forms.RadioButton();
            this.rbtnDichVu = new System.Windows.Forms.RadioButton();
            this.rbtnPhong = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 240);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1263, 363);
            this.dataGridView.TabIndex = 18;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labMaThue);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnDanhSach);
            this.panel3.Controls.Add(this.btnTimKiem);
            this.panel3.Controls.Add(this.SearchMaThue);
            this.panel3.Controls.Add(this.cmbType);
            this.panel3.Controls.Add(this.cmbSearchType);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btnCapNhat);
            this.panel3.Controls.Add(this.btn_ThemCT);
            this.panel3.Controls.Add(this.dataGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1263, 603);
            this.panel3.TabIndex = 9;
            // 
            // labMaThue
            // 
            this.labMaThue.AutoSize = true;
            this.labMaThue.Font = new System.Drawing.Font("Arial", 10F);
            this.labMaThue.Location = new System.Drawing.Point(581, 112);
            this.labMaThue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMaThue.Name = "labMaThue";
            this.labMaThue.Size = new System.Drawing.Size(72, 19);
            this.labMaThue.TabIndex = 35;
            this.labMaThue.Text = "Mã thuê:";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 10F);
            this.btnXoa.Location = new System.Drawing.Point(39, 97);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(464, 34);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Hủy chi tiết đăng kí dịch vụ";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Font = new System.Drawing.Font("Arial", 10F);
            this.btnDanhSach.Location = new System.Drawing.Point(701, 156);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(425, 36);
            this.btnDanhSach.TabIndex = 33;
            this.btnDanhSach.Text = "Hiện toàn bộ danh sách";
            this.btnDanhSach.UseVisualStyleBackColor = true;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Arial", 10F);
            this.btnTimKiem.Location = new System.Drawing.Point(925, 104);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(201, 38);
            this.btnTimKiem.TabIndex = 32;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // SearchMaThue
            // 
            this.SearchMaThue.Font = new System.Drawing.Font("Arial", 10F);
            this.SearchMaThue.Location = new System.Drawing.Point(701, 108);
            this.SearchMaThue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchMaThue.Name = "SearchMaThue";
            this.SearchMaThue.Size = new System.Drawing.Size(200, 27);
            this.SearchMaThue.TabIndex = 31;
            this.SearchMaThue.TextChanged += new System.EventHandler(this.SearchMaThue_TextChanged);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(925, 44);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 27);
            this.cmbType.TabIndex = 30;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchType.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Location = new System.Drawing.Point(701, 44);
            this.cmbSearchType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(200, 27);
            this.cmbSearchType.TabIndex = 29;
            this.cmbSearchType.SelectedIndexChanged += new System.EventHandler(this.cmbSearchType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(580, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 24);
            this.label10.TabIndex = 28;
            this.label10.Text = "Tra cứu:";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCapNhat.Location = new System.Drawing.Point(283, 40);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(220, 36);
            this.btnCapNhat.TabIndex = 27;
            this.btnCapNhat.Text = "Cập nhật chi tiết";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btn_ThemCT
            // 
            this.btn_ThemCT.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_ThemCT.Location = new System.Drawing.Point(39, 40);
            this.btn_ThemCT.Name = "btn_ThemCT";
            this.btn_ThemCT.Size = new System.Drawing.Size(220, 36);
            this.btn_ThemCT.TabIndex = 26;
            this.btn_ThemCT.Text = "Thêm chi tiết dịch vụ";
            this.btn_ThemCT.UseVisualStyleBackColor = true;
            this.btn_ThemCT.Click += new System.EventHandler(this.btn_ThemCT_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.rbtnLoaiDV);
            this.panel2.Controls.Add(this.rbtnLoaiPhong);
            this.panel2.Controls.Add(this.rbtnHoaDon);
            this.panel2.Controls.Add(this.rbtnKhachHang);
            this.panel2.Controls.Add(this.rbtnDichVu);
            this.panel2.Controls.Add(this.rbtnPhong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1263, 113);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 35);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1069, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "30/04/2017";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(796, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quyền hạn: Nhân viên";
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
            // rbtnLoaiDV
            // 
            this.rbtnLoaiDV.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rbtnLoaiDV.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnLoaiDV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnLoaiDV.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbtnLoaiDV.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnLoaiDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnLoaiDV.Image = global::QLKS.Properties.Resources.wine_bottle;
            this.rbtnLoaiDV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnLoaiDV.Location = new System.Drawing.Point(560, 0);
            this.rbtnLoaiDV.Name = "rbtnLoaiDV";
            this.rbtnLoaiDV.Size = new System.Drawing.Size(112, 113);
            this.rbtnLoaiDV.TabIndex = 5;
            this.rbtnLoaiDV.TabStop = true;
            this.rbtnLoaiDV.Text = "Loại dịch vụ";
            this.rbtnLoaiDV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnLoaiDV.UseMnemonic = false;
            this.rbtnLoaiDV.UseVisualStyleBackColor = false;
            // 
            // rbtnLoaiPhong
            // 
            this.rbtnLoaiPhong.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rbtnLoaiPhong.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnLoaiPhong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnLoaiPhong.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbtnLoaiPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnLoaiPhong.Image = global::QLKS.Properties.Resources.bed;
            this.rbtnLoaiPhong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnLoaiPhong.Location = new System.Drawing.Point(448, 0);
            this.rbtnLoaiPhong.Name = "rbtnLoaiPhong";
            this.rbtnLoaiPhong.Size = new System.Drawing.Size(112, 113);
            this.rbtnLoaiPhong.TabIndex = 4;
            this.rbtnLoaiPhong.TabStop = true;
            this.rbtnLoaiPhong.Text = "Loại phòng";
            this.rbtnLoaiPhong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnLoaiPhong.UseMnemonic = false;
            this.rbtnLoaiPhong.UseVisualStyleBackColor = false;
            // 
            // rbtnHoaDon
            // 
            this.rbtnHoaDon.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rbtnHoaDon.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnHoaDon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbtnHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnHoaDon.Image = global::QLKS.Properties.Resources.money;
            this.rbtnHoaDon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnHoaDon.Location = new System.Drawing.Point(336, 0);
            this.rbtnHoaDon.Name = "rbtnHoaDon";
            this.rbtnHoaDon.Size = new System.Drawing.Size(112, 113);
            this.rbtnHoaDon.TabIndex = 3;
            this.rbtnHoaDon.TabStop = true;
            this.rbtnHoaDon.Text = "Hóa đơn";
            this.rbtnHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnHoaDon.UseMnemonic = false;
            this.rbtnHoaDon.UseVisualStyleBackColor = false;
            // 
            // rbtnKhachHang
            // 
            this.rbtnKhachHang.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rbtnKhachHang.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnKhachHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnKhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbtnKhachHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnKhachHang.Image = global::QLKS.Properties.Resources.woman;
            this.rbtnKhachHang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnKhachHang.Location = new System.Drawing.Point(224, 0);
            this.rbtnKhachHang.Name = "rbtnKhachHang";
            this.rbtnKhachHang.Size = new System.Drawing.Size(112, 113);
            this.rbtnKhachHang.TabIndex = 2;
            this.rbtnKhachHang.TabStop = true;
            this.rbtnKhachHang.Text = "Khách hàng";
            this.rbtnKhachHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnKhachHang.UseMnemonic = false;
            this.rbtnKhachHang.UseVisualStyleBackColor = false;
            // 
            // rbtnDichVu
            // 
            this.rbtnDichVu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rbtnDichVu.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnDichVu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtnDichVu.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbtnDichVu.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnDichVu.Image = global::QLKS.Properties.Resources.wine_bottle;
            this.rbtnDichVu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnDichVu.Location = new System.Drawing.Point(112, 0);
            this.rbtnDichVu.Name = "rbtnDichVu";
            this.rbtnDichVu.Size = new System.Drawing.Size(112, 113);
            this.rbtnDichVu.TabIndex = 1;
            this.rbtnDichVu.TabStop = true;
            this.rbtnDichVu.Text = "Dịch vụ";
            this.rbtnDichVu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnDichVu.UseMnemonic = false;
            this.rbtnDichVu.UseVisualStyleBackColor = false;
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
            this.rbtnPhong.Size = new System.Drawing.Size(112, 113);
            this.rbtnPhong.TabIndex = 0;
            this.rbtnPhong.TabStop = true;
            this.rbtnPhong.Text = "Phòng";
            this.rbtnPhong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbtnPhong.UseMnemonic = false;
            this.rbtnPhong.UseVisualStyleBackColor = false;
            // 
            // CTDKDV_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 751);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CTDKDV_Interface";
            this.Text = "CTDKDV_Interface";
            this.Load += new System.EventHandler(this.CTDKDV_Interface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnLoaiPhong;
        private System.Windows.Forms.RadioButton rbtnHoaDon;
        private System.Windows.Forms.RadioButton rbtnKhachHang;
        private System.Windows.Forms.RadioButton rbtnDichVu;
        private System.Windows.Forms.RadioButton rbtnPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox SearchMaThue;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btn_ThemCT;
        private System.Windows.Forms.RadioButton rbtnLoaiDV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label labMaThue;
    }
}