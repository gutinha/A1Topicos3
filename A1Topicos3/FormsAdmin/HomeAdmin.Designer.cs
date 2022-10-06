namespace A1Topicos3
{
    partial class HomeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAdmin));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCadAdmin = new System.Windows.Forms.Button();
            this.buttonMarca = new System.Windows.Forms.Button();
            this.btManagerCarro = new System.Windows.Forms.Button();
            this.lbRevisaoAserFeita = new System.Windows.Forms.Label();
            this.btConsultarRevisoes = new System.Windows.Forms.Button();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(355, 25);
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
            // buttonCadAdmin
            // 
            this.buttonCadAdmin.Location = new System.Drawing.Point(218, 68);
            this.buttonCadAdmin.Name = "buttonCadAdmin";
            this.buttonCadAdmin.Size = new System.Drawing.Size(97, 57);
            this.buttonCadAdmin.TabIndex = 5;
            this.buttonCadAdmin.Text = "Gerenciar Admin";
            this.buttonCadAdmin.UseVisualStyleBackColor = true;
            this.buttonCadAdmin.Click += new System.EventHandler(this.buttonCadAdmin_Click);
            // 
            // buttonMarca
            // 
            this.buttonMarca.Location = new System.Drawing.Point(12, 68);
            this.buttonMarca.Name = "buttonMarca";
            this.buttonMarca.Size = new System.Drawing.Size(97, 57);
            this.buttonMarca.TabIndex = 6;
            this.buttonMarca.Text = "Gerenciar marcas";
            this.buttonMarca.UseVisualStyleBackColor = true;
            this.buttonMarca.Click += new System.EventHandler(this.buttonMarca_Click);
            // 
            // btManagerCarro
            // 
            this.btManagerCarro.Location = new System.Drawing.Point(115, 68);
            this.btManagerCarro.Name = "btManagerCarro";
            this.btManagerCarro.Size = new System.Drawing.Size(97, 57);
            this.btManagerCarro.TabIndex = 7;
            this.btManagerCarro.Text = "Gerenciar carros";
            this.btManagerCarro.UseVisualStyleBackColor = true;
            this.btManagerCarro.Click += new System.EventHandler(this.btManagerCarro_Click);
            // 
            // lbRevisaoAserFeita
            // 
            this.lbRevisaoAserFeita.AutoSize = true;
            this.lbRevisaoAserFeita.Location = new System.Drawing.Point(12, 38);
            this.lbRevisaoAserFeita.Name = "lbRevisaoAserFeita";
            this.lbRevisaoAserFeita.Size = new System.Drawing.Size(122, 13);
            this.lbRevisaoAserFeita.TabIndex = 8;
            this.lbRevisaoAserFeita.Text = "Revisões a serem feitas:";
            // 
            // btConsultarRevisoes
            // 
            this.btConsultarRevisoes.Location = new System.Drawing.Point(15, 131);
            this.btConsultarRevisoes.Name = "btConsultarRevisoes";
            this.btConsultarRevisoes.Size = new System.Drawing.Size(97, 57);
            this.btConsultarRevisoes.TabIndex = 9;
            this.btConsultarRevisoes.Text = "Consultar revisões";
            this.btConsultarRevisoes.UseVisualStyleBackColor = true;
            this.btConsultarRevisoes.Click += new System.EventHandler(this.btConsultarRevisoes_Click);
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 213);
            this.Controls.Add(this.btConsultarRevisoes);
            this.Controls.Add(this.lbRevisaoAserFeita);
            this.Controls.Add(this.btManagerCarro);
            this.Controls.Add(this.buttonMarca);
            this.Controls.Add(this.buttonCadAdmin);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeAdmin_FormClosing);
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
        private System.Windows.Forms.Button buttonCadAdmin;
        private System.Windows.Forms.Button buttonMarca;
        private System.Windows.Forms.Button btManagerCarro;
        private System.Windows.Forms.Label lbRevisaoAserFeita;
        private System.Windows.Forms.Button btConsultarRevisoes;
    }
}