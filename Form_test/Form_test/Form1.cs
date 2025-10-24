using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Form_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for(int i=0;i<4;i++)
            {
                for (int j = 0; j < 6; j++)
                {

                    //インスタンスの生成
                    TestBoutton testBoutton = new TestBoutton();

                    //ボタンの位置を設定
                    testBoutton.Location = new Point(50 * j, 50 * i);

                    //ボタンの大きさを設定
                    testBoutton.Size = new Size(50, 50);

                    //ボタン内のテキストを追加
                    testBoutton.Text = "あいうえお";

                    //コントロールにボタンを追加
                    Controls.Add(testBoutton);
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            MessageBox.Show("C#の世界へようこそ！");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
