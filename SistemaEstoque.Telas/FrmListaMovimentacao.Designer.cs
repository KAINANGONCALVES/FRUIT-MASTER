using System;

namespace SistemaEstoque.Telas
{
    partial class FrmListaMovimentacao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnExcluirProduto = new System.Windows.Forms.Button();
            this.BtnAlterarProduto = new System.Windows.Forms.Button();
            this.produtosTableAdapter = new SistemaEstoque.Telas.SistemaEstoqueDataSetTableAdapters.produtosTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grdMovimentacao = new System.Windows.Forms.DataGridView();
            this.sistemaEstoqueDataSet7 = new SistemaEstoque.Telas.SistemaEstoqueDataSet7();
            this.movimentacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movimentacaoTableAdapter = new SistemaEstoque.Telas.SistemaEstoqueDataSet7TableAdapters.movimentacaoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlocalestoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datahoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saidaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovimentacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaEstoqueDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BtnFechar);
            this.panel1.Controls.Add(this.BtnNovo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 59);
            this.panel1.TabIndex = 0;
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackgroundImage = global::SistemaEstoque.Telas.Properties.Resources.seta_esquerda;
            this.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.Location = new System.Drawing.Point(139, -12);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(107, 71);
            this.BtnFechar.TabIndex = 1;
            this.BtnFechar.Text = "VOLTAR";
            this.BtnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNovo.Image = global::SistemaEstoque.Telas.Properties.Resources.cadastro;
            this.BtnNovo.Location = new System.Drawing.Point(15, -12);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(107, 71);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.Text = "NOVO PRODUTO";
            this.BtnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.grdMovimentacao);
            this.panel2.Controls.Add(this.TxtFiltro);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 318);
            this.panel2.TabIndex = 1;
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(15, 43);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(258, 20);
            this.TxtFiltro.TabIndex = 1;
            this.TxtFiltro.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o produto que Procura";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.BtnExcluirProduto);
            this.panel3.Controls.Add(this.BtnAlterarProduto);
            this.panel3.Location = new System.Drawing.Point(771, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 318);
            this.panel3.TabIndex = 2;
            // 
            // BtnExcluirProduto
            // 
            this.BtnExcluirProduto.BackgroundImage = global::SistemaEstoque.Telas.Properties.Resources.excluir;
            this.BtnExcluirProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnExcluirProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluirProduto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnExcluirProduto.Location = new System.Drawing.Point(32, 204);
            this.BtnExcluirProduto.Name = "BtnExcluirProduto";
            this.BtnExcluirProduto.Size = new System.Drawing.Size(132, 70);
            this.BtnExcluirProduto.TabIndex = 2;
            this.BtnExcluirProduto.Text = "EXCLUIR PRODUTO";
            this.BtnExcluirProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnExcluirProduto.UseVisualStyleBackColor = true;
            this.BtnExcluirProduto.Click += new System.EventHandler(this.BtnExcluirProduto_Click);
            // 
            // BtnAlterarProduto
            // 
            this.BtnAlterarProduto.BackgroundImage = global::SistemaEstoque.Telas.Properties.Resources.retomar;
            this.BtnAlterarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAlterarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlterarProduto.Location = new System.Drawing.Point(32, 68);
            this.BtnAlterarProduto.Name = "BtnAlterarProduto";
            this.BtnAlterarProduto.Size = new System.Drawing.Size(132, 70);
            this.BtnAlterarProduto.TabIndex = 1;
            this.BtnAlterarProduto.Text = "ALTERAR PRODUTO";
            this.BtnAlterarProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAlterarProduto.UseVisualStyleBackColor = true;
            this.BtnAlterarProduto.Click += new System.EventHandler(this.BtnAlterarProduto_Click);
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::SistemaEstoque.Telas.Properties.Resources.cara;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(861, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(104, 93);
            this.panel4.TabIndex = 2;
            // 
            // grdMovimentacao
            // 
            this.grdMovimentacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMovimentacao.AutoGenerateColumns = false;
            this.grdMovimentacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMovimentacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idprodutoDataGridViewTextBoxColumn,
            this.idlocalestoqueDataGridViewTextBoxColumn,
            this.datahoraDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.saidaDataGridViewCheckBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.grdMovimentacao.DataSource = this.movimentacaoBindingSource;
            this.grdMovimentacao.Location = new System.Drawing.Point(15, 69);
            this.grdMovimentacao.Name = "grdMovimentacao";
            this.grdMovimentacao.Size = new System.Drawing.Size(738, 249);
            this.grdMovimentacao.TabIndex = 2;
            // 
            // sistemaEstoqueDataSet7
            // 
            this.sistemaEstoqueDataSet7.DataSetName = "SistemaEstoqueDataSet7";
            this.sistemaEstoqueDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movimentacaoBindingSource
            // 
            this.movimentacaoBindingSource.DataMember = "movimentacao";
            this.movimentacaoBindingSource.DataSource = this.sistemaEstoqueDataSet7;
            // 
            // movimentacaoTableAdapter
            // 
            this.movimentacaoTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idprodutoDataGridViewTextBoxColumn
            // 
            this.idprodutoDataGridViewTextBoxColumn.DataPropertyName = "id_produto";
            this.idprodutoDataGridViewTextBoxColumn.HeaderText = "id_produto";
            this.idprodutoDataGridViewTextBoxColumn.Name = "idprodutoDataGridViewTextBoxColumn";
            // 
            // idlocalestoqueDataGridViewTextBoxColumn
            // 
            this.idlocalestoqueDataGridViewTextBoxColumn.DataPropertyName = "id_localestoque";
            this.idlocalestoqueDataGridViewTextBoxColumn.HeaderText = "id_localestoque";
            this.idlocalestoqueDataGridViewTextBoxColumn.Name = "idlocalestoqueDataGridViewTextBoxColumn";
            // 
            // datahoraDataGridViewTextBoxColumn
            // 
            this.datahoraDataGridViewTextBoxColumn.DataPropertyName = "datahora";
            this.datahoraDataGridViewTextBoxColumn.HeaderText = "datahora";
            this.datahoraDataGridViewTextBoxColumn.Name = "datahoraDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // saidaDataGridViewCheckBoxColumn
            // 
            this.saidaDataGridViewCheckBoxColumn.DataPropertyName = "saida";
            this.saidaDataGridViewCheckBoxColumn.HeaderText = "saida";
            this.saidaDataGridViewCheckBoxColumn.Name = "saidaDataGridViewCheckBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // FrmListaMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(91)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(962, 407);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmListaMovimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRUIT MASTER - LISTA MOVIMENTAÇÃO";
            this.Load += new System.EventHandler(this.FrmListaMovimentacao_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMovimentacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaEstoqueDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

     

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnAlterarProduto;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnExcluirProduto;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Label label1;
        private SistemaEstoqueDataSetTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView grdMovimentacao;
        private SistemaEstoqueDataSet7 sistemaEstoqueDataSet7;
        private System.Windows.Forms.BindingSource movimentacaoBindingSource;
        private SistemaEstoqueDataSet7TableAdapters.movimentacaoTableAdapter movimentacaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlocalestoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datahoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn saidaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}