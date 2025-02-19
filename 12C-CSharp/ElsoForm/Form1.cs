using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElsoForm
{
    public partial class MainForm : Form
    {
        // Osztályváltozók
        private bool iranyFel = true,
            iranyBalra = true;
        private int lepesFel = 20,
            lepesOldalt = 30;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnKattints_Click(object sender, EventArgs e)
        {
            Point point = btnKattints.Location;

            // Megvizsgáljuk, hogy nem megyek-e ki a formból felfele és balra
            // Függőleges irányt vizsgálom
            if (this.iranyFel && (point.Y - this.lepesFel) <= 0)
            {
                // Függőleges irányt változtatok
                this.iranyFel=false;
            }
            // Vízszintes irányt vizsgálom
            if (iranyBalra && (point.X - lepesOldalt) <= 0)
            {
                // Vízszintes irányt változtatok
                iranyBalra=false;
            }

            // Megvizsgáljuk, hogy nem megyek-e ki a formból lefele és jobbra
            // Függőleges irányt vizsgálom
            if (!iranyFel && ((point.Y - btnKattints.Height) + lepesFel) <= Height)
            {
                // Függőleges irányt változtatok
                iranyFel=true;
            }
            // Vízszintes irányt vizsgálom
            if (!iranyBalra && (((point.X - btnKattints.Width) + lepesOldalt) <= Width))
            {
                // Vízszintes irányt változtatok
                iranyBalra=true;
            }

            // Beállítom a gomb pozícióját
            point.X += this.iranyBalra ? -this.lepesOldalt : this.lepesOldalt;
            point.Y += this.iranyFel ? -this.lepesFel : this.lepesFel;
            btnKattints.Location = point;
        }

        private void btnKattints_MouseHover(object sender, EventArgs e)
        {
            btnKattints.BackColor = Color.LightBlue;
        }

        private void btnKattints_MouseLeave(object sender, EventArgs e)
        {
            btnKattints.BackColor = Color.AntiqueWhite;
            btnKattints.Text = "Kattints rám!";
        }
    }
}
