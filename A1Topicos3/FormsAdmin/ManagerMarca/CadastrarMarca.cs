using A1Topicos3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1Topicos3.FormsAdmin
{
    public partial class CadastrarMarca : Form
    {
        public CadastrarMarca()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            dbContext db = new dbContext();
            var exist = db.Marca.Where(x => x.nome.Contains(txtNome.Text));
            if (String.IsNullOrEmpty(txtDescricao.Text) || String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("O nome ou descrição está vazio!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (exist.Count() != 0)
            {
                MessageBox.Show("Essa marca já está cadastrada","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string fileName = System.IO.Path.GetFileName(openFileDialog.FileName);
                    if (fileName == null)
                    {
                        MessageBox.Show("Salvando sem foto");
                        db.Marca.Add(new Marca(txtNome.Text, txtDescricao.Text, "null"));
                    }
                    else
                    {
                        db.Marca.Add(new Marca(txtNome.Text, txtDescricao.Text, "\\Document\\" + fileName));
                        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        System.IO.File.Copy(openFileDialog.FileName, path + "\\Document\\" + fileName);
                    }

                    db.LogSystem.Add(new LogSystem(DateTime.Now, "Admin cadastrou uma marca", Const.usuarioLogado.nome + " Id: " + Const.usuarioLogado.id));
                    db.SaveChanges();
                    MessageBox.Show("Marca cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    db.LogSystem.Add(new LogSystem(DateTime.Now, ex.Message, Const.usuarioLogado.nome + " Id:" + Const.usuarioLogado.id));
                    MessageBox.Show("Procure o administrador!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db.SaveChanges();
                }
            }
        }

        private void buttonIMG_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "C://Desktop";
            openFileDialog.Title = "Selecione a logo da marca.";
            openFileDialog.Filter = "Selecione um tipo válido(*.png; *.jpeg; *.ico)|*.png; *.jpeg; *.ico";
            openFileDialog.FilterIndex = 1;
            try
            {
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog.FileName);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, envie uma logo");
                }
            } catch (Exception)
            {
                MessageBox.Show("Erro ao enviar a imagem!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
