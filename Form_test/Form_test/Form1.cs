using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Form_test
{
    public partial class Form1 : Form
    {
        //constをつけると初期化時のみ値の変更が可能になる
        const int BUTTON_SIZE_X = 100;
        const int BUTTON_SIZE_Y = 100;

        const int BOARD_SIZE_X = 3;
        const int BOARD_SIZE_Y = 3;

        private TestBoutton[,] _buttonArray;


        public Form1()
        {

            InitializeComponent();
            _buttonArray = new TestBoutton[BOARD_SIZE_Y, BOARD_SIZE_X];
            for (int i = 0; i < BOARD_SIZE_X; i++)
            {
                for (int j = 0; j < BOARD_SIZE_Y; j++)
                {

                    //インスタンスの生成
                    TestBoutton testBoutton = new TestBoutton(new Point(BUTTON_SIZE_X * i, BUTTON_SIZE_Y * j)
                        , new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y), "");

                    _buttonArray[j, i] = testBoutton;

                    //コントロールにボタンを追加
                    Controls.Add(testBoutton);
                }
            }
            _buttonArray[1, 1].SetEnable(true);

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
