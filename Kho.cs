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
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
        private void Kho_Load(object sender, EventArgs e)
        {
            hienthidata();
        }
        private void hienthidata()
        {
            string sql = "select * from tb_KhoHang";
            dataGridView1.DataSource = Dataconnection.truyvan(sql);
            dataGridView1.AllowUserToAddRows = false;
<<<<<<< Updated upstream
        }
=======
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tb_tk.Clear();
            tb_mk.Clear();
        }

>>>>>>> Stashed changes
        private void button4_Click(object sender, EventArgs e)
        {
            string thaotac = cb_thaotac.Text;
            //*2check option in cb_thaotac
            if (thaotac == "Thêm")
            {
                //Add employ information
                string ma = tb_mk.Text;
                string ten = tb_tk.Text;
<<<<<<< Updated upstream
                string them = "insert into tb_KhoHang values('" + ma + "','" + ten + ")";
=======
                string them = "insert into tb_NhanVien values('" + ma + "','" + ten +"')";
>>>>>>> Stashed changes
                Dataconnection.run(them);
                hienthidata();
            }
            else if (thaotac == "Sửa")
            {

                string ma = tb_mk.Text;
                string ten = tb_tk.Text;
<<<<<<< Updated upstream
                string sua = "update tb_KhoHang set Makho=N'" + ma + "',Tenkho='" + ten ;
=======
                string sua = "update tb_NhanVien set Makho=N'" + ten + "',Tenkho='" + ten;
>>>>>>> Stashed changes
                Dataconnection.run(sua);
                hienthidata();
            }
            else if (thaotac == "Xóa")
            {
<<<<<<< Updated upstream
                string ma = tb_tk.Text;
                string xoa = "delete tb_KhoHang where MaNV='" + ma + "'";
=======
                string ma = tb_mk.Text;
                string xoa = "delete tb_NhanVien where MaNV='" + ma + "'";
>>>>>>> Stashed changes
                Dataconnection.run(xoa);
                hienthidata();
            }
            else if (thaotac == "Tìm")
            {
<<<<<<< Updated upstream
                string tim = tb_tk.Text;
                string sqltim = "select * from tb_KhoHang where MaNV='" + tim + "'";
=======
                string tim = tb_mk.Text;
                string sqltim = "select * from tb_NhanVien where MaNV='" + tim + "'";
>>>>>>> Stashed changes
                Dataconnection.run(sqltim);
                Dataconnection.truyvan(sqltim);
                hienthidata();

            }
        }
    }
}
