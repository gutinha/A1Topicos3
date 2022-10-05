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

namespace A1Topicos3.FormsAdmin.ManagerAdmin.EditUser
{
    public partial class EditUser3 : Form
    {
        public EditUser3()
        {
            InitializeComponent();
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
            else
            {
                try
                {
                    Const.editUser.email = txtEmail.Text;
                    Const.editUser.senha = txtSenha.Text;
                    db.Entry(Const.editUser).State = System.Data.Entity.EntityState.Modified;
                    db.LogSystem.Add(new LogSystem(DateTime.Now, "Usuário editado com sucesso", Const.usuarioLogado.nome + " Id:" + Const.usuarioLogado.id));
                    db.SaveChanges();
                    MessageBox.Show("Usuário editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao salvar, procure o administrador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
