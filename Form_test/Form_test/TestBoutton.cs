using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_test
{
    internal class TestBoutton : Button
    {
        
        //on赤
        private Color _onColor = Color.Red;
        //off白
        private Color _offColor = Color.White;
        //変数
        private bool _enable;

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

        public TestBoutton(Point position,Size size,string text)
        {
            //ボタンの位置
            Location = position;
            //ボタンの大きさ
            Size = size;
            //
            Text = text;

            SetEnable(false);


            Click += ClickEvent;
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            SetEnable(!_enable);

        }
    }
}
