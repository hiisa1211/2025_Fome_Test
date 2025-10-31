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
         public TestBoutton(Point position,Size size,string text)
        {
            //ボタンの位置
            Location = position;
            //
            Size = size;
            //
            Text = text;


            Click += ClickEvent;
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            MessageBox.Show("クリックされてしまいました");

        }
    }
}
