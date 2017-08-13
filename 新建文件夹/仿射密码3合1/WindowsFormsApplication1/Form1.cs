using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class 密码实验 : Form
    {
        public struct alp
        {
            public char a;
            public int x;
        }
        int x, y;
        OpenFileDialog ofd;
        public 密码实验()
        {
            InitializeComponent();
        }

        public void showall()
        {
            path.Visible = false;
            open.Visible = false;
            run.Visible = false;
            text1.Visible = true;
            text2.Visible = true;
            //label1.Visible = true;
            //label2.Visible = true;
            label3.Visible = true;
            yuanwen.Visible = true;
            yiwen.Visible = true;
            //aaa.Visible = true;
            //bbb.Visible = true;
            offset.Visible = true;
            bianma.Visible = true;
            jiema.Visible = true;
        }

        public void hideall()
        {
            path.Visible = true;
            open.Visible = true;
            run.Visible = true;
            text1.Visible = true;
            text2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            yuanwen.Visible = true;
            yiwen.Visible = true;
            aaa.Visible = true;
            bbb.Visible = true;
            offset.Visible = false;
            bianma.Visible = false;
            jiema.Visible = false;
        }

        public int gcd(int x, int y)            //求gcd
        {
            return y == 0 ? x : gcd(y, x % y);

        }

        public bool judge(int a)                //判断一个数是否能做密钥
        {
            if (gcd(a, 26) != 1) return false;
            return true;
        }

        public void extend_eulid(int a, int b)
        {   //求逆元
            if (b == 0)
            {
                x = 1;
                y = 0;
            }
            else
            {
                extend_eulid(b, a % b);
                int temp = x;
                x = y;
                y = temp - a / b * y;
            }
        }

        public void showalpha(string texts)                 //统计字符函数
        {
            dataGridView1.Rows.Clear();
            var dic = new Dictionary<char, int>();
            var text = texts;
            foreach (var ch in text.Where(ch => (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z')))
            {
                if (dic.ContainsKey(ch))
                {
                    dic[ch]++;
                }
                else
                {
                    dic[ch] = 1;
                }
            }
            int total = text.Length;
            foreach (var pair in dic)
            {
                var row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = pair.Key });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = pair.Value * 1.0 / ((double)total) * 100 });
                dataGridView1.Rows.Add(row);
            }
        }

        private void bianma_Click(object sender, EventArgs e)       //加密按钮触发函数
        {
            Button bt1 = (Button)sender;
            if (yuanwen.Text == "")
            {
                yuanwen.Text = "请输入a~z";
                return;
            }
            string a = yuanwen.Text;
            int aa = (int)aaa.Value;
            int bb = (int)bbb.Value;
            int off = (int)offset.Value;
            for (int i = 0; i < a.Length; i++)              //判断输入
            {
                if (a[i] != ' ' && (a[i] < 'a' || a[i] > 'z'))
                {
                    yuanwen.Text = "请输入a~z";
                    return;
                }
            }

            yiwen.Text = "";
            int cnt = 0;
            for (int i = 0; i < a.Length; i++)              //加密
            {
                if (a[i] == ' ') yiwen.Text += ' ';
                /*else yiwen.Text += (char)( 'a'+((a[i] - 'a') * getnum(aa) + getnum(bb))%26);*/
                else
                {
                    if (off != 0 && i % off == 0 && i != 0) cnt++;
                    yiwen.Text += (char)('A' + ((a[i] - 'a') * aa + bb + cnt) % 26);
                }
            }
        }

        private void jiema_Click(object sender, EventArgs e)    //解密函数
        {
            Button bt1 = (Button)sender;
            if (yiwen.Text == "")
            {
                yiwen.Text = "请输入A~Z";
                return;
            }
            string a = yiwen.Text;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != ' ' && (a[i] < 'A' || a[i] > 'Z'))
                {
                    yiwen.Text = "请输入A~Z";
                    return;
                }
            }
            yuanwen.Text = "";
            int aa = (int)aaa.Value;
            int bb = (int)bbb.Value;
            extend_eulid(aa, 26);
            int xx = x;
            if (xx < 0) xx += 26;
            int yy = bb;
            int off = (int)offset.Value;
            int cnt = 0;
            for (int i = 0; i < a.Length; i++)              //解密
            {
                if (a[i] == ' ') yuanwen.Text += ' ';
                else
                {
                    if (off != 0 && i % off == 0 && i != 0) cnt++;
                    int q = (int)a[i] - 'A';
                    q = xx * (q - yy - cnt + 26) % 26;
                    while (q < 0) q += 26;
                    yuanwen.Text += (char)(q + 'a');
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void yuanwen_TextChanged(object sender, EventArgs e)        //原文输入统计字符
        {
            showalpha(yuanwen.Text);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void yiwen_TextChanged(object sender, EventArgs e)      //译文输入统计字符
        {
            showalpha(yiwen.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kaisa_CheckedChanged_1(object sender, EventArgs e)     //选择框 
        {
            showall();
            aaa.Value = 1;
            aaa.Visible = false;
            label1.Visible = false;
            offset.Visible = true;
            label3.Visible = true;
        }

        private void fangshe_CheckedChanged_1(object sender, EventArgs e)   //选择框
        {
            showall();
            aaa.Value = 0;
            aaa.Visible = true;
            label1.Visible = true;
            offset.Visible = false;
            offset.Value = 0;
            label3.Visible = false;
        }

        private void offset_ValueChanged(object sender, EventArgs e)
        {

        }

        private void wenjian_CheckedChanged(object sender, EventArgs e)
        {
            hideall();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void open_Click(object sender, EventArgs e)
        {
            //选择文件框 对象
            ofd = new OpenFileDialog();
            ofd.Filter = "文本文件|*.txt";
            //打开时指定默认路径
            ofd.InitialDirectory = @"C:\Documents and Settings\Administrator.ICBCOA-6E96E6BE\桌面";
            //如果用户点击确定
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //将用户选择的文件路径 显示 在文本框中
                path.Text = ofd.FileName;

            }
        }

        private void run_Click(object sender, EventArgs e)
        {
            string texts = "";
            StreamReader sr = File.OpenText(ofd.FileName);
            alp[] alpha = new alp[200];
            for (int i = 0; i < 200; i++)
            {
                alpha[i].a = (char)i;
                alpha[i].x = 0;
            }
            while (sr.EndOfStream != true)
            {
                string getss = sr.ReadLine();
                texts += getss;
                for (int i = 0; i < getss.Length; i++)
                {
                    if (getss[i] < 'A' || getss[i] > 'Z') continue;
                    alpha[getss[i]].x++;
                }
            }
            for (int i = 199; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (alpha[j].x > alpha[j - 1].x)
                    {
                        alp ss = alpha[j];
                        alpha[j] = alpha[j - 1];
                        alpha[j - 1] = ss;
                    }
                }
            }
            int flag1 = 0, flag2 = 1;
            int s1 = 4;
            int s2 = 19;
            int cnt = 0;
            x = 0;
            y = 0;
            int[] xxx = new int[30];
            int[] yyy = new int[30];
            /********************************************/
            showalpha(texts);
            /********************************************/
            do
            {
                if (flag2 > 25) break;
                int ds = s2 - s1;
                int dt = alpha[flag2].a - alpha[flag1].a;
                while (dt < 0) dt += 26;
                extend_eulid(ds, 26);
                if (x < 0) x += 26;
                x = x * dt % 26;
                y = alpha[flag1].a - 'A' - s1 * x;
                while (y < 0) y += 26;
                if (gcd(x, 26) == 1)
                {
                    xxx[cnt] = x;
                    yyy[cnt] = y;
                    cnt++;
                }
                flag2++;
            } while (true);
            /***********************************/
            aaa.Value = bbb.Value = 0;
            string ans = "";
            if (cnt == 0) ans = "can not get it\n";
            else for (int w = 0; w < cnt; w++ )
            {
                int aa = xxx[w];
                int bb = yyy[w];
                ans += "a:" + xxx[w].ToString() + " b:" + yyy[w].ToString()+"\n";
                extend_eulid(aa, 26);
                int xx = x;
                if (xx < 0) xx += 26;
                int yy = bb;
                for (int i = 0; i < texts.Length; i++)              //解密
                {
                    if (texts[i] == ' ') ans += ' ';
                    else
                    {
                        int q = (int)texts[i] - 'A';
                        q = xx * (q - yy + 26) % 26;
                        while (q < 0) q += 26;
                        ans += (char)(q + 'a');
                    }
                }
                ans += "\n";
            }
            yuanwen.Text = texts;
            yiwen.Text = ans;
            /*************************************/
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "文本文件|*.txt";
            Path.GetDirectoryName(ofd.FileName);
            string savepath = Path.GetDirectoryName(ofd.FileName);
            savepath += "\\解密.txt";
            FileStream fs1 = new FileStream(savepath, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter m_streamWriter = new StreamWriter(fs1);
            m_streamWriter.Write(ans);
            m_streamWriter.Close();
            sr.Close();
            string ofdpath = ofd.FileName;
            //ofd.Reset();
            if (File.Exists(ofdpath))
            {
                //如果存在则删除
                File.Delete(ofdpath);
            }
            MessageBox.Show("解密文件已输出至源目录,源文件已删除", "success");
        }

    }
}
