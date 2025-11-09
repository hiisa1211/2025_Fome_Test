using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Form_test
{
    public class TestButton : Button
    {
        
        //on赤
        private Color _onColor = Color.Red;
        //off白
        private Color _offColor = Color.White;
        //変数
        private bool _enable;
        //formの参照
        private Form1 _form1;

        //横位置
        private int _x;
        //縦位置
        private int _y;
        public TestButton(Form1 form1, int x,int y, Size size, string text)
        {
            //Form1の参照
            _form1 = form1;
            //横の位置を保管
            _x = x;
            //縦の位置を保管
            _y = y;
            //ボタンの位置
            Location = new Point(x*size.Width,y*size.Height);
            //ボタンの大きさ
            Size = size;
            //文字
            Text = text;

            //SetEnable(false);


            Click += ClickEvent;
        }
        public void SetEnable(bool on)
        {
            _enable = on;
            if (on)
            {
                BackColor =_onColor;
            }
            else
            {
                BackColor = _offColor;
            }
        }

        public void Toggle()
        {
            SetEnable(!_enable);
        }


        private void ClickEvent(object sender, EventArgs e)
        {
            //楽な書方
            //_form1.GetTestButton(_x._y)?.Toggli();

            //かっこいい書き方
            for (int i = 0; i < _toggleData.Length; i++)
            {
                var data = _toggleData[i];
                var button = _form1.GetTestButton(_x + data[0], _y + data[1]);
                if (button != null)
                {
                    button.Toggle();
                }
            }
            bool g1 = true;
            bool g2 = true;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    var btn = _form1.GetTestButton(x, y);
                    if (btn.BackColor != _onColor) g1 = false;
                    if (btn.BackColor != _offColor) g2 = false;

                }
            }
            if (g1 == true || g2 == true)
            {
                var result = MessageBox.Show("クリアしました！もう一度チャレンジしますか？", "ゲームクリア", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    _form1.ResetGame(); // 再スタート
                }
                else
                {
                    Application.Exit(); // アプリケーションを終了
                }



            }

        }
        public void CuriaButton( Size size, string text)
        {

            Click += ClickEvent1;
        }
        private void ClickEvent1(object sender, EventArgs e)
        {
             //Form(); // ← ボタンを押したら初期化処理を再実行
        }



        private int[][] _toggleData =
        {
            new int[] {0,0},
            new int[] {1, 0 },
            new int[] {-1, 0 },
            new int[] {0, 1 },
            new int[] {0, -1 },

        };
    }
}
