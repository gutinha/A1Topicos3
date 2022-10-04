namespace A1Topicos3.FormsUsuario.ManagerEndereco
{
    partial class HomeEndereco
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeEndereco));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.enderecoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.enderecoDataSet = new A1Topicos3.EnderecoDataSet();
            this.btNovoEndereco = new System.Windows.Forms.Button();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enderecoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topicos3EnderecoDataSet = new A1Topicos3.Topicos3EnderecoDataSet();
            this.enderecoTableAdapter = new A1Topicos3.Topicos3EnderecoDataSetTableAdapters.EnderecoTableAdapter();
            this.topicos3EnderecoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enderecoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.enderecoTableAdapter1 = new A1Topicos3.EnderecoDataSetTableAdapters.EnderecoTableAdapter();
            this.lbProcurar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoDataSet)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicos3EnderecoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicos3EnderecoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.editar});
            this.dataGridView1.DataSource = this.enderecoBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(955, 398);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            this.complementoDataGridViewTextBoxColumn.DataPropertyName = "complemento";
            this.complementoDataGridViewTextBoxColumn.HeaderText = "complemento";
            this.complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
            this.complementoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Editar";
            this.editar.DefaultCellStyle = dataGridViewCellStyle1;
            this.editar.HeaderText = "";
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // enderecoBindingSource2
            // 
            this.enderecoBindingSource2.DataMember = "Endereco";
            this.enderecoBindingSource2.DataSource = this.enderecoDataSet;
            // 
            // enderecoDataSet
            // 
            this.enderecoDataSet.DataSetName = "EnderecoDataSet";
            this.enderecoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btNovoEndereco
            // 
            this.btNovoEndereco.Location = new System.Drawing.Point(892, 470);
            this.btNovoEndereco.Name = "btNovoEndereco";
            this.btNovoEndereco.Size = new System.Drawing.Size(75, 23);
            this.btNovoEndereco.TabIndex = 1;
            this.btNovoEndereco.Text = "Novo";
            this.btNovoEndereco.UseVisualStyleBackColor = true;
            this.btNovoEndereco.Click += new System.EventHandler(this.btNovoEndereco_Click);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(990, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "Menu";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(51, 22);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // enderecoBindingSource
            // 
            this.enderecoBindingSource.DataMember = "Endereco";
            this.enderecoBindingSource.DataSource = this.topicos3EnderecoDataSet;
            // 
            // topicos3EnderecoDataSet
            // 
            this.topicos3EnderecoDataSet.DataSetName = "Topicos3EnderecoDataSet";
            this.topicos3EnderecoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enderecoTableAdapter
            // 
            this.enderecoTableAdapter.ClearBeforeFill = true;
            // 
            // topicos3EnderecoDataSetBindingSource
            // 
            this.topicos3EnderecoDataSetBindingSource.DataSource = this.topicos3EnderecoDataSet;
            this.topicos3EnderecoDataSetBindingSource.Position = 0;
            // 
            // enderecoBindingSource1
            // 
            this.enderecoBindingSource1.DataMember = "Endereco";
            this.enderecoBindingSource1.DataSource = this.topicos3EnderecoDataSetBindingSource;
            // 
            // enderecoTableAdapter1
            // 
            this.enderecoTableAdapter1.ClearBeforeFill = true;
            // 
            // lbProcurar
            // 
            this.lbProcurar.AutoSize = true;
            this.lbProcurar.Location = new System.Drawing.Point(769, 43);
            this.lbProcurar.Name = "lbProcurar";
            this.lbProcurar.Size = new System.Drawing.Size(47, 13);
            this.lbProcurar.TabIndex = 5;
            this.lbProcurar.Text = "Procurar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(822, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // HomeEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 505);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbProcurar);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.btNovoEndereco);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HomeEndereco";
            this.Text = "HomeEndereco";
            this.Load += new System.EventHandler(this.HomeEndereco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoDataSet)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicos3EnderecoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicos3EnderecoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Topicos3EnderecoDataSet topicos3EnderecoDataSet;
        private System.Windows.Forms.BindingSource enderecoBindingSource;
        private Topicos3EnderecoDataSetTableAdapters.EnderecoTableAdapter enderecoTableAdapter;
        private System.Windows.Forms.Button btNovoEndereco;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.BindingSource enderecoBindingSource1;
        private System.Windows.Forms.BindingSource topicos3EnderecoDataSetBindingSource;
        private EnderecoDataSet enderecoDataSet;
        private System.Windows.Forms.BindingSource enderecoBindingSource2;
        private EnderecoDataSetTableAdapters.EnderecoTableAdapter enderecoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn editar;
        private System.Windows.Forms.Label lbProcurar;
        private System.Windows.Forms.TextBox textBox1;
    }
}