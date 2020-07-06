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
    public partial class 查询族谱 : Form
    {
        public 查询族谱()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gid;
            gid = textBox1.Text;
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3JDV22CR;Initial Catalog=电子族谱;Integrated Security=True");
            con.Open();
            string sql = "select * from Genealogy where Genealogy_id = '"+ gid +"'";
            SqlCommand sc = new SqlCommand(sql,con);
            SqlDataAdapter sda = new SqlDataAdapter(sc);//读取表数据
            if(textBox1.Text.Trim()=="")
                MessageBox.Show("查询失败！");
            DataSet ds = new DataSet();
            sda.Fill(ds, "ds");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "ds";
        }

        private void 查询族谱_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“电子族谱DataSet.Genealogy”中。您可以根据需要移动或删除它。
            this.genealogyTableAdapter.Fill(this.电子族谱DataSet.Genealogy);

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
