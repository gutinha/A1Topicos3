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
using static System.Net.Mime.MediaTypeNames;

namespace A1Topicos3.FormsAdmin
{
    public partial class CadAdmin1 : Form
    {
        public CadAdmin1()
        {
            InitializeComponent();
        }

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            if (Const.cadAdmin.nome != null)
            {
                CadAdmin2 cadAdmin2 = new CadAdmin2();
                cadAdmin2.Show();
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
                CadAdmin2 cadAdmin = new CadAdmin2();
                cadAdmin.Show();
                Hide();
            }
        }

        private void CadastrarNovoAdmin_Load(object sender, EventArgs e)
        {
            if (Const.cadAdmin.nome != null)
            {
                    txtNome.Text = Const.cadAdmin.nome;
                    maskRG.Text = Const.cadAdmin.rg;
                    maskCPF.Text = Const.cadAdmin.cpf;
                    dateNascimento.Text = Const.cadAdmin.dataNascimento.ToString();
            }
            dateNascimento.Format = DateTimePickerFormat.Custom;
            dateNascimento.CustomFormat = "dd/MM/yyyy";
        }

        private void CadastrarNovoAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Const.cadAdmin = null;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }
    }
}
