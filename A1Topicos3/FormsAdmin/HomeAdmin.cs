using A1Topicos3.FormsAdmin;
using A1Topicos3.FormsAdmin.Cadastrar_Admin;
using A1Topicos3.FormsAdmin.ManagerCarro;
using A1Topicos3.FormsAdmin.ManagerMarca;
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
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void HomeAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utils.logSair();
            Application.OpenForms["Login"].Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void buttonCadAdmin_Click(object sender, EventArgs e)
        {
            CadAdmin adm = new CadAdmin();
            adm.Show();
        }

        private void buttonMarca_Click(object sender, EventArgs e)
        {
            HomeManagerMarca homeMarca = new HomeManagerMarca();
            homeMarca.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btManagerCarro_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeManagerCarro managerCarro = new HomeManagerCarro();
            managerCarro.Show();
        }
    }
}
