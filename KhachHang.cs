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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        private void hienthidata()
        {
            string sql = "select * from tb_Khachhang";
            dataGridView1.DataSource = Dataconnection.truyvan(sql);
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            hienthidata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string thaotac = cb_thaotac.Text;
            if (thaotac == "Thêm")
            {
                //Add employ information
                string ma = tb_mk.Text;
                string ten = tb_hoten.Text;
                DateTime ngay = DateTime.Parse(dtngay.Text);
                string gt = tb_gioitinh.Text;
                string dia = tb_quequan.Text;
                int sdt = int.Parse(tb_sdt.Text);
                string mail = tb_mail.Text;
                string them = "insert into tb_KhachHang values('" + ma + "','" + ten + "','" + ngay + "','" + gt + "','" + dia + "','" + sdt + "','" + mail + "')";
                Dataconnection.run(them);
                hienthidata();
            }
            else if (thaotac == "Sửa")
            {

                string ma = tb_mk.Text;
                string ten = tb_hoten.Text;
                DateTime ngay = DateTime.Parse(dtngay.Text);
                string gt = tb_gioitinh.Text;
                string dia = tb_quequan.Text;
                int sdt = int.Parse(tb_sdt.Text);
                string mail =tb_mail.Text;
                string sua = "update tb_KhachHang set Hoten=N'" + ten + "',Ngaysinh='" + ngay + "',Gioitinh='" + gt + "',Diachi='" + dia + "',Dienthoai='" + sdt + "',Email='" +  mail+ "'where Makhach='" + ma + "'";
                Dataconnection.run(sua);
                hienthidata();
            }
            else if (thaotac == "Xóa")
            {
                string ma = tb_mk.Text;
                string xoa = "delete tb_KhachHang where Makhach='" + ma + "'";
                Dataconnection.run(xoa);
                hienthidata();
            }
        }

        private void tb_mk_TextChanged(object sender, EventArgs e)
        {
            if (tp_count.count_1 == 1)
            {
                //*1.2Delete the example word in textbox
                tb_mk.Clear();
                tp_count.count_1 = 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_mk.Clear();
            tb_hoten.Clear();
            tb_quequan.Clear();
            tb_sdt.Clear();
            tb_mail.Clear();
            tb_gioitinh.Clear();
        }

        private void tb_hoten_TextChanged(object sender, EventArgs e)
        {
            if (tp_count.count_2 == 1)
            {
                //*1.2Delete the example word in textbox
                tb_hoten.Clear();
                tp_count.count_2 = 2;
            }
        }

        private void dtngay_ValueChanged(object sender, EventArgs e)
        {
            if (tp_count.count_3 == 1)
            {
                //*1.2Delete the example word in textbox
                tp_count.count_3 = 2;
            }
        }

        private void tb_gioitinh_TextChanged(object sender, EventArgs e)
        {
            if (tp_count.count_4 == 1)
            {
                //*1.2Delete the example word in textbox
                tb_gioitinh.Clear();
                tp_count.count_4 = 2;
            }
        }

        private void tb_quequan_TextChanged(object sender, EventArgs e)
        {
            if (tp_count.count_5 == 1)
            {
                //*1.2Delete the example word in textbox
                tb_quequan.Clear();
                tp_count.count_5 = 2;
            }
        }

        private void tb_sdt_TextChanged(object sender, EventArgs e)
        {
            if (tp_count.count_6 == 1)
            {
                //*1.2Delete the example word in textbox
                tb_sdt.Clear();
                tp_count.count_6 = 2;
            }
        }

        private void tb_mail_TextChanged(object sender, EventArgs e)
        {
            if (tp_count.count_7 == 1)
            {
                //*1.2Delete the example word in textbox
                tb_mail.Clear();
                tp_count.count_7 = 2;
            }
        }

        private void cb_thaotac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_thaotac.Text == "Xóa" || cb_thaotac.Text == "Tìm")
            {
                //Delete other data
                tb_mk.Clear();
                tb_hoten.Clear();
                tb_quequan.Clear();
                tb_sdt.Clear();
                tb_mail.Clear();
                tb_gioitinh.Clear(); ;
                //Hide UI textbox
                tb_hoten.Hide();
                dtngay.Hide();
                tb_gioitinh.Hide();
                tb_quequan.Hide();
                tb_sdt.Hide();
                tb_mail.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label8.Hide();
                label13.Hide();
            }
            else if (cb_thaotac.Text == "Thêm" || cb_thaotac.Text == "Sửa")
            {
                tb_hoten.Show();
                dtngay.Show();
                tb_gioitinh.Show();
                tb_quequan.Show();
                tb_sdt.Show();
                tb_mail.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label8.Show();
                label13.Show();
            }
        }
    }
}
