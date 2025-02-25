using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTeszt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly int meretezo = 5;
        private readonly int mozgato = 10;

        private void btnMeretCsokken_Click(object sender, EventArgs e)
        {
            Width -= meretezo;
            Height -= meretezo;
        }

        private void btnMeretNo_Click(object sender, EventArgs e)
        {
            Width += meretezo;
            Height += meretezo;
        }

        private void btnAtlatNo_Click(object sender, EventArgs e)
        {
            if (Opacity < 1.0)
            {
                Opacity += 0.1;
            }
        }

        private void btnAtlatCsok_Click(object sender, EventArgs e)
        {
            if (Opacity > 0.2)
            {
                Opacity -= 0.1;
            }
        }

        private void btnKozepre_Click(object sender, EventArgs e)
        {
            //Top = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            //Left = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
            CenterToScreen();
            btnLe.Visible =
                btnAljara.Visible =
                btnFel.Visible =
                btnTetejere.Visible =
                btnBalszelre.Visible =
                btnJobbra.Visible =
                btnJobbszelre.Visible = true;


        }

        private void btnTetejere_Click(object sender, EventArgs e)
        {
            Top = 0;
            btnFel.Visible =
                btnTetejere.Visible = false;
            btnLe.Visible =
                btnAljara.Visible = true;
        }

        private void btnFel_Click(object sender, EventArgs e)
        {
            if (Top-meretezo>0)
            {
                Top -= meretezo;
            }
            else
            {
                Top = 0;
                btnFel.Visible =
                    btnTetejere.Visible = false;
            }

            btnLe.Visible =
                btnAljara.Visible = true;
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            if (Top < Screen.PrimaryScreen.Bounds.Height - Height)
            {
                Top += mozgato;
            }
        }

        private void btnAljara_Click(object sender, EventArgs e)
        {
            if (Top < Screen.PrimaryScreen.Bounds.Height - Height)
            {
                Top = Screen.PrimaryScreen.Bounds.Height - Height;
            }
        }

        private void btnJobbra_Click(object sender, EventArgs e)
        {
            if (Left < Screen.PrimaryScreen.Bounds.Width - Width)
            {
                Left += mozgato;
            }
        }

        private void btnJobbszelre_Click(object sender, EventArgs e)
        {
            if (Left < Screen.PrimaryScreen.Bounds.Width - Width)
            {
                Left = Screen.PrimaryScreen.Bounds.Width - Width;
            }
        }

        private void btnBalszelre_Click(object sender, EventArgs e)
        {
            Left = 0;
        }

        private void btnBalra_Click(object sender, EventArgs e)
        {
            if (Left > 0)
            {
                Left -= mozgato;
            }
        }
    }
}
