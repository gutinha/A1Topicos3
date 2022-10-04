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
    public partial class CadUsuario1 : Form
    {
        public CadUsuario1()
        {
            InitializeComponent();
            cbPF.Checked = true;
            lbNomeFantasia.Hide();
            lbCNPJ.Hide();
            maskCNPJ.Hide();
            labelDataFundacao.Hide();
            dateDataFundacao.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Const.cadUsuario = null;
            Application.OpenForms["Login"].Show();
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void CadUsuario1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["Login"].Show();
        }

        private void cbPJ_Click_1(object sender, EventArgs e)
        {
            if (Const.cadUsuario.cpf != null)
            {
                MessageBox.Show("Você não pode alterar depois de ter iniciado o cadastro, feche o formulário e abra novamente caso queira alterar",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbPF.Checked = true;
            }
            else
            {
                lbCNPJ.Show();
                maskCNPJ.Show();
                labelDataFundacao.Show();
                dateDataFundacao.Show();
                labelCPF.Hide();
                lbNomeFantasia.Show();
                labelNome.Hide();
                labelDataNascimento.Hide();
                labelRG.Hide();
                maskCPF.Hide();
                maskRG.Hide();
                dateNascimento.Hide();
            }
        }

        private void cbPF_Click_1(object sender, EventArgs e)
        {
            if (Const.cadUsuario.cnpj != null)
            {
                MessageBox.Show("Você não pode alterar depois de ter iniciado o cadastro, feche o formulário e abra novamente caso queira alterar",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbPJ.Checked = true;
            }
            else
            {
                labelNome.Show();
                labelCPF.Show();
                maskCPF.Show();
                labelRG.Show();
                maskRG.Show();
                lbCNPJ.Hide();
                labelDataFundacao.Hide();
                dateDataFundacao.Hide();
                lbNomeFantasia.Hide();
                maskCNPJ.Hide();
                dateNascimento.Show();
                labelDataNascimento.Show();
            }
        }

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            if (Const.cadUsuario.nome != null)
            {
                CadUsuario2 cadUsuario2 = new CadUsuario2();
                cadUsuario2.Show();
                Hide();
            }
            else if (cbPF.Checked)
            {
                //Get the DateTime and convert to int the values
                var data = dateNascimento.Text;
                var Adata = data.Split('/');
                var dia = Convert.ToInt16(Adata[0]);
                var mes = Convert.ToInt16(Adata[1]);
                var ano = Convert.ToInt16(Adata[2]);

                Const.cadUsuario.dataNascimento = new DateTime(ano, mes, dia);
                Const.cadUsuario.nome = txtNome.Text;
                Const.cadUsuario.rg = maskRG.Text;
                Const.cadUsuario.cpf = maskCPF.Text;
                CadUsuario2 cadUsuario = new CadUsuario2();
                cadUsuario.Show();
                Hide();
            }
            else if (cbPJ.Checked)
            {
                Regex reg = new Regex(@"[0-9]{2}\.?[0-9]{3}\.?[0-9]{3}\/?[0-9]{4}\-?[0-9]{2}");
                if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(maskCNPJ.Text))
                {
                    MessageBox.Show("Preencha o nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (!reg.IsMatch(maskCNPJ.Text))
                {
                    MessageBox.Show("CNPJ inválido");
                }
                else
                {
                    var data = dateDataFundacao.Text;
                    var Adata = data.Split('/');
                    var dia = Convert.ToInt16(Adata[0]);
                    var mes = Convert.ToInt16(Adata[1]);
                    var ano = Convert.ToInt16(Adata[2]);
                    Const.cadUsuario.nome = txtNome.Text;
                    Const.cadUsuario.cnpj = maskCNPJ.Text;
                    Const.cadUsuario.dataNascimento = new DateTime(ano, mes, dia);
                    CadUsuario2 cadUsuario = new CadUsuario2();
                    cadUsuario.Show();
                    Hide();
                }
            }
        }

        private void CadUsuario1_Load(object sender, EventArgs e)
        {
            if(Const.cadUsuario == null)
            {
                Const.cadUsuario = new Usuario();
            }
            if (Const.cadUsuario.nome != null && Const.cadUsuario.cnpj != null)
            {
                cbPJ.Checked = true;
                txtNome.Text = Const.cadUsuario.nome;
                maskCNPJ.Text = Const.cadUsuario.cnpj;
                
            }
            else if (Const.cadUsuario.nome != null && Const.cadUsuario.cpf != null)
            {
                cbPF.Checked = true;
                txtNome.Text = Const.cadUsuario.nome;
                maskRG.Text = Const.cadUsuario.rg;
                maskCPF.Text = Const.cadUsuario.cpf;
                dateNascimento.Text = Const.cadUsuario.dataNascimento.ToString();
            }
            dateNascimento.Format = DateTimePickerFormat.Custom;
            dateNascimento.CustomFormat = "dd/MM/yyyy";
            dateDataFundacao.Format = DateTimePickerFormat.Custom;
            dateDataFundacao.CustomFormat = "dd/MM/yyyy";
        }
    }
}
