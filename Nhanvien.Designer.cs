namespace Do_an
{
    partial class Nhanvien
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
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_gioitinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_quequan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_cmtnd = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_thaotac = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.sai = new System.Windows.Forms.Label();
            this.dung = new System.Windows.Forms.Label();
            this.dtngay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên:";
            // 
            // tb_manv
            // 
            this.tb_manv.AccessibleDescription = "";
            this.tb_manv.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_manv.Location = new System.Drawing.Point(124, 19);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(158, 20);
            this.tb_manv.TabIndex = 2;
            this.tb_manv.Text = "VD:NV01";
            this.tb_manv.Click += new System.EventHandler(this.tb_manv_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 220);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // tb_hoten
            // 
            this.tb_hoten.Location = new System.Drawing.Point(124, 53);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(158, 20);
            this.tb_hoten.TabIndex = 2;
            this.tb_hoten.Text = "VD:Nguyễn Văn A";
            this.tb_hoten.Click += new System.EventHandler(this.tb_hoten_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giới tính:";
            // 
            // tb_gioitinh
            // 
            this.tb_gioitinh.Location = new System.Drawing.Point(124, 121);
            this.tb_gioitinh.Name = "tb_gioitinh";
            this.tb_gioitinh.Size = new System.Drawing.Size(158, 20);
            this.tb_gioitinh.TabIndex = 2;
            this.tb_gioitinh.Text = "Nam/Nữ";
            this.tb_gioitinh.Click += new System.EventHandler(this.tb_gioitinh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Quê quán:";
            // 
            // tb_quequan
            // 
            this.tb_quequan.Location = new System.Drawing.Point(466, 19);
            this.tb_quequan.Name = "tb_quequan";
            this.tb_quequan.Size = new System.Drawing.Size(158, 20);
            this.tb_quequan.TabIndex = 2;
            this.tb_quequan.Text = "Quê quán trong CCCD";
            this.tb_quequan.Click += new System.EventHandler(this.tb_quequan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "SĐT:";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(466, 53);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(158, 20);
            this.tb_sdt.TabIndex = 2;
            this.tb_sdt.Text = "Chỉ điền số";
            this.tb_sdt.Click += new System.EventHandler(this.tb_sdt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "CCCD:";
            // 
            // tb_cmtnd
            // 
            this.tb_cmtnd.Location = new System.Drawing.Point(466, 87);
            this.tb_cmtnd.Name = "tb_cmtnd";
            this.tb_cmtnd.Size = new System.Drawing.Size(158, 20);
            this.tb_cmtnd.TabIndex = 2;
            this.tb_cmtnd.Text = "CCCD 12 số mới";
            this.tb_cmtnd.Click += new System.EventHandler(this.tb_cmtnd_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(629, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Xác nhận";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(107, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Thao tác:";
            // 
            // cb_thaotac
            // 
            this.cb_thaotac.FormattingEnabled = true;
            this.cb_thaotac.Items.AddRange(new object[] {
            "Thêm",
            "Sửa",
            "Xóa",
            "Tìm"});
            this.cb_thaotac.Location = new System.Drawing.Point(466, 121);
            this.cb_thaotac.Name = "cb_thaotac";
            this.cb_thaotac.Size = new System.Drawing.Size(158, 21);
            this.cb_thaotac.TabIndex = 6;
            this.cb_thaotac.Text = " -Chọn thao tác-";
            this.cb_thaotac.SelectedIndexChanged += new System.EventHandler(this.cb_thaotac_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(449, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(368, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(212, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = " Lưu ý: Các miền có dấu * là phần bắt buộc";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Bảng tổng hợp thông tin nhân viên:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Xóa tất cả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(107, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "*";
            // 
            // sai
            // 
            this.sai.AutoSize = true;
            this.sai.ForeColor = System.Drawing.Color.Red;
            this.sai.Location = new System.Drawing.Point(288, 22);
            this.sai.Name = "sai";
            this.sai.Size = new System.Drawing.Size(0, 13);
            this.sai.TabIndex = 12;
            // 
            // dung
            // 
            this.dung.AutoSize = true;
            this.dung.ForeColor = System.Drawing.Color.Lime;
            this.dung.Location = new System.Drawing.Point(294, 22);
            this.dung.Name = "dung";
            this.dung.Size = new System.Drawing.Size(0, 13);
            this.dung.TabIndex = 13;
            // 
            // dtngay
            // 
            this.dtngay.Location = new System.Drawing.Point(124, 86);
            this.dtngay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtngay.Name = "dtngay";
            this.dtngay.Size = new System.Drawing.Size(158, 20);
            this.dtngay.TabIndex = 15;
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtngay);
            this.Controls.Add(this.dung);
            this.Controls.Add(this.sai);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_thaotac);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_cmtnd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_gioitinh);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_hoten);
            this.Controls.Add(this.tb_quequan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_manv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Name = "Nhanvien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.Nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_manv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_gioitinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_quequan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_cmtnd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_thaotac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label sai;
        private System.Windows.Forms.Label dung;
        private System.Windows.Forms.DateTimePicker dtngay;
    }
}