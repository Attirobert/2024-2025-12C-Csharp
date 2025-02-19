using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMozg
{
    public partial class Form1 : Form
    {
        // Osztályváltozók
        private int valtMagas = 10,
            valtSzeles = 10,
            maxWidth = 0,
            maxHeigth = 0,
            minWidth = 0,
            minHeight = 0;

        private void btnFelul_Click(object sender, EventArgs e)
        {
            // A formot felülre visszük
            Location = new Point(Location.X, 0);
        }

        private void btnCsok_Click(object sender, EventArgs e)
        {
            // A form méretének csökkentése
            Width -= Width - valtSzeles >= minWidth ? valtSzeles : 0;

            Height -= Height - valtMagas >= minHeight ? valtMagas : 0;
        }

        public Form1()
        {
            InitializeComponent();

            // Form korlátok beállítása
            maxHeigth = Screen.GetWorkingArea(this).Height;
            maxWidth = Screen.GetWorkingArea(this).Width;
            minHeight = maxHeigth / 2;
            minWidth = maxWidth / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMeretNo_Click(object sender, EventArgs e)
        {
            // A form méretének növelése, ha belefér a képernyőbe
            if ((Location.X + Height) <= maxHeigth)
            {
                Height += valtMagas;
            }

            if ((Location.Y + Width) <= maxWidth)
            {
                Width += valtSzeles;
            }
        }
    }
}
