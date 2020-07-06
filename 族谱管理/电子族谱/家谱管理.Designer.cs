namespace 电子族谱
{
    partial class 家谱管理
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.删除button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.genealogyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genealogynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genealogysurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genealogyinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genealogyjiaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genealogyzibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genealogydasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genealogyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.电子族谱DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.电子族谱DataSet = new 电子族谱.电子族谱DataSet();
            this.genealogyTableAdapter = new 电子族谱.电子族谱DataSetTableAdapters.GenealogyTableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.修改button = new System.Windows.Forms.Button();
            this.新建button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genealogyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.电子族谱DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.电子族谱DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 1;
            // 
            // 删除button
            // 
            this.删除button.Location = new System.Drawing.Point(206, 18);
            this.删除button.Name = "删除button";
            this.删除button.Size = new System.Drawing.Size(75, 23);
            this.删除button.TabIndex = 2;
            this.删除button.Text = "删除";
            this.删除button.UseVisualStyleBackColor = true;
            this.删除button.Click += new System.EventHandler(this.删除button_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "族谱号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "族谱名";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genealogyidDataGridViewTextBoxColumn,
            this.genealogynameDataGridViewTextBoxColumn,
            this.genealogysurnameDataGridViewTextBoxColumn,
            this.genealogyinfoDataGridViewTextBoxColumn,
            this.genealogyjiaxDataGridViewTextBoxColumn,
            this.genealogyzibDataGridViewTextBoxColumn,
            this.genealogydasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.genealogyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(416, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(531, 363);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // genealogyidDataGridViewTextBoxColumn
            // 
            this.genealogyidDataGridViewTextBoxColumn.DataPropertyName = "Genealogy_id";
            this.genealogyidDataGridViewTextBoxColumn.HeaderText = "族谱号";
            this.genealogyidDataGridViewTextBoxColumn.Name = "genealogyidDataGridViewTextBoxColumn";
            this.genealogyidDataGridViewTextBoxColumn.Width = 70;
            // 
            // genealogynameDataGridViewTextBoxColumn
            // 
            this.genealogynameDataGridViewTextBoxColumn.DataPropertyName = "Genealogy_name";
            this.genealogynameDataGridViewTextBoxColumn.HeaderText = "族谱名";
            this.genealogynameDataGridViewTextBoxColumn.Name = "genealogynameDataGridViewTextBoxColumn";
            this.genealogynameDataGridViewTextBoxColumn.Width = 69;
            // 
            // genealogysurnameDataGridViewTextBoxColumn
            // 
            this.genealogysurnameDataGridViewTextBoxColumn.DataPropertyName = "Genealogy_surname";
            this.genealogysurnameDataGridViewTextBoxColumn.HeaderText = "姓氏";
            this.genealogysurnameDataGridViewTextBoxColumn.Name = "genealogysurnameDataGridViewTextBoxColumn";
            this.genealogysurnameDataGridViewTextBoxColumn.Width = 70;
            // 
            // genealogyinfoDataGridViewTextBoxColumn
            // 
            this.genealogyinfoDataGridViewTextBoxColumn.DataPropertyName = "Genealogy_info";
            this.genealogyinfoDataGridViewTextBoxColumn.HeaderText = "简介";
            this.genealogyinfoDataGridViewTextBoxColumn.Name = "genealogyinfoDataGridViewTextBoxColumn";
            this.genealogyinfoDataGridViewTextBoxColumn.Width = 70;
            // 
            // genealogyjiaxDataGridViewTextBoxColumn
            // 
            this.genealogyjiaxDataGridViewTextBoxColumn.DataPropertyName = "Genealogy_jiax";
            this.genealogyjiaxDataGridViewTextBoxColumn.HeaderText = "家训";
            this.genealogyjiaxDataGridViewTextBoxColumn.Name = "genealogyjiaxDataGridViewTextBoxColumn";
            this.genealogyjiaxDataGridViewTextBoxColumn.Width = 70;
            // 
            // genealogyzibDataGridViewTextBoxColumn
            // 
            this.genealogyzibDataGridViewTextBoxColumn.DataPropertyName = "Genealogy_zib";
            this.genealogyzibDataGridViewTextBoxColumn.HeaderText = "字辈";
            this.genealogyzibDataGridViewTextBoxColumn.Name = "genealogyzibDataGridViewTextBoxColumn";
            this.genealogyzibDataGridViewTextBoxColumn.Width = 69;
            // 
            // genealogydasDataGridViewTextBoxColumn
            // 
            this.genealogydasDataGridViewTextBoxColumn.DataPropertyName = "Genealogy_das";
            this.genealogydasDataGridViewTextBoxColumn.HeaderText = "大事记";
            this.genealogydasDataGridViewTextBoxColumn.Name = "genealogydasDataGridViewTextBoxColumn";
            this.genealogydasDataGridViewTextBoxColumn.Width = 70;
            // 
            // genealogyBindingSource
            // 
            this.genealogyBindingSource.DataMember = "Genealogy";
            this.genealogyBindingSource.DataSource = this.电子族谱DataSetBindingSource;
            // 
            // 电子族谱DataSetBindingSource
            // 
            this.电子族谱DataSetBindingSource.DataSource = this.电子族谱DataSet;
            this.电子族谱DataSetBindingSource.Position = 0;
            // 
            // 电子族谱DataSet
            // 
            this.电子族谱DataSet.DataSetName = "电子族谱DataSet";
            this.电子族谱DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genealogyTableAdapter
            // 
            this.genealogyTableAdapter.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(73, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "简介";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "家训";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(278, 72);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 25);
            this.textBox4.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "字辈";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "大事记";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(278, 124);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 25);
            this.textBox5.TabIndex = 16;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(15, 220);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(164, 164);
            this.richTextBox2.TabIndex = 17;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(222, 220);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(164, 119);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(926, 22);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 362);
            this.vScrollBar1.TabIndex = 0;
            // 
            // 修改button
            // 
            this.修改button.Location = new System.Drawing.Point(303, 19);
            this.修改button.Name = "修改button";
            this.修改button.Size = new System.Drawing.Size(75, 23);
            this.修改button.TabIndex = 19;
            this.修改button.Text = "修改";
            this.修改button.UseVisualStyleBackColor = true;
            this.修改button.Click += new System.EventHandler(this.修改button_Click);
            // 
            // 新建button
            // 
            this.新建button.Location = new System.Drawing.Point(265, 361);
            this.新建button.Name = "新建button";
            this.新建button.Size = new System.Drawing.Size(75, 23);
            this.新建button.TabIndex = 20;
            this.新建button.Text = "新建";
            this.新建button.UseVisualStyleBackColor = true;
            this.新建button.Click += new System.EventHandler(this.新建button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "姓氏";
            // 
            // 家谱管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 413);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.新建button);
            this.Controls.Add(this.修改button);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.删除button);
            this.Controls.Add(this.textBox1);
            this.Name = "家谱管理";
            this.Text = "家谱管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genealogyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.电子族谱DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.电子族谱DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button 删除button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private 电子族谱DataSet 电子族谱DataSet;
        private System.Windows.Forms.BindingSource 电子族谱DataSetBindingSource;
        private System.Windows.Forms.BindingSource genealogyBindingSource;
        private 电子族谱DataSetTableAdapters.GenealogyTableAdapter genealogyTableAdapter;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button 修改button;
        private System.Windows.Forms.Button 新建button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn genealogyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genealogynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genealogysurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genealogyinfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genealogyjiaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genealogyzibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genealogydasDataGridViewTextBoxColumn;
    }
}

