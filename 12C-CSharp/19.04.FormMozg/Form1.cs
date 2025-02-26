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

        private double opValtoz = 0.2;

        private void btnFel_Click(object sender, EventArgs e)
        {
            //A formot felfele visszük valtMagas értékkel, ha nem lép ki a képernyőröl,
            //egyébként pedig a képernyő tetejére visszük
            Location = new Point(Location.X, (Location.Y - valtMagas) <= 0 ? 0 : Location.Y - valtMagas);
        }

        private void btnKozep_Click(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            //A formot lefele visszük valtMagas értékkel, ha nem lép ki a képernyőröl,
            //egyébként pedig a képernyő aljára visszük
            Location = new Point(Location.X, (Location.Y + Height + valtMagas) >= Screen.GetWorkingArea(this).Height ? Screen.GetWorkingArea(this).Height - Height : Location.Y + valtMagas);
        }

        private void btnAlul_Click(object sender, EventArgs e)
        {
            // A formot alulra visszük
            Location = new Point(Location.X, Screen.GetWorkingArea(this).Height - Height);
        }

        private void btnBalszel_Click(object sender, EventArgs e)
        {
            // A formot balszélre visszük
            Location = new Point(0, Location.Y);
        }

        private void btnBalra_Click(object sender, EventArgs e)
        {
            // A formot balra visszük
            Location = new Point(Location.X - valtSzeles < 0 ? 0 : Location.X - valtSzeles, Location.Y);
        }

        private void btnJobb_Click(object sender, EventArgs e)
        {
            // Jobbra visszük a formot
            // ha kimenne a képernyőről, akkor a jobb szélre illesztjük
            Location = new Point(Location.X + Width + valtSzeles >= Screen.PrimaryScreen.Bounds.Width ? Screen.PrimaryScreen.Bounds.Width - Width : Location.X + valtSzeles, Location.Y);
        }

        private void btnJobbszel_Click(object sender, EventArgs e)
        {
            // A formot a jobbszélre illesztjük
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - Width, Location.Y);
        }

        private void btnOpNo_Click(object sender, EventArgs e)
        {
            // Az átlátszóságot növeljük
            Opacity += opValtoz;
        }

        private void btnOpCsok_Click(object sender, EventArgs e)
        {
            // Az átlátszóságot csökkentjük
            Opacity -= opValtoz;
        }

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
            //Opacity = 0.5;
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
