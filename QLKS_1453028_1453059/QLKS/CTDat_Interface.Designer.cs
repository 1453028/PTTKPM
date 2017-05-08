namespace QLKS
{
    partial class CTDat_Interface
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
            this.label1 = new System.Windows.Forms.Label();
            this.PickNgayTra = new System.Windows.Forms.DateTimePicker();
            this.PickNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.PickGioNhan = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.PickGioTra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F);
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 39);
            this.label1.TabIndex = 46;
            this.label1.Text = "Lập phiếu đặt phòng";
            // 
            // PickNgayTra
            // 
            this.PickNgayTra.Font = new System.Drawing.Font("Arial", 10F);
            this.PickNgayTra.Location = new System.Drawing.Point(248, 282);
            this.PickNgayTra.Name = "PickNgayTra";
            this.PickNgayTra.Size = new System.Drawing.Size(291, 27);
            this.PickNgayTra.TabIndex = 40;
            // 
            // PickNgayNhan
            // 
            this.PickNgayNhan.Font = new System.Drawing.Font("Arial", 10F);
            this.PickNgayNhan.Location = new System.Drawing.Point(248, 196);
            this.PickNgayNhan.Name = "PickNgayNhan";
            this.PickNgayNhan.Size = new System.Drawing.Size(291, 27);
            this.PickNgayNhan.TabIndex = 39;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Font = new System.Drawing.Font("Arial", 10F);
            this.btnDatPhong.Location = new System.Drawing.Point(921, 359);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(187, 67);
            this.btnDatPhong.TabIndex = 36;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.Location = new System.Drawing.Point(24, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "Ngày trả phòng dự kiến:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.Location = new System.Drawing.Point(23, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "Ngày nhận phòng dự kiến:";
            // 
            // btnThemKH
            // 
            this.btnThemKH.Font = new System.Drawing.Font("Arial", 10F);
            this.btnThemKH.Location = new System.Drawing.Point(695, 359);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(188, 67);
            this.btnThemKH.TabIndex = 35;
            this.btnThemKH.Text = "Thêm khách hàng";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // PickGioNhan
            // 
            this.PickGioNhan.Font = new System.Drawing.Font("Arial", 10F);
            this.PickGioNhan.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.PickGioNhan.Location = new System.Drawing.Point(815, 202);
            this.PickGioNhan.Name = "PickGioNhan";
            this.PickGioNhan.Size = new System.Drawing.Size(293, 27);
            this.PickGioNhan.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(590, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "Giờ nhận phòng dự kiến:";
            // 
            // PickGioTra
            // 
            this.PickGioTra.Font = new System.Drawing.Font("Arial", 10F);
            this.PickGioTra.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.PickGioTra.Location = new System.Drawing.Point(815, 282);
            this.PickGioTra.Name = "PickGioTra";
            this.PickGioTra.Size = new System.Drawing.Size(293, 27);
            this.PickGioTra.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(590, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Giờ trả phòng dự kiến:";
            // 
            // txtCMND
            // 
            this.txtCMND.AutoSize = true;
            this.txtCMND.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCMND.Location = new System.Drawing.Point(529, 122);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(0, 19);
            this.txtCMND.TabIndex = 61;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.AutoSize = true;
            this.txtMaPhong.Font = new System.Drawing.Font("Arial", 10F);
            this.txtMaPhong.Location = new System.Drawing.Point(983, 122);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(0, 19);
            this.txtMaPhong.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F);
            this.label10.Location = new System.Drawing.Point(811, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 19);
            this.label10.TabIndex = 56;
            this.label10.Text = "Mã phòng dự kiến:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.Location = new System.Drawing.Point(442, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "CMND:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.Location = new System.Drawing.Point(24, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 54;
            this.label6.Text = "Họ tên KH:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.AutoSize = true;
            this.txtHoTen.Font = new System.Drawing.Font("Arial", 10F);
            this.txtHoTen.Location = new System.Drawing.Point(140, 122);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(0, 19);
            this.txtHoTen.TabIndex = 60;
            // 
            // CTDat_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 457);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PickGioTra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PickGioNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PickNgayTra);
            this.Controls.Add(this.PickNgayNhan);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CTDat_Interface";
            this.Text = "Phan mem quan ly khach san";
            this.Load += new System.EventHandler(this.CTDat_Interface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker PickNgayTra;
        private System.Windows.Forms.DateTimePicker PickNgayNhan;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.DateTimePicker PickGioNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker PickGioTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtCMND;
        private System.Windows.Forms.Label txtMaPhong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtHoTen;
    }
}