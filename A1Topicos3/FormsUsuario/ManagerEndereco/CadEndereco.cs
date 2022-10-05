using A1Topicos3.Model;
using System;
using System.Windows.Forms;

namespace A1Topicos3.FormsUsuario.CadastrarEndereco
{
    public partial class CadEndereco : Form
    {
        public CadEndereco()
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

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            dbContext db = new dbContext();
            if (String.IsNullOrEmpty(txtNumero.Text))
            {
                txtNumero.Text = "0";
            }
            var a = new Endereco(txtEndereco.Text, Convert.ToInt16(txtNumero.Text), txtComplemento.Text, txtBairro.Text, txtCidade.Text, txtEstado.Text, txtCEP.Text, Const.usuarioLogado.id);
            Const.usuarioLogado.Endereco.Add(a); //Controle caso o usuário seja editado não perder dados
            try
            {
                db.Endereco.Add(a);
                db.SaveChanges();
                MessageBox.Show("Endereço adicionado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar");
                try
                {
                    db.LogSystem.Add(new LogSystem(DateTime.Now, ex.Message, Const.usuarioLogado.nome + " Id: " + Const.usuarioLogado.id));
                    db.SaveChanges();
                } catch (Exception)
                {
                    MessageBox.Show("Aconteceu algo bizarro, chama o ademiro");
                }
            }
        }
    }
}
