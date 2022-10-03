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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace A1Topicos3.FormsAdmin.ManagerCarro
{
    public partial class CadCarro : Form
    {
        public CadCarro()
        {
            InitializeComponent();
        }
        dbContext db = new dbContext();

        private void CadCarro_Load(object sender, EventArgs e)
        {
            List<Carro.Status> a = new List<Carro.Status>();
            a.Add(Carro.Status.Novo);
            a.Add(Carro.Status.Usado);
            listStatus.DataSource = a;
            listMarca.DataSource = db.Marca.Where(x => x.id != 0).ToList();
            dateAnoFabricacao.Format = DateTimePickerFormat.Custom;
            dateAnoFabricacao.CustomFormat = "dd/MM/yyyy";
            dateAnoModelo.Format = DateTimePickerFormat.Custom;
            dateAnoModelo.CustomFormat = "dd/MM/yyyy";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();
            try
            {
                var data = dateAnoFabricacao.Text;
                var Adata = data.Split('/');
                var dia = Convert.ToInt16(Adata[0]);
                var mes = Convert.ToInt16(Adata[1]);
                var ano = Convert.ToInt16(Adata[2]);

                var data2 = dateAnoModelo.Text;
                var Adata2 = data2.Split('/');
                var dia2 = Convert.ToInt16(Adata2[0]);
                var mes2 = Convert.ToInt16(Adata2[1]);
                var ano2 = Convert.ToInt16(Adata2[2]);
                carro.anoModelo = new DateTime(ano2, mes2, dia2);
                carro.anoFabricacao = new DateTime(ano, mes, dia);
                carro.cavalos = Convert.ToInt16(txtQntCavalo.Text);
                carro.litrosMotor = Convert.ToInt16(txtLitrosMotor.Text);
                carro.quantPortas = Convert.ToInt16(txtQntPortas.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Você colocou uma palavra em um dado numérico");
            }
            carro.Marca = (Marca)listMarca.SelectedItem;
            carro.nome = txtNome.Text;
            carro.modelo = txtModelo.Text;
            carro.status = (Carro.Status)listStatus.SelectedItem;
            try
            {
                db.Carro.Add(carro);
                db.Log.Add(new Log(DateTime.Now, "Usuário cadastrou um carro", Const.usuarioLogado.nome + " Id: " + Const.usuarioLogado.id));
                db.SaveChanges();
                MessageBox.Show("Carro cadastrado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                db.LogSystem.Add(new LogSystem(DateTime.Now, ex.Message, Const.usuarioLogado.nome + " Id: " + Const.usuarioLogado.id));
                db.SaveChanges();
                MessageBox.Show("Erro ao salvar o carro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
