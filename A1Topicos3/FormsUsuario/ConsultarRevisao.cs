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

namespace A1Topicos3.FormsUsuario
{
    public partial class ConsultarRevisao : Form
    {
        public ConsultarRevisao()
        {
            InitializeComponent();
        }
        dbContext db = new dbContext();
        private void ConsultarRevisao_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Revisao.Where(x=> x.usuario_id == Const.usuarioLogado.id && x.dataRevisao >= DateTime.Now).ToList();
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
