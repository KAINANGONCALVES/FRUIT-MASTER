namespace SistemaEstoque
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tROCARMUDARUSUÁRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaisDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOVIMENTAÇÃOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.BtnSairMenu = new System.Windows.Forms.Button();
            this.BtnCastroEstoqueMenu = new System.Windows.Forms.Button();
            this.BtnAlterarUsuarioMenu = new System.Windows.Forms.Button();
            this.BtnCastroMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.cONSULARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tROCARMUDARUSUÁRIOToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.arquivoToolStripMenuItem.Text = "ARQUIVO";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "FINALIZAR SISTEMA";
            this.sairToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // tROCARMUDARUSUÁRIOToolStripMenuItem
            // 
            this.tROCARMUDARUSUÁRIOToolStripMenuItem.Name = "tROCARMUDARUSUÁRIOToolStripMenuItem";
            this.tROCARMUDARUSUÁRIOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tROCARMUDARUSUÁRIOToolStripMenuItem.Text = "ALTERAR USUÁRIO";
            this.tROCARMUDARUSUÁRIOToolStripMenuItem.Click += new System.EventHandler(this.tROCARMUDARUSUÁRIOToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locaisDeEstoqueToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.usuárioToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "CASTRAR";
            // 
            // locaisDeEstoqueToolStripMenuItem
            // 
            this.locaisDeEstoqueToolStripMenuItem.Name = "locaisDeEstoqueToolStripMenuItem";
            this.locaisDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.locaisDeEstoqueToolStripMenuItem.Text = "LOCAIS DE ESTOQUE";
            this.locaisDeEstoqueToolStripMenuItem.Click += new System.EventHandler(this.locaisDeEstoqueToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.produtosToolStripMenuItem.Text = "PRODUTOS";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.usuárioToolStripMenuItem.Text = "USUÁRIO";
            // 
            // cONSULARToolStripMenuItem
            // 
            this.cONSULARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOVIMENTAÇÃOToolStripMenuItem1});
            this.cONSULARToolStripMenuItem.Name = "cONSULARToolStripMenuItem";
            this.cONSULARToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.cONSULARToolStripMenuItem.Text = "CONSULTAR";
            // 
            // mOVIMENTAÇÃOToolStripMenuItem1
            // 
            this.mOVIMENTAÇÃOToolStripMenuItem1.Name = "mOVIMENTAÇÃOToolStripMenuItem1";
            this.mOVIMENTAÇÃOToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.mOVIMENTAÇÃOToolStripMenuItem1.Text = "MOVIMENTAÇÃO";
            this.mOVIMENTAÇÃOToolStripMenuItem1.Click += new System.EventHandler(this.mOVIMENTAÇÃOToolStripMenuItem1_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::SistemaEstoque.Properties.Resources.equipe;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Location = new System.Drawing.Point(483, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 101);
            this.button5.TabIndex = 12;
            this.button5.Text = "CADASTRAR USUÁRIO";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // BtnSairMenu
            // 
            this.BtnSairMenu.BackgroundImage = global::SistemaEstoque.Properties.Resources.desligar;
            this.BtnSairMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSairMenu.Location = new System.Drawing.Point(293, 264);
            this.BtnSairMenu.Name = "BtnSairMenu";
            this.BtnSairMenu.Size = new System.Drawing.Size(116, 101);
            this.BtnSairMenu.TabIndex = 11;
            this.BtnSairMenu.Text = "SAIR E ENCERRAR ";
            this.BtnSairMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSairMenu.UseVisualStyleBackColor = true;
            this.BtnSairMenu.Click += new System.EventHandler(this.BtnSairMenu_Click);
            // 
            // BtnCastroEstoqueMenu
            // 
            this.BtnCastroEstoqueMenu.BackgroundImage = global::SistemaEstoque.Properties.Resources.celeiro1;
            this.BtnCastroEstoqueMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCastroEstoqueMenu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCastroEstoqueMenu.Location = new System.Drawing.Point(293, 95);
            this.BtnCastroEstoqueMenu.Name = "BtnCastroEstoqueMenu";
            this.BtnCastroEstoqueMenu.Size = new System.Drawing.Size(116, 101);
            this.BtnCastroEstoqueMenu.TabIndex = 10;
            this.BtnCastroEstoqueMenu.Text = "CASTRAR LOCAL DE ESTOQUE";
            this.BtnCastroEstoqueMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCastroEstoqueMenu.UseVisualStyleBackColor = true;
            this.BtnCastroEstoqueMenu.Click += new System.EventHandler(this.BtnCastroEstoqueMenu_Click);
            // 
            // BtnAlterarUsuarioMenu
            // 
            this.BtnAlterarUsuarioMenu.BackgroundImage = global::SistemaEstoque.Properties.Resources.alterar_usuario;
            this.BtnAlterarUsuarioMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAlterarUsuarioMenu.Location = new System.Drawing.Point(86, 264);
            this.BtnAlterarUsuarioMenu.Name = "BtnAlterarUsuarioMenu";
            this.BtnAlterarUsuarioMenu.Size = new System.Drawing.Size(116, 101);
            this.BtnAlterarUsuarioMenu.TabIndex = 9;
            this.BtnAlterarUsuarioMenu.Text = "ALTERAR USUÁRIO";
            this.BtnAlterarUsuarioMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAlterarUsuarioMenu.UseVisualStyleBackColor = true;
            this.BtnAlterarUsuarioMenu.Click += new System.EventHandler(this.BtnAlterarUsuarioMenu_Click);
            // 
            // BtnCastroMenu
            // 
            this.BtnCastroMenu.BackgroundImage = global::SistemaEstoque.Properties.Resources.cadastro;
            this.BtnCastroMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCastroMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCastroMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCastroMenu.Location = new System.Drawing.Point(86, 95);
            this.BtnCastroMenu.Name = "BtnCastroMenu";
            this.BtnCastroMenu.Size = new System.Drawing.Size(116, 101);
            this.BtnCastroMenu.TabIndex = 8;
            this.BtnCastroMenu.Text = "CADASTRAR PRODUTO";
            this.BtnCastroMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCastroMenu.UseVisualStyleBackColor = true;
            this.BtnCastroMenu.Click += new System.EventHandler(this.BtnCastroMenu_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SistemaEstoque.Properties.Resources.cara;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(696, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 66);
            this.panel2.TabIndex = 7;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(91)))), ((int)(((byte)(46)))));
            this.BackgroundImage = global::SistemaEstoque.Properties.Resources.fundo_sistema;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnSairMenu);
            this.Controls.Add(this.BtnCastroEstoqueMenu);
            this.Controls.Add(this.BtnAlterarUsuarioMenu);
            this.Controls.Add(this.BtnCastroMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(820, 490);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEJA BEM VINDO AO FRUIT MASTER - MENU PRINCIPAL";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaisDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOVIMENTAÇÃOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tROCARMUDARUSUÁRIOToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtnSairMenu;
        private System.Windows.Forms.Button BtnCastroEstoqueMenu;
        private System.Windows.Forms.Button BtnAlterarUsuarioMenu;
        private System.Windows.Forms.Button BtnCastroMenu;
        private System.Windows.Forms.Panel panel2;
    }
}

