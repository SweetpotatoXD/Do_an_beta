namespace Do_an
{
    partial class MaHang
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
            this.tb_dvt = new System.Windows.Forms.TextBox();
            this.tb_sl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tenh = new System.Windows.Forms.TextBox();
            this.tb_makho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_mh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_dg = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dung
            // 
            this.dung.AutoSize = true;
            this.dung.ForeColor = System.Drawing.Color.Lime;
            this.dung.Location = new System.Drawing.Point(277, 19);
            this.dung.Name = "dung";
            this.dung.Size = new System.Drawing.Size(0, 13);
            this.dung.TabIndex = 39;
            // 
            // sai
            // 
            this.sai.AutoSize = true;
            this.sai.ForeColor = System.Drawing.Color.Red;
            this.sai.Location = new System.Drawing.Point(271, 19);
            this.sai.Name = "sai";
            this.sai.Size = new System.Drawing.Size(0, 13);
            this.sai.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(90, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Xóa tất cả";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Bảng tổng hợp hàng hóa:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(351, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(212, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = " Lưu ý: Các miền có dấu * là phần bắt buộc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(432, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 33;
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
            this.cb_thaotac.Location = new System.Drawing.Point(449, 79);
            this.cb_thaotac.Name = "cb_thaotac";
            this.cb_thaotac.Size = new System.Drawing.Size(158, 21);
            this.cb_thaotac.TabIndex = 32;
            this.cb_thaotac.Text = " -Chọn thao tác-";
            this.cb_thaotac.SelectedIndexChanged += new System.EventHandler(this.cb_thaotac_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Thao tác:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(90, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Đơn giá:";
            // 
            // tb_dvt
            // 
            this.tb_dvt.Location = new System.Drawing.Point(449, 19);
            this.tb_dvt.Name = "tb_dvt";
            this.tb_dvt.Size = new System.Drawing.Size(158, 20);
            this.tb_dvt.TabIndex = 25;
            // 
            // tb_sl
            // 
            this.tb_sl.Location = new System.Drawing.Point(107, 118);
            this.tb_sl.Name = "tb_sl";
            this.tb_sl.Size = new System.Drawing.Size(158, 20);
            this.tb_sl.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "DVT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Số lượng:";
            // 
            // tb_tenh
            // 
            this.tb_tenh.Location = new System.Drawing.Point(107, 50);
            this.tb_tenh.Name = "tb_tenh";
            this.tb_tenh.Size = new System.Drawing.Size(158, 20);
            this.tb_tenh.TabIndex = 28;
            // 
            // tb_makho
            // 
            this.tb_makho.Location = new System.Drawing.Point(449, 50);
            this.tb_makho.Name = "tb_makho";
            this.tb_makho.Size = new System.Drawing.Size(158, 20);
            this.tb_makho.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mã kho:";
            // 
            // tb_mh
            // 
            this.tb_mh.AccessibleDescription = "";
            this.tb_mh.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_mh.Location = new System.Drawing.Point(107, 16);
            this.tb_mh.Name = "tb_mh";
            this.tb_mh.Size = new System.Drawing.Size(158, 20);
            this.tb_mh.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã hàng:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(612, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Xác nhận";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_dg
            // 
            this.tb_dg.Location = new System.Drawing.Point(107, 84);
            this.tb_dg.Name = "tb_dg";
            this.tb_dg.Size = new System.Drawing.Size(158, 20);
            this.tb_dg.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(674, 164);
            this.dataGridView1.TabIndex = 41;
            // 
            // MaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_dg);
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
            this.Controls.Add(this.tb_dvt);
            this.Controls.Add(this.tb_sl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_tenh);
            this.Controls.Add(this.tb_makho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_mh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Name = "MaHang";
            this.Text = "Danh Sách Hàng Hóa";
            this.Load += new System.EventHandler(this.MaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TextBox tb_dvt;
        private System.Windows.Forms.TextBox tb_sl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_tenh;
        private System.Windows.Forms.TextBox tb_makho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_mh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_dg;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}