using A1Topicos3.Model;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace A1Topicos3.FormsAdmin
{
    public partial class CadAdmin3 : Form
    {
        public CadAdmin3()
        {
            InitializeComponent();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            CadAdmin2 cadAdmin = new CadAdmin2();
            cadAdmin.Show();
            this.Hide();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            dbContext db = new dbContext();
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Email inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo Email", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(txtSenha.Text) || string.IsNullOrEmpty(txtConfirmarSenha.Text))
            {
                MessageBox.Show("O campo senha e confirmar senha não pode ser vazio", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não conferem", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                //Verify if exist user in database
                var a = db.Usuario.Where(x => x.email == Const.cadAdmin.email).FirstOrDefault();
            if (a != null)
                {
                    MessageBox.Show("Já existe um usuário com esse e-mail", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (checkTermos.Checked)
                    {
                        try
                        {
                            Const.cadAdmin.email = txtEmail.Text;
                            Const.cadAdmin.senha = txtSenha.Text;
                            Const.cadAdmin.admin = true;
                            Const.cadAdmin.ativo = true;
                            db.Usuario.Add(Const.cadAdmin);
                            db.LogSystem.Add(new LogSystem(DateTime.Now, "Admin cadastrado com sucesso", Const.usuarioLogado.nome + " Id:" + Const.usuarioLogado.id));
                            db.SaveChanges();
                            MessageBox.Show("Admin cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Erro ao salvar, procure o administrador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                         MessageBox.Show("Você deve aceitar os termos de uso", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
        }

        private void CadAdmin3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Const.cadAdmin = null;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
