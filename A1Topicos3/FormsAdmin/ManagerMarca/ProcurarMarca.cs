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

namespace A1Topicos3.FormsAdmin.ManagerMarca
{
    public partial class ProcurarMarca : Form
    {
        dbContext db = new dbContext();
        public ProcurarMarca()
        {
            InitializeComponent();
        }

        private void ProcurarMarca_Load(object sender, EventArgs e)
        {
            var result = db.Marca.Where(x => x.id != 0).ToList();
            dataGridView1.DataSource = result;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "imagem";
            imageColumn.HeaderText = "Logo";
            imageColumn.Width = 140;
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns.Add(imageColumn);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows[row.Index].Height = 64;
                var item = result[row.Index];
                if (item.imagem != null || item.imagem != "" || item.imagem != "null")
                {
                    Image i = Image.FromFile(Const.path + item.imagem);
                    row.Cells[3].Value = i;
                }
            }
        }

        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            var result = db.Marca.Where(x => x.nome.Contains(txtProcurar.Text) || x.id.ToString().Contains(txtProcurar.Text)).ToList();
            dataGridView1.DataSource = result;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows[row.Index].Height = 64;
                var item = result[row.Index];
                if (item.imagem != null || item.imagem != "" || item.imagem != "null")
                {
                    Image i = Image.FromFile(Const.path + item.imagem);
                    row.Cells[3].Value = i;
                }
            }
        }
    }
}
