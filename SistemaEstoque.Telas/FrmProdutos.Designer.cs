namespace SistemaEstoque.Telas
{
    partial class FrmProdutos
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
            this.TxtNomeProduto = new System.Windows.Forms.TextBox();
            this.TxtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPesoProduto = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(520, 78);
            this.panel1.TabIndex = 0;
            // 
            // BtnFechar
            // 
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.Location = new System.Drawing.Point(138, 13);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(100, 53);
            this.BtnFechar.TabIndex = 1;
            this.BtnFechar.Text = "FECHAR";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.Location = new System.Drawing.Point(13, 13);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(100, 53);
            this.BtnSalvar.TabIndex = 0;
            this.BtnSalvar.Text = "SALVAR";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DIGITE O NOME DO PRODUTO";
            // 
            // TxtNomeProduto
            // 
            this.TxtNomeProduto.Location = new System.Drawing.Point(25, 145);
            this.TxtNomeProduto.Name = "TxtNomeProduto";
            this.TxtNomeProduto.Size = new System.Drawing.Size(294, 20);
            this.TxtNomeProduto.TabIndex = 2;
            // 
            // TxtDescricaoProduto
            // 
            this.TxtDescricaoProduto.Location = new System.Drawing.Point(25, 214);
            this.TxtDescricaoProduto.Name = "TxtDescricaoProduto";
            this.TxtDescricaoProduto.Size = new System.Drawing.Size(294, 20);
            this.TxtDescricaoProduto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DIGITE A DESCRIÇÃO DO PRODUTO";
            // 
            // TxtPesoProduto
            // 
            this.TxtPesoProduto.Location = new System.Drawing.Point(25, 285);
            this.TxtPesoProduto.Name = "TxtPesoProduto";
            this.TxtPesoProduto.Size = new System.Drawing.Size(294, 20);
            this.TxtPesoProduto.TabIndex = 6;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(22, 258);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(162, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "DIGITE O PESO DO PRODUTO";
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 351);
            this.Controls.Add(this.TxtPesoProduto);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TxtDescricaoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNomeProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNomeProduto;
        private System.Windows.Forms.TextBox TxtDescricaoProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPesoProduto;
        private System.Windows.Forms.Label Label3;
    }
}