namespace A1Topicos3.FormsUsuario
{
    partial class AgendarRevisao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbCarro = new System.Windows.Forms.ComboBox();
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topicos3CarroDataSet = new A1Topicos3.Topicos3CarroDataSet();
            this.carroTableAdapter = new A1Topicos3.Topicos3CarroDataSetTableAdapters.CarroTableAdapter();
            this.topicos3MarcaDataSet = new A1Topicos3.Topicos3MarcaDataSet();
            this.topicos3MarcaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaTableAdapter = new A1Topicos3.Topicos3MarcaDataSetTableAdapters.MarcaTableAdapter();
            this.lbSelecionarCarro = new System.Windows.Forms.Label();
            this.lbSelecionarMarca = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.dateRevisao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicos3CarroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicos3MarcaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicos3MarcaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCarro
            // 
            this.cbCarro.DataSource = this.carroBindingSource;
            this.cbCarro.DisplayMember = "nome";
            this.cbCarro.FormattingEnabled = true;
            this.cbCarro.Location = new System.Drawing.Point(405, 109);
            this.cbCarro.Name = "cbCarro";
            this.cbCarro.Size = new System.Drawing.Size(158, 21);
            this.cbCarro.TabIndex = 0;
            // 
            // carroBindingSource
            // 
            this.carroBindingSource.DataMember = "Carro";
            this.carroBindingSource.DataSource = this.topicos3CarroDataSet;
            // 
            // topicos3CarroDataSet
            // 
            this.topicos3CarroDataSet.DataSetName = "Topicos3CarroDataSet";
            this.topicos3CarroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carroTableAdapter
            // 
            this.carroTableAdapter.ClearBeforeFill = true;
            // 
            // topicos3MarcaDataSet
            // 
            this.topicos3MarcaDataSet.DataSetName = "Topicos3MarcaDataSet";
            this.topicos3MarcaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // topicos3MarcaDataSetBindingSource
            // 
            this.topicos3MarcaDataSetBindingSource.DataSource = this.topicos3MarcaDataSet;
            this.topicos3MarcaDataSetBindingSource.Position = 0;
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "Marca";
            this.marcaBindingSource.DataSource = this.topicos3MarcaDataSetBindingSource;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // lbSelecionarCarro
            // 
            this.lbSelecionarCarro.AutoSize = true;
            this.lbSelecionarCarro.Location = new System.Drawing.Point(302, 112);
            this.lbSelecionarCarro.Name = "lbSelecionarCarro";
            this.lbSelecionarCarro.Size = new System.Drawing.Size(90, 13);
            this.lbSelecionarCarro.TabIndex = 2;
            this.lbSelecionarCarro.Text = "Selecione o carro";
            // 
            // lbSelecionarMarca
            // 
            this.lbSelecionarMarca.AutoSize = true;
            this.lbSelecionarMarca.Location = new System.Drawing.Point(302, 85);
            this.lbSelecionarMarca.Name = "lbSelecionarMarca";
            this.lbSelecionarMarca.Size = new System.Drawing.Size(95, 13);
            this.lbSelecionarMarca.TabIndex = 3;
            this.lbSelecionarMarca.Text = "Selecione a marca";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 85);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(215, 106);
            this.txtDescricao.TabIndex = 4;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(12, 69);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(176, 13);
            this.lbDescricao.TabIndex = 5;
            this.lbDescricao.Text = "Digite a descrição no campo abaixo";
            // 
            // dateRevisao
            // 
            this.dateRevisao.Location = new System.Drawing.Point(305, 171);
            this.dateRevisao.Name = "dateRevisao";
            this.dateRevisao.Size = new System.Drawing.Size(200, 20);
            this.dateRevisao.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecione a data para a revisão";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(490, 222);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 8;
            this.btSalvar.Text = "Agendar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // cbMarca
            // 
            this.cbMarca.DataSource = this.marcaBindingSource;
            this.cbMarca.DisplayMember = "nome";
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(405, 82);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(158, 21);
            this.cbMarca.TabIndex = 9;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged_1);
            // 
            // AgendarRevisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 257);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateRevisao);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lbSelecionarMarca);
            this.Controls.Add(this.lbSelecionarCarro);
            this.Controls.Add(this.cbCarro);
            this.Name = "AgendarRevisao";
            this.Text = "AgendarRevisao";
            this.Load += new System.EventHandler(this.AgendarRevisao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicos3CarroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicos3MarcaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicos3MarcaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCarro;
        private Topicos3CarroDataSet topicos3CarroDataSet;
        private System.Windows.Forms.BindingSource carroBindingSource;
        private Topicos3CarroDataSetTableAdapters.CarroTableAdapter carroTableAdapter;
        private System.Windows.Forms.BindingSource topicos3MarcaDataSetBindingSource;
        private Topicos3MarcaDataSet topicos3MarcaDataSet;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private Topicos3MarcaDataSetTableAdapters.MarcaTableAdapter marcaTableAdapter;
        private System.Windows.Forms.Label lbSelecionarCarro;
        private System.Windows.Forms.Label lbSelecionarMarca;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.DateTimePicker dateRevisao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.ComboBox cbMarca;
    }
}