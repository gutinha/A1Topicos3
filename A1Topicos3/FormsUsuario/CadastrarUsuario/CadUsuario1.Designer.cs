namespace A1Topicos3.FormsUsuario.CadastrarUsuario
{
    partial class CadUsuario1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadUsuario1));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskRG = new System.Windows.Forms.MaskedTextBox();
            this.maskCPF = new System.Windows.Forms.MaskedTextBox();
            this.buttonProximo = new System.Windows.Forms.Button();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.dateNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelRG = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.lbNomeFantasia = new System.Windows.Forms.Label();
            this.maskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.cbPF = new System.Windows.Forms.RadioButton();
            this.cbPJ = new System.Windows.Forms.RadioButton();
            this.labelDataFundacao = new System.Windows.Forms.Label();
            this.dateDataFundacao = new System.Windows.Forms.DateTimePicker();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(398, 25);
            this.toolStripMenu.TabIndex = 39;
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
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // maskRG
            // 
            this.maskRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskRG.Location = new System.Drawing.Point(52, 98);
            this.maskRG.Mask = "0\\.000\\.000";
            this.maskRG.Name = "maskRG";
            this.maskRG.Size = new System.Drawing.Size(69, 22);
            this.maskRG.TabIndex = 38;
            // 
            // maskCPF
            // 
            this.maskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCPF.Location = new System.Drawing.Point(52, 121);
            this.maskCPF.Mask = "000\\.000\\.000\\-00";
            this.maskCPF.Name = "maskCPF";
            this.maskCPF.Size = new System.Drawing.Size(97, 22);
            this.maskCPF.TabIndex = 37;
            // 
            // buttonProximo
            // 
            this.buttonProximo.Location = new System.Drawing.Point(261, 191);
            this.buttonProximo.Name = "buttonProximo";
            this.buttonProximo.Size = new System.Drawing.Size(75, 23);
            this.buttonProximo.TabIndex = 36;
            this.buttonProximo.Text = "Próximo";
            this.buttonProximo.UseVisualStyleBackColor = true;
            this.buttonProximo.Click += new System.EventHandler(this.buttonProximo_Click);
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(19, 155);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(102, 13);
            this.labelDataNascimento.TabIndex = 35;
            this.labelDataNascimento.Text = "Data de nascimento";
            // 
            // dateNascimento
            // 
            this.dateNascimento.Location = new System.Drawing.Point(127, 149);
            this.dateNascimento.Name = "dateNascimento";
            this.dateNascimento.Size = new System.Drawing.Size(209, 20);
            this.dateNascimento.TabIndex = 34;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(106, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(201, 20);
            this.txtNome.TabIndex = 33;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(19, 126);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(27, 13);
            this.labelCPF.TabIndex = 32;
            this.labelCPF.Text = "CPF";
            // 
            // labelRG
            // 
            this.labelRG.AutoSize = true;
            this.labelRG.Location = new System.Drawing.Point(19, 103);
            this.labelRG.Name = "labelRG";
            this.labelRG.Size = new System.Drawing.Size(23, 13);
            this.labelRG.TabIndex = 31;
            this.labelRG.Text = "RG";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(19, 77);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(81, 13);
            this.labelNome.TabIndex = 30;
            this.labelNome.Text = "Nome completo";
            // 
            // lbNomeFantasia
            // 
            this.lbNomeFantasia.AutoSize = true;
            this.lbNomeFantasia.Location = new System.Drawing.Point(19, 77);
            this.lbNomeFantasia.Name = "lbNomeFantasia";
            this.lbNomeFantasia.Size = new System.Drawing.Size(75, 13);
            this.lbNomeFantasia.TabIndex = 42;
            this.lbNomeFantasia.Text = "Nome fantasia";
            // 
            // maskCNPJ
            // 
            this.maskCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCNPJ.Location = new System.Drawing.Point(52, 98);
            this.maskCNPJ.Mask = "00\\.000\\.000\\/0000-00";
            this.maskCNPJ.Name = "maskCNPJ";
            this.maskCNPJ.Size = new System.Drawing.Size(124, 22);
            this.maskCNPJ.TabIndex = 44;
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.AutoSize = true;
            this.lbCNPJ.Location = new System.Drawing.Point(19, 103);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lbCNPJ.TabIndex = 43;
            this.lbCNPJ.Text = "CNPJ";
            // 
            // cbPF
            // 
            this.cbPF.AutoSize = true;
            this.cbPF.Location = new System.Drawing.Point(91, 37);
            this.cbPF.Name = "cbPF";
            this.cbPF.Size = new System.Drawing.Size(92, 17);
            this.cbPF.TabIndex = 45;
            this.cbPF.TabStop = true;
            this.cbPF.Text = "Pessoa Física";
            this.cbPF.UseVisualStyleBackColor = true;
            this.cbPF.Click += new System.EventHandler(this.cbPF_Click_1);
            // 
            // cbPJ
            // 
            this.cbPJ.AutoSize = true;
            this.cbPJ.Location = new System.Drawing.Point(182, 37);
            this.cbPJ.Name = "cbPJ";
            this.cbPJ.Size = new System.Drawing.Size(101, 17);
            this.cbPJ.TabIndex = 46;
            this.cbPJ.TabStop = true;
            this.cbPJ.Text = "Pessoa Jurídica";
            this.cbPJ.UseVisualStyleBackColor = true;
            this.cbPJ.Click += new System.EventHandler(this.cbPJ_Click_1);
            // 
            // labelDataFundacao
            // 
            this.labelDataFundacao.AutoSize = true;
            this.labelDataFundacao.Location = new System.Drawing.Point(19, 130);
            this.labelDataFundacao.Name = "labelDataFundacao";
            this.labelDataFundacao.Size = new System.Drawing.Size(93, 13);
            this.labelDataFundacao.TabIndex = 48;
            this.labelDataFundacao.Text = "Data de fundação";
            // 
            // dateDataFundacao
            // 
            this.dateDataFundacao.Location = new System.Drawing.Point(127, 124);
            this.dateDataFundacao.Name = "dateDataFundacao";
            this.dateDataFundacao.Size = new System.Drawing.Size(209, 20);
            this.dateDataFundacao.TabIndex = 47;
            // 
            // CadUsuario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 222);
            this.Controls.Add(this.labelDataFundacao);
            this.Controls.Add(this.dateDataFundacao);
            this.Controls.Add(this.cbPJ);
            this.Controls.Add(this.cbPF);
            this.Controls.Add(this.maskCNPJ);
            this.Controls.Add(this.lbCNPJ);
            this.Controls.Add(this.lbNomeFantasia);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.maskRG);
            this.Controls.Add(this.maskCPF);
            this.Controls.Add(this.buttonProximo);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.dateNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.labelRG);
            this.Controls.Add(this.labelNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadUsuario1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadUsuario1_FormClosing);
            this.Load += new System.EventHandler(this.CadUsuario1_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox maskRG;
        private System.Windows.Forms.MaskedTextBox maskCPF;
        private System.Windows.Forms.Button buttonProximo;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.DateTimePicker dateNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelRG;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label lbNomeFantasia;
        private System.Windows.Forms.MaskedTextBox maskCNPJ;
        private System.Windows.Forms.Label lbCNPJ;
        private System.Windows.Forms.RadioButton cbPF;
        private System.Windows.Forms.RadioButton cbPJ;
        private System.Windows.Forms.Label labelDataFundacao;
        private System.Windows.Forms.DateTimePicker dateDataFundacao;
    }
}