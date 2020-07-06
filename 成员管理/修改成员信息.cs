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


namespace WindowsFormsApplication4
{
    public partial class 修改成员信息 : Form
    {
        public 修改成员信息()
        {
            InitializeComponent();
        }

        private void 修改成员信息_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fnum,fnewnum, gid, fname, fsex, fbir, fdea, fadd, fpho;
            fnum = textBox1.Text;
            fnewnum = textBox2.Text;
            gid = textBox3.Text;
            fname = textBox4.Text;
            fsex = textBox5.Text;
            fbir = textBox6.Text;
            fdea = textBox7.Text;
            fpho = textBox8.Text;
            fadd = textBox9.Text;           
            String myconn = @"Data Source=LAPTOP-3JDV22CR;Initial Catalog=电子族谱;Integrated Security=True";//数据库实例连接字符串
            SqlConnection sqlConnection = new SqlConnection(myconn);//新建数据库连接实例
            sqlConnection.Open();//打开数据库连接
            
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
                MessageBox.Show("身份证号不能为空！");
            else
            {
                String sql = "update Familiar set Familiar_number = '" + fnewnum + "', Genealogy_id = '" + gid + "', Familiar_name = '" + fname + "', Familiar_sex = '" + fsex + "', Familiar_birthday = '" + fbir + "', Familiar_deathday = '" + fdea + "', Familiar_address = '" + fadd + "', Familiar_phone = '" + fpho + "' where Familiar_number = '"+ fnum+ "'";
                  SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("修改成功！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            成员管理 fm = new 成员管理();
            this.Hide();
            fm.ShowDialog();
            Application.ExitThread();
        }
    }
}
