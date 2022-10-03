using A1Topicos3.FormsAdmin.ManagerAdmin;
using A1Topicos3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1Topicos3.FormsAdmin.Cadastrar_Admin
{
    public partial class CadAdmin : Form
    {
        dbContext db = new dbContext();
        public CadAdmin()
        {
            InitializeComponent();
        }

        private void CadAdmin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Usuario.Where(x => x.ativo == true).ToList();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            CadAdmin1 cad = new CadAdmin1();
            cad.Show();
        }

        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Usuario.Where(x => x.nome.Contains(txtProcurar.Text) || x.email.Contains(txtProcurar.Text)).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.RowIndex >= 0)
                {
                    var idUsuario = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    var condicao = !(bool)dataGridView1.Rows[e.RowIndex].Cells[3].Value;

                    if (MessageBox.Show("Você tem certeza que deseja " + (condicao ? "adicionar" : "remover") + " a permissão deste usuário?",
                        "Confirmação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            var user = db.Usuario.Where(x => x.id == idUsuario).First();
                            if (Const.usuarioLogado.id == user.id)
                            {
                                MessageBox.Show("Você não pode editar você mesmo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                user.admin = !user.admin;
                                db.Entry(user).State = EntityState.Modified;
                                db.Log.Add(new Log(DateTime.Now, "Usuário " + Const.usuarioLogado.nome + " com id: " + Const.usuarioLogado.id + " " +
                                    (condicao ? "adicionou" : "removeu" + " a permissão do usuário " + user.nome + " com id: " + user.id),
                                    Const.usuarioLogado.nome + " Id: " + Const.usuarioLogado.id));
                                db.SaveChanges();
                                MessageBox.Show("Permissão admin " + (condicao ? "adicionada" : "removida" + " com sucesso"), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Erro ao alterar");
                        }

                    }

                    if (e.ColumnIndex == 4)
                    {
                        if (e.RowIndex >= 0)
                        {
                            idUsuario = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                            condicao = !(bool)dataGridView1.Rows[e.RowIndex].Cells[4].Value;

                            if (MessageBox.Show("Você tem certeza que deseja " + (condicao ? "ativar" : "desativar") + " este usuário?",
                                "Confirmação",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                try
                                {
                                    var user = db.Usuario.Where(x => x.id == idUsuario).First();
                                    if (Const.usuarioLogado.id == user.id)
                                    {
                                        MessageBox.Show("Você não pode editar você mesmo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        user.ativo = !user.ativo;
                                        db.Entry(user).State = EntityState.Modified;
                                        db.Log.Add(new Log(DateTime.Now, "Usuário " + Const.usuarioLogado.nome + " com id: " + Const.usuarioLogado.id + " " +
                                            (condicao ? "ativou" : "desativou" + " o usuário " + user.nome + " com id: " + user.id),
                                            Const.usuarioLogado.nome + " Id: " + Const.usuarioLogado.id));
                                        db.SaveChanges();
                                        MessageBox.Show("Usuário " + (condicao ? "ativado" : "desativado" + " com sucesso"), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Erro ao alterar");
                                }
                            }
                        }
                    }
                    if(e.ColumnIndex == 5)
                    {
                        if(e.RowIndex >= 0)
                        {
                            idUsuario = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                            var userEdit = db.Usuario.Where(x => x.id == idUsuario).First();
                            EditUser user = new EditUser(userEdit);
                            user.Show();
                            
                        }
                    }
                }
            }
        }
    }
}
