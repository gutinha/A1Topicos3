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
            this.topicos3CarroDataSet = new A1Topicos3.Topicos3CarroDataSet();
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carroTableAdapter = new A1Topicos3.Topicos3CarroDataSetTableAdapters.CarroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.topicos3CarroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCarro
            // 
            this.cbCarro.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.carroBindingSource, "id", true));
            this.cbCarro.DataSource = this.carroBindingSource;
            this.cbCarro.DisplayMember = "nome";
            this.cbCarro.FormattingEnabled = true;
            this.cbCarro.Location = new System.Drawing.Point(446, 186);
            this.cbCarro.Name = "cbCarro";
            this.cbCarro.Size = new System.Drawing.Size(158, 21);
            this.cbCarro.TabIndex = 0;
            // 
            // topicos3CarroDataSet
            // 
            this.topicos3CarroDataSet.DataSetName = "Topicos3CarroDataSet";
            this.topicos3CarroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carroBindingSource
            // 
            this.carroBindingSource.DataMember = "Carro";
            this.carroBindingSource.DataSource = this.topicos3CarroDataSet;
            // 
            // carroTableAdapter
            // 
            this.carroTableAdapter.ClearBeforeFill = true;
            // 
            // AgendarRevisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCarro);
            this.Name = "AgendarRevisao";
            this.Text = "AgendarRevisao";
            this.Load += new System.EventHandler(this.AgendarRevisao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topicos3CarroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCarro;
        private Topicos3CarroDataSet topicos3CarroDataSet;
        private System.Windows.Forms.BindingSource carroBindingSource;
        private Topicos3CarroDataSetTableAdapters.CarroTableAdapter carroTableAdapter;
    }
}