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
    public partial class AgendarRevisao : Form
    {
        public AgendarRevisao()
        {
            InitializeComponent();
            lbSelecionarCarro.Hide();
            cbCarro.Hide();
        }
        dbContext db = new dbContext();
        private void AgendarRevisao_Load(object sender, EventArgs e)
        {
            cbMarca.DataSource = db.Marca.Where(x => x.id != 0).ToList();
            dateRevisao.Format = DateTimePickerFormat.Custom;
            dateRevisao.CustomFormat = "dd/MM/yyyy";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Revisao revisao = new Revisao();
            var carId = (Carro)cbCarro.SelectedItem;
            try
            {
                var data = dateRevisao.Text;
                var Adata = data.Split('/');
                var dia = Convert.ToInt16(Adata[0]);
                var mes = Convert.ToInt16(Adata[1]);
                var ano = Convert.ToInt16(Adata[2]);
                revisao.descricao = txtDescricao.Text;
                revisao.dataRevisao = new DateTime(ano, mes, dia);
                revisao.usuario_id = Const.usuarioLogado.id;
                revisao.carro_id = carId.id;
                db.Revisao.Add(revisao);
                db.SaveChanges();
                MessageBox.Show("Revisão agendada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao agendar");
            }
        }

        private void cbMarca_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbCarro.Show();
            lbSelecionarCarro.Show();
            var a = (Marca)cbMarca.SelectedItem;
            cbCarro.DataSource = db.Carro.Where(x => x.marca_id == a.id).ToList();
        }
    }
}
