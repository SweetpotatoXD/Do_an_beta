namespace Do_an
{
    partial class Kho
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_tk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dung
            // 
            this.dung.AutoSize = true;
            this.dung.ForeColor = System.Drawing.Color.Lime;
            this.dung.Location = new System.Drawing.Point(399, 50);
            this.dung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dung.Name = "dung";
            this.dung.Size = new System.Drawing.Size(0, 17);
            this.dung.TabIndex = 40;
            // 
            // sai
            // 
            this.sai.AutoSize = true;
            this.sai.ForeColor = System.Drawing.Color.Red;
            this.sai.Location = new System.Drawing.Point(391, 50);
            this.sai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sai.Name = "sai";
            this.sai.Size = new System.Drawing.Size(0, 17);
            this.sai.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(149, 89);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 37;
            this.button1.Text = "Xóa tất cả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 177);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Bảng tổng hợp thông tin nhân viên:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(504, 177);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(279, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = " Lưu ý: Các miền có dấu * là phần bắt buộc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(149, 133);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "*";
            // 
            // cb_thaotac
            // 
            this.cb_thaotac.FormattingEnabled = true;
            this.cb_thaotac.Items.AddRange(new object[] {
            "Thêm",
            "Sửa",
            "Xóa",
            "Tìm"});
            this.cb_thaotac.Location = new System.Drawing.Point(172, 133);
            this.cb_thaotac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_thaotac.Name = "cb_thaotac";
            this.cb_thaotac.Size = new System.Drawing.Size(209, 24);
            this.cb_thaotac.TabIndex = 33;
            this.cb_thaotac.Text = " -Chọn thao tác-";
            this.cb_thaotac.SelectedIndexChanged += new System.EventHandler(this.cb_thaotac_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 137);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Thao tác:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(149, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "*";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 197);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1021, 271);
            this.dataGridView1.TabIndex = 30;
            // 
            // tb_tk
            // 
            this.tb_tk.Location = new System.Drawing.Point(172, 89);
            this.tb_tk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_tk.Name = "tb_tk";
            this.tb_tk.Size = new System.Drawing.Size(209, 22);
            this.tb_tk.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên kho:";
            // 
            // tb_mk
            // 
            this.tb_mk.AccessibleDescription = "";
            this.tb_mk.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_mk.Location = new System.Drawing.Point(172, 47);
            this.tb_mk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_mk.Name = "tb_mk";
            this.tb_mk.Size = new System.Drawing.Size(209, 22);
            this.tb_mk.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã kho:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(389, 130);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 16;
            this.button4.Text = "Xác nhận";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Controls.Add(this.tb_tk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_mk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Kho";
            this.Text = "Quản lý kho";
            this.Load += new System.EventHandler(this.Kho_Load_1);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_tk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_mk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}