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

namespace 查询
{
    public partial class 查询成员 : Form
    {
        public 查询成员()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fnum;
            fnum = textBox1.Text;
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3JDV22CR;Initial Catalog=电子族谱;Integrated Security=True");
            con.Open();
            string sql = "select * from Familiar where Familiar_number = '" + fnum + "'";
            SqlCommand sc = new SqlCommand(sql, con);
            SqlDataAdapter sda = new SqlDataAdapter(sc);//读取表数据
            DataSet ds = new DataSet();
            sda.Fill(ds, "ds");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ds";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();
            this.Hide();
            f.ShowDialog();
            Application.ExitThread();
        }
    }
}
