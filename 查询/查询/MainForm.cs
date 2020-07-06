using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 查询
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 查询族谱信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            查询族谱 f = new 查询族谱();
            this.Hide();
            f.ShowDialog();
            Application.ExitThread();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 查询成员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            查询成员 f = new 查询成员();
            this.Hide();
            f.ShowDialog();
            Application.ExitThread();
        }
    }
}
