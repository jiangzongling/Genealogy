namespace 查询
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.族谱管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询族谱信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询成员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.族谱管理ToolStripMenuItem,
            this.成员管理ToolStripMenuItem,
            this.查询信息ToolStripMenuItem,
            this.我的信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 族谱管理ToolStripMenuItem
            // 
            this.族谱管理ToolStripMenuItem.Name = "族谱管理ToolStripMenuItem";
            this.族谱管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.族谱管理ToolStripMenuItem.Text = "族谱管理";
            // 
            // 成员管理ToolStripMenuItem
            // 
            this.成员管理ToolStripMenuItem.Name = "成员管理ToolStripMenuItem";
            this.成员管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.成员管理ToolStripMenuItem.Text = "成员管理";
            // 
            // 查询信息ToolStripMenuItem
            // 
            this.查询信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询族谱信息ToolStripMenuItem,
            this.查询成员信息ToolStripMenuItem});
            this.查询信息ToolStripMenuItem.Name = "查询信息ToolStripMenuItem";
            this.查询信息ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.查询信息ToolStripMenuItem.Text = "查询信息";
            // 
            // 查询族谱信息ToolStripMenuItem
            // 
            this.查询族谱信息ToolStripMenuItem.Name = "查询族谱信息ToolStripMenuItem";
            this.查询族谱信息ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.查询族谱信息ToolStripMenuItem.Text = "查询族谱信息";
            this.查询族谱信息ToolStripMenuItem.Click += new System.EventHandler(this.查询族谱信息ToolStripMenuItem_Click);
            // 
            // 查询成员信息ToolStripMenuItem
            // 
            this.查询成员信息ToolStripMenuItem.Name = "查询成员信息ToolStripMenuItem";
            this.查询成员信息ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.查询成员信息ToolStripMenuItem.Text = "查询成员信息";
            this.查询成员信息ToolStripMenuItem.Click += new System.EventHandler(this.查询成员信息ToolStripMenuItem_Click);
            // 
            // 我的信息ToolStripMenuItem
            // 
            this.我的信息ToolStripMenuItem.Name = "我的信息ToolStripMenuItem";
            this.我的信息ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.我的信息ToolStripMenuItem.Text = "我的信息";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 309);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "电子族谱系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 族谱管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询族谱信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询成员信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的信息ToolStripMenuItem;
    }
}

