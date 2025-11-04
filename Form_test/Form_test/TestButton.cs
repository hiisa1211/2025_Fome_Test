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

        private Form1 _form1;

        public TestButton(Form1 form1, Point position, Size size, string text)
        {
            //Form1の参照
            _form1 = form1;
            //ボタンの位置
            Location = position;
            //ボタンの大きさ
            Size = size;
            //
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
            _form1.GetTestButton(1,1).SetEnable(!_enable);

        }
    }
}
