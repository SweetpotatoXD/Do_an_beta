using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Do_an
{
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string thaotac = cb_thaotac.Text;
            //*2check option in cb_thaotac
            l_test.Text = thaotac;
            if (thaotac == "Thêm")
            {
                //Add employ information
                string ma = tb_manv.Text;
                string ten = tb_hoten.Text;
                DateTime ngay = DateTime.Parse(dtngay.Text);
                string gt = tb_gioitinh.Text;
                string dia = tb_quequan.Text;
                int sdt = int.Parse(tb_sdt.Text);
                int cccd = int.Parse(tb_cmtnd.Text);
                string them = "insert into tb_NhanVien values('" + ma + "','" + ten + "','" + ngay + "','" + gt + "','" + dia + "','" + sdt + "','" + cccd + "')";
                Dataconnection.run(them);
                hienthidata();
                reset();
            }
            else if (thaotac == "Sửa")
            {

                string ma = tb_manv.Text;
                string ten = tb_hoten.Text;
                DateTime ngay = DateTime.Parse(dtngay.Text);
                string gt = tb_gioitinh.Text;
                string dia = tb_quequan.Text;
                int sdt = int.Parse(tb_sdt.Text);
                int cccd = int.Parse(tb_cmtnd.Text);
                string sua = "update tb_NhanVien set Hoten=N'" + ten + "',Ngaysinh='" + ngay + "',Gioitinh='" + gt + "',Quequan='" + dia + "',SDT='" + sdt + "',CMTND='" + cccd + "'where MaNV='" + ma + "'";
                Dataconnection.run(sua);
                hienthidata();
                reset();
            }
            else if (thaotac == "Xóa")
            {
                string ma = tb_manv.Text;
                string xoa = "delete tb_NhanVien where MaNV='"+ma+"'";
                Dataconnection.run(xoa);
                hienthidata();
            }
            else if (thaotac == "Tìm")
            {
                string tim = tb_manv.Text;
                string sqltim = "select * from tb_NhanVien where MaNV='"+tim+"'";
                Dataconnection.run(sqltim);
                Dataconnection.truyvan(sqltim);
                hienthidata();

            }
            
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            hienthidata();
            reset();
        }

        private void hienthidata()
        {
            string sql = "select * from tb_NhanVien";
            dataGridView1.DataSource = Dataconnection.truyvan(sql);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void reset()
        {
            tb_manv.Text = "";
            tb_hoten.Text = "";
            dtngay.Text = "";
            tb_gioitinh.Text = "";
            tb_quequan.Text = "";
            tb_sdt.Text = "";
            tb_cmtnd.Text = "";
            tb_manv.Focus();
        }
        private void tb_manv_Click(object sender, EventArgs e)
        {
            //*1UI things
            if (tp_count.count_1 == 1)
            {
                //*1.2Delete the example word in textbox
                tb_manv.Clear();
                tp_count.count_1 = 2;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tb_manv.Clear();
            tb_hoten.Clear();
            tb_quequan.Clear();
            tb_sdt.Clear();
            tb_cmtnd.Clear();
            tb_gioitinh.Clear();
            tp_count.count_main = 2;
        }

        private void tb_hoten_Click(object sender, EventArgs e)
        {
            //*1UI things
            if (tp_count.count_2 == 1)
            {
                //*1.2Delete the example word in textbox
                tb_hoten.Clear();
                tp_count.count_2 = 2;
            }
        }

        private void tb_ngaysinh_Click(object sender, EventArgs e)
        {
            //*1UI things
            if (tp_count.count_3 == 1)
            {
                //*1.2Delete the example word in textbox
                tp_count.count_3 = 2;
            }
        }

        private void tb_gioitinh_Click(object sender, EventArgs e)
        {
            //*1UI things
            if (tp_count.count_4 == 1)
            {
                //*1.2Delete the example word in textbox
                tb_gioitinh.Clear();
                tp_count.count_4 = 2;
            }
        }

        private void tb_quequan_Click(object sender, EventArgs e)
        {
            //*1UI things
            if (tp_count.count_5 == 1)
            {
                //*1.2Delete the example word in textbox
                tb_quequan.Clear();
                tp_count.count_5 = 2;
            }
        }

        private void tb_sdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_sdt_Click(object sender, EventArgs e)
        {
            //*1UI things
            if (tp_count.count_6 == 1)
            {
                //*1.2Delete the example word in textbox
                tb_sdt.Clear();
                tp_count.count_6 = 2;
            }
        }

        private void tb_cmtnd_Click(object sender, EventArgs e)
        {
            //*1UI things
            if (tp_count.count_7 == 1)
            {
                //*1.2Delete the example word in textbox
                tb_cmtnd.Clear();
                tp_count.count_7 = 2;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cb_thaotac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_thaotac.Text == "Xóa" || cb_thaotac.Text == "Tìm")
            {
                //Delete other data
                tb_manv.Clear();
                tb_hoten.Clear();
                tb_quequan.Clear();
                tb_sdt.Clear();
                tb_cmtnd.Clear();
                tb_gioitinh.Clear();
                tp_count.count_main = 2;
                //Hide UI textbox
                tb_hoten.Hide();
                dtngay.Hide();
                tb_gioitinh.Hide();
                tb_quequan.Hide();
                tb_sdt.Hide();
                tb_cmtnd.Hide();
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
                tb_cmtnd.Show();
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
