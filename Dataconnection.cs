using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Do_an
{
    internal class Dataconnection
    {
        //dataconnection
        public static SqlConnection sqlCon;//null do dung sau khi set bien
        public static void MoketNoi()
        {
            String str = @"Data Source=DESKTOP-DHJ1R7L\SQLEXPRESS;Initial Catalog=Do_an;Integrated Security=True";
            sqlCon = new SqlConnection(str);
            sqlCon.Open();

        }
        public static void NgatKetNoi()
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();//đóng kết nối
                sqlCon.Dispose();//giải phóng bộ nhớ
                sqlCon = null;
            }
        }
        static public DataTable truyvan(string sql)
        {
            MoketNoi();
            SqlDataAdapter dap = new SqlDataAdapter(sql, sqlCon); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            DataTable table = new DataTable();
            dap.Fill(table); //Đổ kết quả từ câu lệnh sql vào table
            NgatKetNoi();
            return table;
        }
    }
    public class data_noinj
    {
        //data prevent from sql project
        public int data_list;
        public static void Data_using()
        {

        }
    }
    public class tp_count
    {
        //using for UI temp value
        public static int count_1 = 1;
        public static int count_2 = 1;
        public static int count_3 = 1;
        public static int count_4 = 1;
        public static int count_5 = 1;
        public static int count_6 = 1;
        public static int count_7 = 1;
        public static int count_main = 0;
        public static void delete_all()
        {
            if (count_main == 1)
            {
                count_1 = 2;
                count_2 = 2;
                count_3 = 2;
                count_4 = 2;
                count_5 = 2;
                count_6 = 2;
                count_7 = 2;
            }
        }
    }
    public class check
    {
        public static string temp;
        public static string valuable;
        public static DateTime d_valuable;
        public static void check_valuable()
        {
            string temp = check.temp;
            string valuable=check.valuable;
            if (temp=="char" || temp == "nvarchar")
            {
                
            }else if(temp=="date"){

            }
        }
    }
    
}
    
        

