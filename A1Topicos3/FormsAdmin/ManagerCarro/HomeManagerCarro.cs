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

namespace A1Topicos3.FormsAdmin.ManagerCarro
{
    public partial class HomeManagerCarro : Form
    {
        public HomeManagerCarro()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeAdmin homeAdmin = new HomeAdmin();
            homeAdmin.Show();
            Hide();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void btCadastrarCarro_Click(object sender, EventArgs e)
        {
            CadCarro cadastrarCarro = new CadCarro();
            cadastrarCarro.Show();
        }

        private void HomeManagerCarro_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeAdmin homeAdmin = new HomeAdmin();
            homeAdmin.Show();
        }
    }
}
