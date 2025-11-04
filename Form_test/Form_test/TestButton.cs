using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            SetEnable(false);


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

        
        private void ClickEvent(object sender, EventArgs e)
        {
            _form1.GetTestButton(_x,_y).SetEnable(!_enable);

        }
    }
}
