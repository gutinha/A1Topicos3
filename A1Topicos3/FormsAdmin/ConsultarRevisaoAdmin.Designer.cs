namespace A1Topicos3.FormsAdmin
{
    partial class ConsultarRevisaoAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarRevisaoAdmin));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.topicos3DataSet = new A1Topicos3.Topicos3DataSet();
            this.revisaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.revisaoTableAdapter = new A1Topicos3.Topicos3DataSetTableAdapters.RevisaoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRevisaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carroidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicos3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revisaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(683, 25);
            this.toolStripMenu.TabIndex = 6;
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
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.dataRevisaoDataGridViewTextBoxColumn,
            this.carroidDataGridViewTextBoxColumn,
            this.usuarioidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.revisaoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(664, 387);
            this.dataGridView1.TabIndex = 5;
            // 
            // topicos3DataSet
            // 
            this.topicos3DataSet.DataSetName = "Topicos3DataSet";
            this.topicos3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // revisaoBindingSource
            // 
            this.revisaoBindingSource.DataMember = "Revisao";
            this.revisaoBindingSource.DataSource = this.topicos3DataSet;
            // 
            // revisaoTableAdapter
            // 
            this.revisaoTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataRevisaoDataGridViewTextBoxColumn
            // 
            this.dataRevisaoDataGridViewTextBoxColumn.DataPropertyName = "dataRevisao";
            this.dataRevisaoDataGridViewTextBoxColumn.HeaderText = "dataRevisao";
            this.dataRevisaoDataGridViewTextBoxColumn.Name = "dataRevisaoDataGridViewTextBoxColumn";
            this.dataRevisaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carroidDataGridViewTextBoxColumn
            // 
            this.carroidDataGridViewTextBoxColumn.DataPropertyName = "carro_id";
            this.carroidDataGridViewTextBoxColumn.HeaderText = "carro_id";
            this.carroidDataGridViewTextBoxColumn.Name = "carroidDataGridViewTextBoxColumn";
            this.carroidDataGridViewTextBoxColumn.ReadOnly = true;
            this.carroidDataGridViewTextBoxColumn.Width = 50;
            // 
            // usuarioidDataGridViewTextBoxColumn
            // 
            this.usuarioidDataGridViewTextBoxColumn.DataPropertyName = "usuario_id";
            this.usuarioidDataGridViewTextBoxColumn.HeaderText = "usuario_id";
            this.usuarioidDataGridViewTextBoxColumn.Name = "usuarioidDataGridViewTextBoxColumn";
            this.usuarioidDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioidDataGridViewTextBoxColumn.Width = 50;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(596, 28);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 7;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // ConsultarRevisaoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 446);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultarRevisaoAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarRevisaoAdmin";
            this.Load += new System.EventHandler(this.ConsultarRevisaoAdmin_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicos3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revisaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Topicos3DataSet topicos3DataSet;
        private System.Windows.Forms.BindingSource revisaoBindingSource;
        private Topicos3DataSetTableAdapters.RevisaoTableAdapter revisaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRevisaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carroidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btAtualizar;
    }
}