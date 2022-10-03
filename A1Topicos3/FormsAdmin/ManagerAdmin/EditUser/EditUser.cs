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
    public partial class EditUser : Form
    {
        public EditUser(Usuario usuario)
        {
            InitializeComponent();
            Const.editUser = usuario;
        }

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            if (Const.editUser.nome != null)
            {
                EditUser2 editUser2 = new EditUser2();
                editUser2.Show();
                Hide();
            }
            else
            {
                //Get the DateTime and convert to int the values
                var data = dateNascimento.Text;
                var Adata = data.Split('/');
                var dia = Convert.ToInt16(Adata[0]);
                var mes = Convert.ToInt16(Adata[1]);
                var ano = Convert.ToInt16(Adata[2]);

                Const.cadAdmin.dataNascimento = new DateTime(ano, mes, dia);
                Const.cadAdmin.nome = txtNome.Text;
                Const.cadAdmin.rg = maskRG.Text;
                Const.cadAdmin.cpf = maskCPF.Text;
                EditUser2 editUser2 = new EditUser2();
                editUser2.Show();
                Hide();
            }
        }
    }
}
