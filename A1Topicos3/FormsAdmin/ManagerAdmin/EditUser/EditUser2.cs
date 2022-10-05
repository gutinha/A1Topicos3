using A1Topicos3.FormsAdmin.ManagerAdmin;
using A1Topicos3.FormsAdmin.ManagerAdmin.EditUser;
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

namespace A1Topicos3.FormsAdmin.ManagerAdmin
{
    public partial class EditUser2 : Form
    {
        public EditUser2()
        {
            InitializeComponent();
            txtCEP.Text = Const.editUser.Endereco.First().cep;
            txtEndereco.Text = Const.editUser.Endereco.First().endereco1;
            txtNumero.Text = Const.editUser.Endereco.First().numero.ToString();
            txtComplemento.Text = Const.editUser.Endereco.First().complemento;
            txtBairro.Text = Const.editUser.Endereco.First().bairro;
            txtCidade.Text = Const.editUser.Endereco.First().cidade;
            txtEstado.Text = Const.editUser.Endereco.First().estado;
            
        }
        dbContext db = new dbContext();

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
            if (String.IsNullOrEmpty(txtNumero.Text))
            {
                txtNumero.Text = "0";
            }
            var end = new Endereco(txtEndereco.Text, Convert.ToInt16(txtNumero.Text), txtComplemento.Text, txtBairro.Text, txtCidade.Text, txtEstado.Text, txtCEP.Text, Const.editUser.id);
            try
            {


                db.Entry(end).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                EditUser3 editUser3 = new EditUser3();
                editUser3.Show();
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao editar o endereço");
            }
        }
    }
}
