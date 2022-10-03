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

namespace A1Topicos3.FormsAdmin.ManagerMarca
{
    public partial class HomeManagerMarca : Form
    {
        public HomeManagerMarca()
        {
            InitializeComponent();
        }

        private void btnCadastrarMarca_Click(object sender, EventArgs e)
        {
            CadastrarMarca cadastrarMarca = new CadastrarMarca();
            cadastrarMarca.Show();
        }

        private void btnConsultarMarca_Click(object sender, EventArgs e)
        {
            ProcurarMarca procurarMarca = new ProcurarMarca();
            procurarMarca.Show();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utils.logSair();
            Application.OpenForms["Login"].Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeAdmin adm = new HomeAdmin();
            adm.Show();
            Hide();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }
    }
}
