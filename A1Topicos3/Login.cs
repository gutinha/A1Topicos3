using A1Topicos3.FormsUsuario.CadastrarUsuario;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage lp = new LoginPage();
            lp.Show();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            CadUsuario1 cadUsuario1 = new CadUsuario1();
            cadUsuario1.Show();
            Hide();
        }
    }
}
