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

namespace 电子族谱
{
    public partial class 修改族谱 : Form
    {
       
        public 修改族谱()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String gid, ngid,gname, gsname, ginfo, gjiax, gzib, gdas;
            gid = textBox1.Text;
            ngid = textBox6.Text;
            gname = textBox2.Text;
            gsname = textBox3.Text;
            ginfo = richTextBox1.Text;
            gjiax = textBox4.Text;
            gzib = textBox5.Text;
            gdas = richTextBox2.Text;
            String myconn = @"Data Source=LAPTOP-3JDV22CR;Initial Catalog=电子族谱;Integrated Security=True";//数据库实例连接字符串
            SqlConnection sqlConnection = new SqlConnection(myconn);//新建数据库连接实例
            sqlConnection.Open();//打开数据库连接
            //String sel = "select Genealogy_id,Genealogy_name, from Genealogy where Genealogy_id='" + gid + "'and Genealogy_name='" + gname + "'";//SQL语句实现表数据的读取
            if(textBox1.Text.Trim()==""||textBox6.Text.Trim() == "")
                MessageBox.Show("族谱号不能为空！");
            else{
            String sql = "update Genealogy set Genealogy_id = '" + ngid + "', Genealogy_name = '" + gname + "', Genealogy_surname= '" + gsname + "', Genealogy_info= '" + ginfo + "', Genealogy_jiax= '" + gjiax + "', Genealogy_zib= '" + gzib + "', Genealogy_das= '" + gdas + "' where Genealogy_id = '" + gid + "'";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("修改成功！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            家谱管理 f = new 家谱管理();
            f.Show();
            this.Close();
        }

       
    }
}
