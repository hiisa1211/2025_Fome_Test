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
                    TestBoutton testBoutton = new TestBoutton(new Point(50 * j, 50 * i), new Size(50, 50),"あ");


                    //コントロールにボタンを追加
                    Controls.Add(testBoutton);
                }
            }


        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            MessageBox.Show("クリック");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
