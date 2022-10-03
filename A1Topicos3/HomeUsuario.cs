using A1Topicos3.Model;
using A1Topicos3.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1Topicos3
{
    public partial class HomeUsuario : Form
    {
        public HomeUsuario()
        {
            InitializeComponent();
        }

        private void HomeUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utils.logSair();
            Application.OpenForms["Login"].Close();

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }
    }
}
