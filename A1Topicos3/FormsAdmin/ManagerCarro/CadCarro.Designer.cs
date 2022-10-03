namespace A1Topicos3.FormsAdmin.ManagerCarro
{
    partial class CadCarro
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateAnoModelo = new System.Windows.Forms.DateTimePicker();
            this.dateAnoFabricacao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQntCavalo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLitrosMotor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQntPortas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listStatus = new System.Windows.Forms.ListBox();
            this.listMarca = new System.Windows.Forms.ListBox();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topicos3MarcaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topicos3MarcaDataSet = new A1Topicos3.Topicos3MarcaDataSet();
            this.marcaTableAdapter = new A1Topicos3.Topicos3MarcaDataSetTableAdapters.MarcaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicos3MarcaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicos3MarcaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(128, 289);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(42, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(83, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(176, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(83, 60);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(176, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ano modelo";
            // 
            // dateAnoModelo
            // 
            this.dateAnoModelo.Location = new System.Drawing.Point(111, 86);
            this.dateAnoModelo.Name = "dateAnoModelo";
            this.dateAnoModelo.Size = new System.Drawing.Size(200, 20);
            this.dateAnoModelo.TabIndex = 6;
            // 
            // dateAnoFabricacao
            // 
            this.dateAnoFabricacao.Location = new System.Drawing.Point(127, 112);
            this.dateAnoFabricacao.Name = "dateAnoFabricacao";
            this.dateAnoFabricacao.Size = new System.Drawing.Size(200, 20);
            this.dateAnoFabricacao.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ano fabricação";
            // 
            // txtQntCavalo
            // 
            this.txtQntCavalo.Location = new System.Drawing.Point(111, 138);
            this.txtQntCavalo.Name = "txtQntCavalo";
            this.txtQntCavalo.Size = new System.Drawing.Size(176, 20);
            this.txtQntCavalo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Qnt cavalos";
            // 
            // txtLitrosMotor
            // 
            this.txtLitrosMotor.Location = new System.Drawing.Point(109, 164);
            this.txtLitrosMotor.Name = "txtLitrosMotor";
            this.txtLitrosMotor.Size = new System.Drawing.Size(176, 20);
            this.txtLitrosMotor.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Litros motor";
            // 
            // txtQntPortas
            // 
            this.txtQntPortas.Location = new System.Drawing.Point(104, 190);
            this.txtQntPortas.Name = "txtQntPortas";
            this.txtQntPortas.Size = new System.Drawing.Size(176, 20);
            this.txtQntPortas.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Qnt portas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Marca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Status";
            // 
            // listStatus
            // 
            this.listStatus.FormattingEnabled = true;
            this.listStatus.Location = new System.Drawing.Point(83, 242);
            this.listStatus.Name = "listStatus";
            this.listStatus.Size = new System.Drawing.Size(120, 17);
            this.listStatus.TabIndex = 18;
            // 
            // listMarca
            // 
            this.listMarca.DataSource = this.marcaBindingSource;
            this.listMarca.DisplayMember = "nome";
            this.listMarca.FormattingEnabled = true;
            this.listMarca.Location = new System.Drawing.Point(83, 219);
            this.listMarca.Name = "listMarca";
            this.listMarca.Size = new System.Drawing.Size(120, 17);
            this.listMarca.TabIndex = 19;
            this.listMarca.ValueMember = "nome";
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "Marca";
            this.marcaBindingSource.DataSource = this.topicos3MarcaDataSetBindingSource;
            // 
            // topicos3MarcaDataSetBindingSource
            // 
            this.topicos3MarcaDataSetBindingSource.DataSource = this.topicos3MarcaDataSet;
            this.topicos3MarcaDataSetBindingSource.Position = 0;
            // 
            // topicos3MarcaDataSet
            // 
            this.topicos3MarcaDataSet.DataSetName = "Topicos3MarcaDataSet";
            this.topicos3MarcaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // CadCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 322);
            this.Controls.Add(this.listMarca);
            this.Controls.Add(this.listStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQntPortas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLitrosMotor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQntCavalo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateAnoFabricacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateAnoModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnSalvar);
            this.Name = "CadCarro";
            this.Text = "CadCarro";
            this.Load += new System.EventHandler(this.CadCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicos3MarcaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicos3MarcaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateAnoModelo;
        private System.Windows.Forms.DateTimePicker dateAnoFabricacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQntCavalo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLitrosMotor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQntPortas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listStatus;
        private System.Windows.Forms.ListBox listMarca;
        private System.Windows.Forms.BindingSource topicos3MarcaDataSetBindingSource;
        private Topicos3MarcaDataSet topicos3MarcaDataSet;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private Topicos3MarcaDataSetTableAdapters.MarcaTableAdapter marcaTableAdapter;
    }
}