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
using System.Text.RegularExpressions;

namespace 单词记忆
{
    public partial class Form1 : Form
    {
        int number = 0;//光标
        List<string> UnRemDic = new List<string>();//未记忆的单词&&&&注释
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            //1、读取未记忆单词
            string str_words = File.ReadAllText("unremember.txt",Encoding.Default);
            string[] words = Regex.Split(str_words, "\r\n");
            WordLabel.Text = Regex.Split(words[number]," ")[0];
            DetailLabel.Text = words[number].Replace(WordLabel.Text, string.Empty);
            DetailLabel.Hide();
        }

        private void ShowAnswerButton_Click(object sender, EventArgs e)
        {
            DetailLabel.Show();
        }

        private void RememberButton_Click(object sender, EventArgs e)
        {
            string str_words = File.ReadAllText("unremember.txt", Encoding.Default);
            string[] words = Regex.Split(str_words, "\r\n");
            str_words = str_words.Replace(WordLabel.Text+DetailLabel.Text+"\r\n", string.Empty);
            File.AppendAllText("remember.txt", WordLabel.Text + DetailLabel.Text + "\r\n", Encoding.Default);
            File.WriteAllText("unremember.txt", str_words,Encoding.Default);
            string s = File.ReadAllText("unremember.txt");
            int LeftWords = (s.Length - s.Replace("\r\n", string.Empty).Length) / 4;
            LeftWordsLabel.Text = "剩余单词:" + LeftWords;
            str_words = File.ReadAllText("unremember.txt", Encoding.Default);
            words = Regex.Split(str_words, "\r\n");
            #region 随机单词
            Random r = new Random();
            number = r.Next(words.Length - 1);
            #endregion
            WordLabel.Text = Regex.Split(words[number], " ")[0];
            DetailLabel.Text = words[number].Replace(WordLabel.Text, string.Empty);
            DetailLabel.Hide();
        }
        int UnRemNumber = 0;
        private void button1_Click(object sender, EventArgs e)
        {
           // number++;
            //if (number >= 10) number = 0;
            //若未记单词满10个，则只复习未记忆的单词(调用UnRemNumber)
            if (UnRemDic.Count >= 11)
            {
                if (UnRemNumber >= UnRemDic.Count - 1) UnRemNumber = 0;
                string[] WordArray = Regex.Split(UnRemDic[UnRemNumber ],"&&&&");
                WordLabel.Text = WordArray[0];
                DetailLabel.Text = WordArray[1];
                UnRemNumber++;
            }
            else
            {
                //否则 随机获取下一个单词，并且将单词该未记忆单词放入UnRemDic
                UnRemDic.Add(WordLabel.Text+"&&&&"+ DetailLabel.Text);
                string str_words = File.ReadAllText("unremember.txt", Encoding.Default);
                string[] words = Regex.Split(str_words, "\r\n");
                #region 随机单词
                Random r = new Random();
                number = r.Next(words.Length - 1);
                #endregion
                WordLabel.Text = Regex.Split(words[number], " ")[0];
                DetailLabel.Text = words[number].Replace(WordLabel.Text, string.Empty);
                DetailLabel.Hide();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            string str_RememWords = File.ReadAllText("remember.txt", Encoding.Default);
            string[] words = Regex.Split(str_RememWords, "\r\n");
            foreach (string i in words)
            {
                if (i == string.Empty) continue;
                ListViewItem item = new ListViewItem();
                item.Text = Regex.Split(i, " ")[0];
                item.SubItems.Add(i.Replace(item.Text, string.Empty));
                listView1.Items.Add(item);
            }
       }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode);
            switch (e.KeyCode)
            {
                case Keys.W:
                {
                        button1_Click(null, null);
                        break;
                }
                case Keys.Space:
               {
                        ShowAnswerButton_Click(null, null);
                        break;
               }
              case Keys.Return:
               {
                        RememberButton_Click(null, null);
                        break;
               }
            }
        }

        private void tabPage1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Console.WriteLine(e.KeyCode.ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://youdao.com/w/eng/"+WordLabel.Text);
        }
    }
}
