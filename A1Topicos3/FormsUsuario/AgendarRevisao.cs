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
    public partial class AgendarRevisao : Form
    {
        public AgendarRevisao()
        {
            InitializeComponent();
        }
        dbContext db = new dbContext();
        private void AgendarRevisao_Load(object sender, EventArgs e)
        {
            cbCarro.DataSource = db.Carro.Where(x => x.id != 0);
        }
    }
}
