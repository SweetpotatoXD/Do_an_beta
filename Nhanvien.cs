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
        public void loaddata()
        {
                string query = "select * from tb_NhanVien";
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlConnection conn = Dataconnection.sqlCon;
                SqlCommand cmd = conn.CreateCommand();
                
                cmd.Parameters.AddWithValue("@manv", tb_manv.Text);
                cmd.Parameters.AddWithValue("@hoten", tb_hoten.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", tb_ngaysinh.Text);
                cmd.Parameters.AddWithValue("@gioitinh", tb_gioitinh.Text);
                cmd.Parameters.AddWithValue("@quequan", tb_quequan.Text);
                cmd.Parameters.AddWithValue("@sdt", tb_sdt.Text);
                cmd.Parameters.AddWithValue("@cccd", tb_cmtnd.Text);
                cmd.ExecuteNonQuery();
            dataGridView1.DataSource = Dataconnection.truyvan(query);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                string thaotac = cb_thaotac.Text;
            //*2check option in cb_thaotac
            SqlCommand cmd = new SqlCommand("select * from tb_NhanVien");
            if (thaotac == "Thêm")
                {
                //Add employ information
                l_test.Text = "Them";
                cmd.CommandText = "insert into tb_NhanVien value(@manv,@hoten,@ngaysinh,@gioitinh,@quequan,@sdt,@cccd)";
                loaddata();

                }
                else if(thaotac == "Sửa")
                {
                //Change inf
                cmd.CommandText = "update tb_NhanVien set MaNV=@manv,Hoten=@hoten,Ngaysinh=@ngaysinh,Gioitinh=@gioitinh,Quequan=@quequan,SDT=@sdt,CMTND=@cccd where MaNV=@manv";
                loaddata();
            }
                else if(thaotac== "Xóa")
                {
                //Delete inf
                cmd.CommandText = "delete from tb_NhanVien where MaNV=@manv";
                loaddata();
            }
                else if (thaotac == "Tìm")
                {
                //Search inf
                cmd.CommandText = "select * from tb_NhanVien where MaNV=@manv";
                loaddata();
            }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra");
                }   
            

            
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            hienthidata();
        }

        private void hienthidata()
        {
            string sql = "select * from tb_NhanVien";
            dataGridView1.DataSource = Dataconnection.truyvan(sql);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

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
            tb_ngaysinh.Clear();
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
                tb_ngaysinh.Clear();
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
                tb_ngaysinh.Clear();
                tb_quequan.Clear();
                tb_sdt.Clear();
                tb_cmtnd.Clear();
                tb_gioitinh.Clear();
                tp_count.count_main = 2;
                //Hide UI textbox
                tb_hoten.Hide();
                tb_ngaysinh.Hide();
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
                tb_ngaysinh.Show();
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

        private void tb_manv_Enter(object sender, EventArgs e)
        {
        }

    }
    
}
