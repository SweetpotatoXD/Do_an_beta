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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        private void hienthidata()
        {
            string sql = "select * from tb_HoaDon";
            dataGridView1.DataSource = Dataconnection.truyvan(sql);
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            hienthidata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string thaotac = cb_thaotac.Text;
            if (thaotac == "Thêm")
            {
                //Add employ information
                string hd = txthd.Text;
                string ma = txtmk.Text;
                string mnv = txtnv.Text;
                DateTime ngay = DateTime.Parse(dtngay.Text);
                int tien = int.Parse(txtdvt.Text);
                string them = "insert into tb_HoaDon values('" + hd + "','" + ma + "','" + mnv + "','" + ngay + "','" + tien + "')";
                Dataconnection.run(them);
                hienthidata();
            }
            else if(thaotac=="Sửa")
            {
                string hd = txthd.Text;
                string ma = txtmk.Text;
                string mnv = txtnv.Text;
                DateTime ngay = DateTime.Parse(dtngay.Text);
                int tien = int.Parse(txtdvt.Text);
                string sua = "update tb_HoaDon set Makhach='" + ma + "',MaNV='" + mnv + "',Ngaymua='" + ngay + "',Tongtien='" + tien + "'Where MaHD='"+hd+"'";
                Dataconnection.run(sua);
                hienthidata();
            }
            else if(thaotac=="Xóa")
            {
                string hd = txthd.Text;
                string xoa = "delete tb_HoaDon where MaHD='" + hd + "'";
                Dataconnection.run(xoa);
                hienthidata();
            }
        }

        private void cb_thaotac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_thaotac.Text == "Xóa" || cb_thaotac.Text == "Tìm")
            {
                //Delete other data
                txthd.Clear();
                txtmk.Clear();
                txtnv.Clear();
                txtdvt.Clear();
                //Hide UI textbox
                txtmk.Hide();
                txtnv.Hide();
                txtdvt.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label13.Hide();
            }
            else if (cb_thaotac.Text == "Thêm" || cb_thaotac.Text == "Sửa")
            {
                txthd.Show();
                dtngay.Show();
                txtmk.Show();
                txtnv.Show();
                txtdvt.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label6.Show();
                label13.Show();
            }
        }
    }
}
