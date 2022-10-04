using A1Topicos3.FormsAdmin;
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

namespace A1Topicos3.FormsUsuario.CadastrarUsuario
{
    public partial class CadUsuario2 : Form
    {
        public CadUsuario2()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            using (var ws = new Correios.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(txtCEP.Text);
                    txtEndereco.Text = resultado.end;
                    txtComplemento.Text = resultado.complemento2;
                    txtCidade.Text = resultado.cidade;
                    txtBairro.Text = resultado.bairro;
                    txtEstado.Text = resultado.uf;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            CadUsuario1 cadUsuario = new CadUsuario1();
            cadUsuario.Show();
            Hide();
        }

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumero.Text))
            {
                txtNumero.Text = "0";
            }
            var end = new Endereco(txtEndereco.Text, Convert.ToInt16(txtNumero.Text), txtComplemento.Text, txtBairro.Text, txtCidade.Text, txtEstado.Text, txtCEP.Text);
            Const.cadUsuario.Endereco = new List<Endereco>();
            if (Const.cadUsuario.Endereco.Contains(end))
            {
                CadUsuario3 cadUsuario = new CadUsuario3();
                cadUsuario.Show();
                this.Hide();
            }
            else if (end.cep != null)
            {
                Const.cadUsuario.Endereco.Add(end);
                CadUsuario3 cadUsuario = new CadUsuario3();
                cadUsuario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Login"].Show();
            Close();
        }

        private void CadUsuario2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Const.cadUsuario = null;
            Application.OpenForms["Login"].Show();
        }

        private void CadUsuario2_Load(object sender, EventArgs e)
        {
            try
            {
                var a = Const.cadUsuario.Endereco.First();
                if (a != null)
                {
                    txtEndereco.Text = a.endereco1;
                    txtNumero.Text = a.numero.ToString();
                    txtComplemento.Text = a.complemento;
                    txtBairro.Text = a.bairro;
                    txtCidade.Text = a.cidade;
                    txtEstado.Text = a.estado;
                    txtCEP.Text = a.cep;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
