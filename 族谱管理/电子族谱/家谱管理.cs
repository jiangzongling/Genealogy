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
    public partial class 家谱管理 : Form
    {

        public 家谱管理()
        {
            InitializeComponent();
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

  

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“电子族谱DataSet.Genealogy”中。您可以根据需要移动或删除它。
            this.genealogyTableAdapter.Fill(this.电子族谱DataSet.Genealogy);

        }



        private void 删除button_Click(object sender, EventArgs e)
        {
            String gid;
            gid = textBox1.Text;
            String myconn = @"Data Source=LAPTOP-3JDV22CR;Initial Catalog=电子族谱;Integrated Security=True";//数据库实例连接字符串
            SqlConnection sqlConnection = new SqlConnection(myconn);//新建数据库连接实例
            sqlConnection.Open();//打开数据库连接
            DialogResult dr = MessageBox.Show("      您确定要删除吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)        //如果单击“是”按钮
            {
                //dataGridView1.Rows.Remove(dataGridView1.CurrentRow);//删除当前光标所在行
                String sql = "delete from Genealogy where Genealogy_id='"+ gid +"'";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("删除成功！");
        
            }
            else                                           //如果单击“否”按钮
            {
                return;                  //不执行操作

            }


        }

        private void 新建button_Click(object sender, EventArgs e)
        {
            String gid, gname, gsname, ginfo, gjiax, gzib, gdas;
            gid = textBox1.Text;
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
            if (textBox1.Text.Trim() == "")
                MessageBox.Show("族谱号不能为空！");
            else
            {
                String sql = "INSERT INTO Genealogy(Genealogy_id, Genealogy_name, Genealogy_surname, Genealogy_info, Genealogy_jiax, Genealogy_zib, Genealogy_das) VALUES('" + gid + "','" + gname + "','" + gsname + "','" + ginfo + "','" + gjiax + "','" + gzib + "','" + gdas + "')";//SQL语句向表中写入数据
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("创建成功！");
            }
        }

        private void 修改button_Click(object sender, EventArgs e)
        {                        
                /*修改族谱 fm2 = new 修改族谱();
                this.Hide();
                fm2.ShowDialog();
                Application.ExitThread();*/
            修改族谱 f = new 修改族谱();
            f.Show();
            this.Close();
        }
        private void Panel1_Click(object sender, EventArgs e)
        {
            家谱管理 f1 = new 家谱管理();
            f1.Closed += new EventHandler(this.f1_Closed);
	        f1.Closed += (obj, args) => { Application.Exit(); };
            f1.Show();
            this.Close();
        }
 
       private void f1_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }


        }
    }
