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
    public partial class 成员管理 : Form
    {
        public 成员管理()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fnum, gid, fname, fsex, fbir, fdea, fadd, fpho;
            fnum = textBox1.Text;
            gid = textBox2.Text;
            fname = textBox3.Text;
            fsex = textBox4.Text;
            fbir = textBox5.Text;
            fdea = textBox6.Text;
            fadd = textBox7.Text;
            fpho = textBox8.Text;
            String myconn = @"Data Source=LAPTOP-3JDV22CR;Initial Catalog=电子族谱;Integrated Security=True";//数据库实例连接字符串
            SqlConnection sqlConnection = new SqlConnection(myconn);//新建数据库连接实例
            sqlConnection.Open();//打开数据库连接
            if (textBox1.Text.Trim() == "")
                MessageBox.Show("身份证号不能为空！");
            else
            {
                String sql = "INSERT INTO Familiar(Familiar_number, Genealogy_id, Familiar_name, Familiar_sex, Familiar_birthday, Familiar_deathday, Familiar_address, Familiar_phone) VALUES('" + fnum + "','" + gid + "','" + fname + "','" + fsex + "','" + fbir + "','" + fdea + "','" + fadd + "','" + fpho + "')";//SQL语句向表中写入数据
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("创建成功！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String fnum;
            fnum = textBox1.Text;
            String myconn = @"Data Source=LAPTOP-3JDV22CR;Initial Catalog=电子族谱;Integrated Security=True";//数据库实例连接字符串
            SqlConnection sqlConnection = new SqlConnection(myconn);//新建数据库连接实例
            sqlConnection.Open();//打开数据库连接
            DialogResult dr = MessageBox.Show("      您确定要删除吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)        //如果单击“是”按钮
            {
                //dataGridView1.Rows.Remove(dataGridView1.CurrentRow);//删除当前光标所在行
                String sql = "delete from Familiar where Familiar_number='" + fnum + "'";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("删除成功！");

            }
            else                                           //如果单击“否”按钮
            {
                return;                  //不执行操作

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            修改成员信息 fm = new 修改成员信息();
            this.Hide();
            fm.ShowDialog();
            Application.ExitThread();
        }

        private void 成员管理_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“电子族谱DataSet.Familiar”中。您可以根据需要移动或删除它。
            this.familiarTableAdapter.Fill(this.电子族谱DataSet.Familiar);
            // TODO:  这行代码将数据加载到表“电子族谱DataSet.Familiar”中。您可以根据需要移动或删除它。
            this.familiarTableAdapter.Fill(this.电子族谱DataSet.Familiar);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
 