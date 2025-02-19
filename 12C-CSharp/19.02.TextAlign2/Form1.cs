using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAlign2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSzoveg_MouseClick(object sender, MouseEventArgs e)
        {
            int n = e.X / (lblSzoveg.Width / 3);
            int m = e.Y / (lblSzoveg.Height / 3);
            switch(m*3 + n)
            {
                case 0: lblSzoveg.TextAlign = ContentAlignment.TopLeft;break;
                case 1: lblSzoveg.TextAlign = ContentAlignment.TopCenter;break;
                case 2: lblSzoveg.TextAlign = ContentAlignment.TopRight;break;
                case 3: lblSzoveg.TextAlign = ContentAlignment.MiddleLeft;break;
                case 4: lblSzoveg.TextAlign = ContentAlignment.MiddleCenter;break;
                case 5: lblSzoveg.TextAlign = ContentAlignment.MiddleRight;break;
                case 6: lblSzoveg.TextAlign = ContentAlignment.BottomLeft;break;
                case 7: lblSzoveg.TextAlign = ContentAlignment.BottomCenter;break;
                case 8: lblSzoveg.TextAlign = ContentAlignment.BottomRight;break;
            }
        }
    }
}
