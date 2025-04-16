using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IktatoMySql
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void beosztásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeosztasokForm frm = new BeosztasokForm();
            frm.Show();
        }

        private void osztályokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OsztalyokForm frm = new OsztalyokForm();
            frm.Show();
        }
    }
}
