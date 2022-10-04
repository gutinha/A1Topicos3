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
    public partial class CadAdmin2 : Form
    {
        public CadAdmin2()
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

        private void CadAdmin2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Const.cadAdmin = null;
        }

        private void CadAdmin2_Load(object sender, EventArgs e)
        {
            try
            {
                var a = Const.cadAdmin.Endereco.First();
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

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumero.Text))
            {
                txtNumero.Text = "0";
            }
            var end = new Endereco(txtEndereco.Text, Convert.ToInt16(txtNumero.Text), txtComplemento.Text, txtBairro.Text, txtCidade.Text, txtEstado.Text, txtCEP.Text);
            Const.cadAdmin.Endereco = new List<Endereco>();
            if (Const.cadAdmin.Endereco.Contains(end))
            {
                CadAdmin3 cadAdmin = new CadAdmin3();
                cadAdmin.Show();
                this.Hide();
            } else if (end.cep != null)
            {
                Const.cadAdmin.Endereco.Add(end);
                CadAdmin3 cadAdmin = new CadAdmin3();
                cadAdmin.Show();
                this.Hide();
            }else
            {
                    MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            CadAdmin1 cadAdmin = new CadAdmin1();
            cadAdmin.Show();
            this.Hide();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
