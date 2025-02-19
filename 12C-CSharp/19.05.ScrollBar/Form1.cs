using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void scbPiros_ValueChanged(object sender, EventArgs e)
        {
            lblNegyzet.BackColor = Color.FromArgb(scbPiros.Value, scbZold.Value, scbKek.Value);
        }

        private void scbKek_ValueChanged(object sender, EventArgs e)
        {
            lblNegyzet.BackColor = Color.FromArgb(scbPiros.Value, scbZold.Value, scbKek.Value);
        }

        private void scbZold_ValueChanged(object sender, EventArgs e)
        {
            lblNegyzet.BackColor = Color.FromArgb(scbPiros.Value, scbZold.Value, scbKek.Value);
        }

        private void scbOldalHossz_ValueChanged(object sender, EventArgs e)
        {
            lblNegyzet.Width = lblNegyzet.Height = scbOldalHossz.Value;
            lblHossz.Text = scbOldalHossz.Value.ToString();
        }
    }
}
