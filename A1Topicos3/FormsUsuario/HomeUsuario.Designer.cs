namespace A1Topicos3
{
    partial class HomeUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUsuario));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btCadEndereco = new System.Windows.Forms.Button();
            this.btAgendarRevisao = new System.Windows.Forms.Button();
            this.lbCarrosCadastrados = new System.Windows.Forms.Label();
            this.lbRevisão = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(392, 25);
            this.toolStripMenu.TabIndex = 3;
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
            // btCadEndereco
            // 
            this.btCadEndereco.Location = new System.Drawing.Point(30, 46);
            this.btCadEndereco.Name = "btCadEndereco";
            this.btCadEndereco.Size = new System.Drawing.Size(93, 52);
            this.btCadEndereco.TabIndex = 4;
            this.btCadEndereco.Text = "Cadastrar Endereço";
            this.btCadEndereco.UseVisualStyleBackColor = true;
            this.btCadEndereco.Click += new System.EventHandler(this.btCadEndereco_Click);
            // 
            // btAgendarRevisao
            // 
            this.btAgendarRevisao.Location = new System.Drawing.Point(129, 46);
            this.btAgendarRevisao.Name = "btAgendarRevisao";
            this.btAgendarRevisao.Size = new System.Drawing.Size(93, 52);
            this.btAgendarRevisao.TabIndex = 5;
            this.btAgendarRevisao.Text = "Agendar Revisão";
            this.btAgendarRevisao.UseVisualStyleBackColor = true;
            this.btAgendarRevisao.Click += new System.EventHandler(this.btAgendarRevisao_Click);
            // 
            // lbCarrosCadastrados
            // 
            this.lbCarrosCadastrados.AutoSize = true;
            this.lbCarrosCadastrados.Location = new System.Drawing.Point(248, 46);
            this.lbCarrosCadastrados.Name = "lbCarrosCadastrados";
            this.lbCarrosCadastrados.Size = new System.Drawing.Size(101, 13);
            this.lbCarrosCadastrados.TabIndex = 6;
            this.lbCarrosCadastrados.Text = "Carros cadastrados:";
            // 
            // lbRevisão
            // 
            this.lbRevisão.AutoSize = true;
            this.lbRevisão.Location = new System.Drawing.Point(248, 66);
            this.lbRevisão.Name = "lbRevisão";
            this.lbRevisão.Size = new System.Drawing.Size(76, 13);
            this.lbRevisão.TabIndex = 7;
            this.lbRevisão.Text = "Suas revisões:";
            // 
            // HomeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 269);
            this.Controls.Add(this.lbRevisão);
            this.Controls.Add(this.lbCarrosCadastrados);
            this.Controls.Add(this.btAgendarRevisao);
            this.Controls.Add(this.btCadEndereco);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HomeUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeUsuario_FormClosing);
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
        private System.Windows.Forms.Button btCadEndereco;
        private System.Windows.Forms.Button btAgendarRevisao;
        private System.Windows.Forms.Label lbCarrosCadastrados;
        private System.Windows.Forms.Label lbRevisão;
    }
}