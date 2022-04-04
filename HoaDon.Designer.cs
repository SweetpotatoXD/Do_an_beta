namespace Do_an
{
    partial class HoaDon
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
            this.txtnv = new System.Windows.Forms.TextBox();
            this.dung = new System.Windows.Forms.Label();
            this.sai = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_thaotac = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txthd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txttt = new System.Windows.Forms.TextBox();
            this.dt_ngay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnv
            // 
            this.txtnv.Location = new System.Drawing.Point(102, 106);
            this.txtnv.Name = "txtnv";
            this.txtnv.Size = new System.Drawing.Size(158, 20);
            this.txtnv.TabIndex = 63;
            // 
            // dung
            // 
            this.dung.AutoSize = true;
            this.dung.ForeColor = System.Drawing.Color.Lime;
            this.dung.Location = new System.Drawing.Point(272, 41);
            this.dung.Name = "dung";
            this.dung.Size = new System.Drawing.Size(0, 13);
            this.dung.TabIndex = 62;
            // 
            // sai
            // 
            this.sai.AutoSize = true;
            this.sai.ForeColor = System.Drawing.Color.Red;
            this.sai.Location = new System.Drawing.Point(266, 41);
            this.sai.Name = "sai";
            this.sai.Size = new System.Drawing.Size(0, 13);
            this.sai.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(85, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 60;
            this.label13.Text = "*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Xóa tất cả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "Bảng tổng hợp hóa đơn:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(349, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(212, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = " Lưu ý: Các miền có dấu * là phần bắt buộc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(427, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "*";
            // 
            // cb_thaotac
            // 
            this.cb_thaotac.FormattingEnabled = true;
            this.cb_thaotac.Items.AddRange(new object[] {
            "Thêm",
            "Sửa",
            "Xóa",
            "Tìm"});
            this.cb_thaotac.Location = new System.Drawing.Point(444, 100);
            this.cb_thaotac.Name = "cb_thaotac";
            this.cb_thaotac.Size = new System.Drawing.Size(158, 21);
            this.cb_thaotac.TabIndex = 55;
            this.cb_thaotac.Text = " -Chọn thao tác-";
            this.cb_thaotac.SelectedIndexChanged += new System.EventHandler(this.cb_thaotac_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Thao tác:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(85, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tổng tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Ngày mua:";
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(102, 73);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(158, 20);
            this.txtmk.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Mã khách:";
            // 
            // txthd
            // 
            this.txthd.AccessibleDescription = "";
            this.txthd.Cursor = System.Windows.Forms.Cursors.Default;
            this.txthd.Location = new System.Drawing.Point(102, 39);
            this.txthd.Name = "txthd";
            this.txthd.Size = new System.Drawing.Size(158, 20);
            this.txthd.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Mã HĐ:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(607, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 41;
            this.button4.Text = "Xác nhận";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 161);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(592, 153);
            this.dataGridView1.TabIndex = 64;
            // 
            // txttt
            // 
            this.txttt.Location = new System.Drawing.Point(444, 71);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(158, 20);
            this.txttt.TabIndex = 48;
            // 
            // dt_ngay
            // 
            this.dt_ngay.Location = new System.Drawing.Point(444, 39);
            this.dt_ngay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dt_ngay.Name = "dt_ngay";
            this.dt_ngay.Size = new System.Drawing.Size(158, 20);
            this.dt_ngay.TabIndex = 65;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 428);
            this.Controls.Add(this.dt_ngay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtnv);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HoaDon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnv;
        private System.Windows.Forms.Label dung;
        private System.Windows.Forms.Label sai;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_thaotac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.DateTimePicker dt_ngay;
    }
}