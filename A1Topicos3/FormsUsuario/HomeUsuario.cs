using A1Topicos3.FormsUsuario;
using A1Topicos3.FormsUsuario.ManagerEndereco;
using A1Topicos3.Model;
using A1Topicos3.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1Topicos3
{
    public partial class HomeUsuario : Form
    {
        dbContext db = new dbContext();
        public HomeUsuario()
        {
            InitializeComponent();
            lbCarrosCadastrados.Text = "Carros cadastrados: " + db.Carro.Count();
            lbRevisão.Text = "Suas revisões: " + db.Revisao.Where(x => x.usuario_id == Const.usuarioLogado.id && x.dataRevisao >= DateTime.Now).Count();
        }

        private void HomeUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utils.logSair();
            Application.OpenForms["Login"].Close();

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void btCadEndereco_Click(object sender, EventArgs e)
        {
            HomeEndereco homeEndereco = new HomeEndereco();
            homeEndereco.Show();
        }

        private void btAgendarRevisao_Click(object sender, EventArgs e)
        {
            AgendarRevisao agendar = new AgendarRevisao();
            agendar.Show();
        }

        private void btConsultarRevisao_Click(object sender, EventArgs e)
        {
            ConsultarRevisao cr = new ConsultarRevisao();
            cr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbCarrosCadastrados.Text = "Carros cadastrados: " + db.Carro.Count();
            lbRevisão.Text = "Suas revisões: " + db.Revisao.Where(x => x.usuario_id == Const.usuarioLogado.id && x.dataRevisao >= DateTime.Now).Count();
        }
    }
}
