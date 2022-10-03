namespace A1Topicos3.FormsAdmin
{
    partial class CadAdmin1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadAdmin1));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelRG = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.dateNascimento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonProximo = new System.Windows.Forms.Button();
            this.maskCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskRG = new System.Windows.Forms.MaskedTextBox();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(118, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(201, 20);
            this.txtNome.TabIndex = 20;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(31, 89);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(27, 13);
            this.labelCPF.TabIndex = 19;
            this.labelCPF.Text = "CPF";
            // 
            // labelRG
            // 
            this.labelRG.AutoSize = true;
            this.labelRG.Location = new System.Drawing.Point(31, 66);
            this.labelRG.Name = "labelRG";
            this.labelRG.Size = new System.Drawing.Size(23, 13);
            this.labelRG.TabIndex = 18;
            this.labelRG.Text = "RG";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(31, 40);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(81, 13);
            this.labelNome.TabIndex = 16;
            this.labelNome.Text = "Nome completo";
            // 
            // dateNascimento
            // 
            this.dateNascimento.Location = new System.Drawing.Point(139, 112);
            this.dateNascimento.Name = "dateNascimento";
            this.dateNascimento.Size = new System.Drawing.Size(209, 20);
            this.dateNascimento.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Data de nascimento";
            // 
            // buttonProximo
            // 
            this.buttonProximo.Location = new System.Drawing.Point(273, 154);
            this.buttonProximo.Name = "buttonProximo";
            this.buttonProximo.Size = new System.Drawing.Size(75, 23);
            this.buttonProximo.TabIndex = 26;
            this.buttonProximo.Text = "Próximo";
            this.buttonProximo.UseVisualStyleBackColor = true;
            this.buttonProximo.Click += new System.EventHandler(this.buttonProximo_Click);
            // 
            // maskCPF
            // 
            this.maskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCPF.Location = new System.Drawing.Point(64, 84);
            this.maskCPF.Mask = "000\\.000\\.000\\-00";
            this.maskCPF.Name = "maskCPF";
            this.maskCPF.Size = new System.Drawing.Size(97, 22);
            this.maskCPF.TabIndex = 27;
            // 
            // maskRG
            // 
            this.maskRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskRG.Location = new System.Drawing.Point(64, 61);
            this.maskRG.Mask = "0\\.000\\.000";
            this.maskRG.Name = "maskRG";
            this.maskRG.Size = new System.Drawing.Size(69, 22);
            this.maskRG.TabIndex = 28;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(369, 25);
            this.toolStripMenu.TabIndex = 29;
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
            // CadAdmin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 190);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.maskRG);
            this.Controls.Add(this.maskCPF);
            this.Controls.Add(this.buttonProximo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.labelRG);
            this.Controls.Add(this.labelNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CadAdmin1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarNovoAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastrarNovoAdmin_FormClosing);
            this.Load += new System.EventHandler(this.CadastrarNovoAdmin_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelRG;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.DateTimePicker dateNascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonProximo;
        private System.Windows.Forms.MaskedTextBox maskCPF;
        private System.Windows.Forms.MaskedTextBox maskRG;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}