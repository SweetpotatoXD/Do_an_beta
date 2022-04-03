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
    public partial class Kho : Form
    {
        public Kho()
        {
            InitializeComponent();
        }
        private void Kho_Load(object sender, EventArgs e)
        {
            hienthidata();
        }
        private void hienthidata()
        {
            string sql = "select * from tb_KhoHang";
            dataGridView1.DataSource = Dataconnection.truyvan(sql);
            dataGridView1.AllowUserToAddRows = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string thaotac = cb_thaotac.Text;
            //*2check option in cb_thaotac
            if (thaotac == "Thêm")
            {
                //Add employ information
                string ma = tb_mk.Text;
                string ten = tb_tk.Text;
                string them = "insert into tb_KhoHang values('" + ma + "','" + ten;
                Dataconnection.run(them);
                hienthidata();
            }
            else if (thaotac == "Sửa")
            {
                string ma = tb_mk.Text;
                string ten = tb_tk.Text;
                string sua = "update tb_KhoHang set Makho=N'" + ma + "',Tenkho='" + ten ;
                Dataconnection.run(sua);
                hienthidata();
            }
            else if (thaotac == "Xóa")
            {
                string ma = tb_tk.Text;
                string xoa = "delete tb_KhoHang where MaNV='" + ma;
                Dataconnection.run(xoa);
                hienthidata();
            }
            else if (thaotac == "Tìm")
            {
                string tim = tb_tk.Text;
                string sqltim = "select * from tb_KhoHang where MaNV='" + tim;
                Dataconnection.run(sqltim);
                Dataconnection.truyvan(sqltim);
                hienthidata();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_tk.Clear();
            tb_mk.Clear();
        }

        private void cb_thaotac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_thaotac.Text == "Xóa" || cb_thaotac.Text == "Tìm")
            {
                tb_tk.Hide();
                label2.Hide();
            }
            else if (cb_thaotac.Text == "Thêm" || cb_thaotac.Text == "Sửa")
            {
                tb_tk.Show();
                label2.Show();
            }
        }
    }
}
