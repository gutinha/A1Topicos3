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
    public partial class LoginPage : Form
    {
        dbContext db = new dbContext();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            var a = db.Usuario.Where(x => x.email == email && x.senha == senha).ToList();
            var b = a.Any() ? MessageBox.Show("Redirecionando para o menu", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information) : MessageBox.Show("E-mail ou senha incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (a.Count != 0)
            {
                Const.usuarioLogado = a[0];
            }
            if (a.Count != 0 && a[0].admin)
            {
                Utils.logEntrar();
                HomeAdmin adm = new HomeAdmin();
                adm.Show();
                this.Hide();
            }
            else if (a.Count != 0)
            {
                Utils.logEntrar();
                HomeUsuario usu = new HomeUsuario();
                usu.Show();
                this.Hide();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["Login"].Close();
        }
    }
}
