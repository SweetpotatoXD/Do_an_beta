using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string who;
            who=this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            if(who== "Quản lý nhân viên")
            {
                Nhanvien f=new Nhanvien();
                f.ShowDialog();
            }
            else if(who== "Quản lý hàng hóa")
            {
                MaHang f = new MaHang();
                f.ShowDialog();
            }
            else if(who=="Quản lý kho")
            {

            }
            else
            {
                MessageBox.Show("Thông báo", "Đã có lỗi xảy ra", MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Warning);
            }
        }
    }
}
