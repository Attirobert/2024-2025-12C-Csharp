using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAlign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            int n = e.X / (label1.Width / 3);   // Vízszintes méret harmada
            int m = e.Y / (label1.Height / 3);  // Függőleges méret harmada

            // A képernyő 9 négyszögre van osztva és itt számolom ki, hogy hanyadik négyszögbe kattintottam
            switch (m * 3 + n)
            {
                case 0: label1.TextAlign = ContentAlignment.TopLeft; break;
                case 1: label1.TextAlign = ContentAlignment.TopCenter; break;
                case 2: label1.TextAlign = ContentAlignment.TopRight; break;
                case 3: label1.TextAlign = ContentAlignment.MiddleLeft; break;
                case 4: label1.TextAlign = ContentAlignment.MiddleCenter; break;
                case 5: label1.TextAlign = ContentAlignment.MiddleRight; break;
                case 6: label1.TextAlign = ContentAlignment.BottomLeft; break;
                case 7: label1.TextAlign = ContentAlignment.BottomCenter; break;
                case 8: label1.TextAlign = ContentAlignment.BottomRight; break;

            }
        }
    }
}
