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
    public partial class ConsultarRevisaoAdmin : Form
    {
        public ConsultarRevisaoAdmin()
        {
            InitializeComponent();
        }
        dbContext db = new dbContext();
        private void ConsultarRevisaoAdmin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Revisao.Where(x => x.dataRevisao >= DateTime.Now).ToList();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Revisao.Where(x => x.dataRevisao >= DateTime.Now).ToList();
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
