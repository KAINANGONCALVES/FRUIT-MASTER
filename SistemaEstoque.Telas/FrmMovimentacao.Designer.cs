namespace SistemaEstoque.Telas
{
    partial class FrmMovimentacao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdProduto = new System.Windows.Forms.TextBox();
            this.TxtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.BtnPesquisaLocalEstoque = new System.Windows.Forms.Button();
            this.BntPesquisarProduto = new System.Windows.Forms.Button();
            this.dtpDataHora = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ChkSaida = new System.Windows.Forms.CheckBox();
            this.TxtIdLocalEstoque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.BtnFechar);
            this.panel1.Controls.Add(this.BtnSalvar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 78);
            this.panel1.TabIndex = 0;
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackgroundImage = global::SistemaEstoque.Telas.Properties.Resources.seta_esquerda;
            this.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.Location = new System.Drawing.Point(175, 0);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(100, 78);
            this.BtnFechar.TabIndex = 1;
            this.BtnFechar.Text = "VOLTAR";
            this.BtnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackgroundImage = global::SistemaEstoque.Telas.Properties.Resources.verificar;
            this.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.Location = new System.Drawing.Point(13, 0);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(100, 78);
            this.BtnSalvar.TabIndex = 0;
            this.BtnSalvar.Text = "SALVAR";
            this.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(22, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DIGITE O NOME DO PRODUTO";
            // 
            // TxtIdProduto
            // 
            this.TxtIdProduto.Location = new System.Drawing.Point(25, 149);
            this.TxtIdProduto.Name = "TxtIdProduto";
            this.TxtIdProduto.Size = new System.Drawing.Size(294, 20);
            this.TxtIdProduto.TabIndex = 2;
            // 
            // TxtDescricaoProduto
            // 
            this.TxtDescricaoProduto.Location = new System.Drawing.Point(22, 406);
            this.TxtDescricaoProduto.Name = "TxtDescricaoProduto";
            this.TxtDescricaoProduto.Size = new System.Drawing.Size(240, 20);
            this.TxtDescricaoProduto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(22, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DIGITE UMA DESCRIÇÃO DA MOVIMENTAÇÃO";
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Location = new System.Drawing.Point(25, 322);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(159, 20);
            this.TxtQuantidade.TabIndex = 6;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Label3.Location = new System.Drawing.Point(27, 294);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(206, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "DIGITE A QUANTIDADE  DO PRODUTO";
            // 
            // BtnPesquisaLocalEstoque
            // 
            this.BtnPesquisaLocalEstoque.BackColor = System.Drawing.Color.Transparent;
            this.BtnPesquisaLocalEstoque.BackgroundImage = global::SistemaEstoque.Telas.Properties.Resources.lupa;
            this.BtnPesquisaLocalEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPesquisaLocalEstoque.Location = new System.Drawing.Point(338, 231);
            this.BtnPesquisaLocalEstoque.Name = "BtnPesquisaLocalEstoque";
            this.BtnPesquisaLocalEstoque.Size = new System.Drawing.Size(35, 31);
            this.BtnPesquisaLocalEstoque.TabIndex = 8;
            this.BtnPesquisaLocalEstoque.UseVisualStyleBackColor = false;
            this.BtnPesquisaLocalEstoque.Click += new System.EventHandler(this.BtnPesquisaLocalEstoque_Click);
            // 
            // BntPesquisarProduto
            // 
            this.BntPesquisarProduto.BackColor = System.Drawing.Color.Transparent;
            this.BntPesquisarProduto.BackgroundImage = global::SistemaEstoque.Telas.Properties.Resources.lupa;
            this.BntPesquisarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BntPesquisarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BntPesquisarProduto.Location = new System.Drawing.Point(338, 143);
            this.BntPesquisarProduto.Name = "BntPesquisarProduto";
            this.BntPesquisarProduto.Size = new System.Drawing.Size(35, 31);
            this.BntPesquisarProduto.TabIndex = 7;
            this.BntPesquisarProduto.UseVisualStyleBackColor = false;
            this.BntPesquisarProduto.Click += new System.EventHandler(this.BntPesquisarProduto_Click);
            // 
            // dtpDataHora
            // 
            this.dtpDataHora.CustomFormat = "dd/HH/yyyy - HH:mm:ss";
            this.dtpDataHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataHora.Location = new System.Drawing.Point(434, 187);
            this.dtpDataHora.Name = "dtpDataHora";
            this.dtpDataHora.Size = new System.Drawing.Size(148, 20);
            this.dtpDataHora.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(431, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "SELECIONE A DATA E A HORA ";
            // 
            // ChkSaida
            // 
            this.ChkSaida.AutoSize = true;
            this.ChkSaida.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ChkSaida.Location = new System.Drawing.Point(434, 237);
            this.ChkSaida.Name = "ChkSaida";
            this.ChkSaida.Size = new System.Drawing.Size(58, 17);
            this.ChkSaida.TabIndex = 11;
            this.ChkSaida.Text = "SAIDA";
            this.ChkSaida.UseVisualStyleBackColor = false;
            // 
            // TxtIdLocalEstoque
            // 
            this.TxtIdLocalEstoque.Location = new System.Drawing.Point(22, 237);
            this.TxtIdLocalEstoque.Name = "TxtIdLocalEstoque";
            this.TxtIdLocalEstoque.Size = new System.Drawing.Size(297, 20);
            this.TxtIdLocalEstoque.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(27, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "DIGITE O NOME DO LOCAL DE ESTOQUE";
            // 
            // FrmMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(91)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(656, 472);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtIdLocalEstoque);
            this.Controls.Add(this.ChkSaida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDataHora);
            this.Controls.Add(this.BtnPesquisaLocalEstoque);
            this.Controls.Add(this.BntPesquisarProduto);
            this.Controls.Add(this.TxtQuantidade);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TxtDescricaoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIdProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMovimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRUIT MASTER - CADASTRO DE MOVIMENTAÇÃO";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdProduto;
        private System.Windows.Forms.TextBox TxtDescricaoProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Button BntPesquisarProduto;
        private System.Windows.Forms.Button BtnPesquisaLocalEstoque;
        private System.Windows.Forms.DateTimePicker dtpDataHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ChkSaida;
        private System.Windows.Forms.TextBox TxtIdLocalEstoque;
        private System.Windows.Forms.Label label5;
    }
}