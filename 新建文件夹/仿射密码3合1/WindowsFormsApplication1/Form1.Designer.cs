namespace WindowsFormsApplication1
{
    partial class 密码实验
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
            this.text1 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.aaa = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bbb = new System.Windows.Forms.NumericUpDown();
            this.bianma = new System.Windows.Forms.Button();
            this.jiema = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zifu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fangshe = new System.Windows.Forms.RadioButton();
            this.kaisa = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wenjian = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.offset = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.open = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.run = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.yuanwen = new System.Windows.Forms.RichTextBox();
            this.yiwen = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.aaa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offset)).BeginInit();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("宋体", 12F);
            this.text1.Location = new System.Drawing.Point(38, 124);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(40, 16);
            this.text1.TabIndex = 0;
            this.text1.Text = "原文";
            this.text1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("宋体", 12F);
            this.text2.Location = new System.Drawing.Point(38, 284);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(40, 16);
            this.text2.TabIndex = 1;
            this.text2.Text = "密文";
            // 
            // aaa
            // 
            this.aaa.Location = new System.Drawing.Point(106, 187);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(79, 21);
            this.aaa.TabIndex = 4;
            this.aaa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aaa.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label1.Location = new System.Drawing.Point(80, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "a";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "b";
            // 
            // bbb
            // 
            this.bbb.Location = new System.Drawing.Point(225, 187);
            this.bbb.Name = "bbb";
            this.bbb.Size = new System.Drawing.Size(79, 21);
            this.bbb.TabIndex = 7;
            // 
            // bianma
            // 
            this.bianma.Location = new System.Drawing.Point(326, 186);
            this.bianma.Name = "bianma";
            this.bianma.Size = new System.Drawing.Size(75, 23);
            this.bianma.TabIndex = 8;
            this.bianma.Text = "加密";
            this.bianma.UseVisualStyleBackColor = true;
            this.bianma.Click += new System.EventHandler(this.bianma_Click);
            // 
            // jiema
            // 
            this.jiema.Location = new System.Drawing.Point(326, 216);
            this.jiema.Name = "jiema";
            this.jiema.Size = new System.Drawing.Size(75, 21);
            this.jiema.TabIndex = 9;
            this.jiema.Text = "解密";
            this.jiema.UseVisualStyleBackColor = true;
            this.jiema.Click += new System.EventHandler(this.jiema_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zifu,
            this.bili});
            this.dataGridView1.Location = new System.Drawing.Point(451, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(165, 299);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // zifu
            // 
            this.zifu.HeaderText = "字符";
            this.zifu.Name = "zifu";
            this.zifu.Width = 55;
            // 
            // bili
            // 
            this.bili.HeaderText = "比例(%)";
            this.bili.Name = "bili";
            this.bili.Width = 70;
            // 
            // fangshe
            // 
            this.fangshe.AutoSize = true;
            this.fangshe.Location = new System.Drawing.Point(119, 20);
            this.fangshe.Name = "fangshe";
            this.fangshe.Size = new System.Drawing.Size(71, 16);
            this.fangshe.TabIndex = 12;
            this.fangshe.Text = "仿射密码";
            this.fangshe.UseVisualStyleBackColor = true;
            this.fangshe.CheckedChanged += new System.EventHandler(this.fangshe_CheckedChanged_1);
            // 
            // kaisa
            // 
            this.kaisa.AutoSize = true;
            this.kaisa.Checked = true;
            this.kaisa.Location = new System.Drawing.Point(24, 20);
            this.kaisa.Name = "kaisa";
            this.kaisa.Size = new System.Drawing.Size(71, 16);
            this.kaisa.TabIndex = 13;
            this.kaisa.TabStop = true;
            this.kaisa.Text = "凯撒密码";
            this.kaisa.UseVisualStyleBackColor = true;
            this.kaisa.CheckedChanged += new System.EventHandler(this.kaisa_CheckedChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.wenjian);
            this.groupBox1.Controls.Add(this.kaisa);
            this.groupBox1.Controls.Add(this.fangshe);
            this.groupBox1.Location = new System.Drawing.Point(84, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 48);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // wenjian
            // 
            this.wenjian.AutoSize = true;
            this.wenjian.Location = new System.Drawing.Point(213, 20);
            this.wenjian.Name = "wenjian";
            this.wenjian.Size = new System.Drawing.Size(71, 16);
            this.wenjian.TabIndex = 14;
            this.wenjian.TabStop = true;
            this.wenjian.Text = "文件输入";
            this.wenjian.UseVisualStyleBackColor = true;
            this.wenjian.CheckedChanged += new System.EventHandler(this.wenjian_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "每隔多少字符时b+1";
            // 
            // offset
            // 
            this.offset.Location = new System.Drawing.Point(225, 219);
            this.offset.Name = "offset";
            this.offset.Size = new System.Drawing.Size(79, 21);
            this.offset.TabIndex = 16;
            this.offset.ValueChanged += new System.EventHandler(this.offset_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(280, 219);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(62, 23);
            this.open.TabIndex = 17;
            this.open.Text = "打开文件";
            this.open.UseVisualStyleBackColor = true;
            this.open.Visible = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(84, 221);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(190, 21);
            this.path.TabIndex = 18;
            this.path.Visible = false;
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(353, 219);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(54, 23);
            this.run.TabIndex = 19;
            this.run.Text = "运行";
            this.run.UseVisualStyleBackColor = true;
            this.run.Visible = false;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // yuanwen
            // 
            this.yuanwen.Location = new System.Drawing.Point(84, 101);
            this.yuanwen.Name = "yuanwen";
            this.yuanwen.Size = new System.Drawing.Size(323, 67);
            this.yuanwen.TabIndex = 20;
            this.yuanwen.Text = "";
            // 
            // yiwen
            // 
            this.yiwen.Location = new System.Drawing.Point(84, 261);
            this.yiwen.Name = "yiwen";
            this.yiwen.Size = new System.Drawing.Size(323, 65);
            this.yiwen.TabIndex = 20;
            this.yiwen.Text = "";
            // 
            // 密码实验
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 338);
            this.Controls.Add(this.yiwen);
            this.Controls.Add(this.yuanwen);
            this.Controls.Add(this.run);
            this.Controls.Add(this.path);
            this.Controls.Add(this.open);
            this.Controls.Add(this.offset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.jiema);
            this.Controls.Add(this.bianma);
            this.Controls.Add(this.bbb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Name = "密码实验";
            this.Text = "密码学";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aaa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.NumericUpDown aaa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown bbb;
        private System.Windows.Forms.Button bianma;
        private System.Windows.Forms.Button jiema;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zifu;
        private System.Windows.Forms.DataGridViewTextBoxColumn bili;
        private System.Windows.Forms.RadioButton fangshe;
        private System.Windows.Forms.RadioButton kaisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown offset;
        private System.Windows.Forms.RadioButton wenjian;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox yuanwen;
        private System.Windows.Forms.RichTextBox yiwen;
    }
}

