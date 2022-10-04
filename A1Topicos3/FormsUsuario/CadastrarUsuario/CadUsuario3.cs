using A1Topicos3.FormsAdmin;
using A1Topicos3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1Topicos3.FormsUsuario.CadastrarUsuario
{
    public partial class CadUsuario3 : Form
    {
        public CadUsuario3()
        {
            InitializeComponent();
            buttonSalvar.Enabled = false;
        }
        public DateTime termo;
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Login"].Show();
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void CadUsuario3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Const.cadUsuario = null;
            Application.OpenForms["Login"].Show();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            CadUsuario2 cadUsuario = new CadUsuario2();
            cadUsuario.Show();
            Hide();
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
            var a = db.Usuario.Where(x => x.email == Const.cadUsuario.email).FirstOrDefault();
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
                        Const.cadUsuario.email = txtEmail.Text;
                        Const.cadUsuario.senha = txtSenha.Text;
                        Const.cadUsuario.ativo = true;
                        db.Usuario.Add(Const.cadUsuario);
                        db.Log.Add(new Log(DateTime.Now, "Usuário " + Const.cadUsuario.nome + " aceitou os termos em: " + termo.ToString(), Const.cadUsuario.nome));
                        db.LogSystem.Add(new LogSystem(DateTime.Now, "Usuário cadastrado com sucesso", Const.cadUsuario.nome));
                        db.SaveChanges();
                        MessageBox.Show("Cadastro realizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HomeUsuario homeUsuario = new HomeUsuario();
                        homeUsuario.Show();
                        Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar, procure o administrador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        try
                        {
                            db.LogSystem.Add(new LogSystem(DateTime.Now, ex.Message, Const.cadUsuario.nome));
                            db.SaveChanges();
                        } 
                        catch (Exception)
                        {
                            MessageBox.Show("Deu um erro cabuloso, chama o ademiro");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Você deve aceitar os termos de uso", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void checkTermos_Click(object sender, EventArgs e)
        {
            buttonSalvar.Enabled = checkTermos.Checked;
            if (checkTermos.Checked)
            {
                termo = DateTime.Now;
            }
        }

        private void linkTermos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deixe-me dizer-lhe algo que você já sabe. O mundo não é tudo sol e arco-íris. \r\nÉ um lugar muito mesquinho e desagradável, e eu não me importo quão durão você é, ele vai bater em você para joelhos e mantê-lo lá permanentemente se você deixar. \r\nVocê, eu, nem ninguém vai bater tão duro como a vida. \r\nMas não é sobre quão duro você bate. É sobre quão forte você pode ser atingido e continuar mexendo frente. \r\nQuanto você pode tomar, e manter movendo para a frente. Isso é como ganhando 'é feito.");
        }
    }
}
