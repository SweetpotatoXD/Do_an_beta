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
    public partial class MaHang : Form
    {
        public MaHang()
        {
            InitializeComponent();
        }

        private void MaHang_Load(object sender, EventArgs e)
        {
            hienthidata();
            
        }
        private void hienthidata()
        {
            string sql = "select * from tb_HangHoa";
            dataGridView1.DataSource = Dataconnection.truyvan(sql);
            dataGridView1.AllowUserToAddRows = false;
        }
        private void cb_thaotac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_thaotac.Text == "Xóa" || cb_thaotac.Text == "Tìm")
            {
                //Delete other data
                tb_mh.Clear();
                tb_tenh.Clear();
                tb_makho.Clear();
                tb_sl.Clear();
                tb_dvt.Clear();
                tp_count.count_main = 2;
                //Hide UI textbox
                tb_tenh.Hide();
                tb_dvt.Hide();
                tb_makho.Hide();
                tb_sl.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label13.Hide();
                tb_dg.Hide();
            }
            else if (cb_thaotac.Text == "Thêm" || cb_thaotac.Text == "Sửa")
            {
                tb_tenh.Show();
                tb_dvt.Show();
                tb_makho.Show();
                tb_sl.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label13.Show();
                tb_dg.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string thaotac = cb_thaotac.Text;
            //*2check option in cb_thaotac
            if (thaotac == "Thêm")
            {
                //Add employ information
                string ma = tb_mh.Text;
                string ten = tb_tenh.Text;
                string dvt = tb_dvt.Text;
                string mk = tb_makho.Text;
<<<<<<< Updated upstream
                string sl = tb_sl.Text;
                string dg = tb_dg.Text;
                string them = "insert into tb_HangHoa values('" + ma + "','" + ten + "','" + dg + "','" + sl + "','" + dvt + "','" +mk + "')";
                Dataconnection.run(them);
=======
                int sl = int.Parse(tb_sl.Text);
                int dg =int.Parse(tb_dg.Text);
                string them = "insert into tb_NhanVien values('" + ma + "','" + ten + "','" + dg + "','" + sl + "','" + dvt + "','" +mk + "')";
                Dataconnection.truyvan(them);
>>>>>>> Stashed changes
                hienthidata();
            }
            else if (thaotac == "Sửa")
            {

                string ma = tb_mh.Text;
                string ten = tb_tenh.Text;
                string dvt = tb_dvt.Text;
                string mk = tb_makho.Text;
                string sl = tb_sl.Text;
                string dg = tb_dg.Text;
                string sua = "update tb_HangHoa set Tenhang=N'" + ten + "',Dongia='" + dg + "',Soluong='" + sl+ "',DVT=N'" + dvt+"',Makho='"+mk+ "'where Mahang='" + ma + "'";
                Dataconnection.run(sua);
                hienthidata();
            }
            else if (thaotac == "Xóa")
            {
                string ma = tb_mh.Text;
                string xoa = "delete tb_HangHoa where Mahang='" + ma + "'";
                Dataconnection.run(xoa);
                hienthidata();
            }
            else if (thaotac == "Tìm")
            {
                string tim = tb_mh.Text;
                string sqltim = "select * from tb_HangHoa where Mahang='" + tim + "'";
                Dataconnection.run(sqltim);
                Dataconnection.truyvan(sqltim);
                hienthidata();
            }
        }
    }
}
