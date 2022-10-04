using A1Topicos3.FormsUsuario.CadastrarEndereco;
using A1Topicos3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1Topicos3.FormsUsuario.ManagerEndereco
{
    public partial class HomeEndereco : Form
    {
        public HomeEndereco()
        {
            InitializeComponent();
        }
        dbContext db = new dbContext();
        private void HomeEndereco_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Endereco.Where(x => x.Usuario_id == Const.usuarioLogado.id).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeUsuario home = new HomeUsuario();
            home.Show();
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void btNovoEndereco_Click(object sender, EventArgs e)
        {
            CadEndereco cadEndereco = new CadEndereco();
            cadEndereco.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Endereco.Where(x => x.Usuario_id == Const.usuarioLogado.id && x.endereco1.Contains(textBox1.Text) 
            || x.Usuario_id == Const.usuarioLogado.id && x.cidade.Contains(textBox1.Text)
            || x.Usuario_id == Const.usuarioLogado.id && x.estado.Contains(textBox1.Text)
            || x.Usuario_id == Const.usuarioLogado.id && x.cep.Contains(textBox1.Text)).ToList();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
