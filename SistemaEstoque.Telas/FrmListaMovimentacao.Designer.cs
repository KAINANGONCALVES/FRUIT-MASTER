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
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdMovimentacao = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlocalestoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datahoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saidaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movimentacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaEstoqueDataSet3 = new SistemaEstoque.Telas.SistemaEstoqueDataSet3();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.movimentacaoTableAdapter = new SistemaEstoque.Telas.SistemaEstoqueDataSet3TableAdapters.movimentacaoTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnExcluirMovimentacao = new System.Windows.Forms.Button();
            this.BtnAlterarMovimentacao = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovimentacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaEstoqueDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.grdMovimentacao);
            this.panel2.Controls.Add(this.TxtFiltro);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 311);
            this.panel2.TabIndex = 7;
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
            this.grdMovimentacao.Location = new System.Drawing.Point(15, 59);
            this.grdMovimentacao.Name = "grdMovimentacao";
            this.grdMovimentacao.Size = new System.Drawing.Size(770, 239);
            this.grdMovimentacao.TabIndex = 2;
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
            // movimentacaoBindingSource
            // 
            this.movimentacaoBindingSource.DataMember = "movimentacao";
            this.movimentacaoBindingSource.DataSource = this.sistemaEstoqueDataSet3;
            // 
            // sistemaEstoqueDataSet3
            // 
            this.sistemaEstoqueDataSet3.DataSetName = "SistemaEstoqueDataSet3";
            this.sistemaEstoqueDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(15, 33);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(258, 20);
            this.TxtFiltro.TabIndex = 1;
            this.TxtFiltro.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE E MOVIMENTAÇÃO PARA FILTRAR";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.BtnFechar);
            this.panel1.Controls.Add(this.BtnNovo);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 59);
            this.panel1.TabIndex = 5;
            // 
            // BtnFechar
            // 
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.Location = new System.Drawing.Point(139, 3);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(107, 53);
            this.BtnFechar.TabIndex = 1;
            this.BtnFechar.Text = "FECHAR";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNovo.Location = new System.Drawing.Point(15, 3);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(107, 53);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.Text = "NOVA MOVIMENTAÇÃO";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // movimentacaoTableAdapter
            // 
            this.movimentacaoTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.BtnExcluirMovimentacao);
            this.panel3.Controls.Add(this.BtnAlterarMovimentacao);
            this.panel3.Location = new System.Drawing.Point(835, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 311);
            this.panel3.TabIndex = 7;
            // 
            // BtnExcluirMovimentacao
            // 
            this.BtnExcluirMovimentacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluirMovimentacao.Location = new System.Drawing.Point(17, 115);
            this.BtnExcluirMovimentacao.Name = "BtnExcluirMovimentacao";
            this.BtnExcluirMovimentacao.Size = new System.Drawing.Size(135, 70);
            this.BtnExcluirMovimentacao.TabIndex = 2;
            this.BtnExcluirMovimentacao.Text = "EXLUIR MOVIMENTAÇÃO";
            this.BtnExcluirMovimentacao.UseVisualStyleBackColor = true;
            // 
            // BtnAlterarMovimentacao
            // 
            this.BtnAlterarMovimentacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlterarMovimentacao.Location = new System.Drawing.Point(17, 17);
            this.BtnAlterarMovimentacao.Name = "BtnAlterarMovimentacao";
            this.BtnAlterarMovimentacao.Size = new System.Drawing.Size(135, 70);
            this.BtnAlterarMovimentacao.TabIndex = 1;
            this.BtnAlterarMovimentacao.Text = "ALTERAR MOVIMENTAÇÃO";
            this.BtnAlterarMovimentacao.UseVisualStyleBackColor = true;
            // 
            // FrmListaMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 400);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmListaMovimentacao";
            this.Text = "LISTA DE MOVIMENTÇÃO ";
            this.Load += new System.EventHandler(this.FrmListaMovimentacao_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovimentacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaEstoqueDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdMovimentacao;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnNovo;
        private SistemaEstoqueDataSet3 sistemaEstoqueDataSet3;
        private System.Windows.Forms.BindingSource movimentacaoBindingSource;
        private SistemaEstoqueDataSet3TableAdapters.movimentacaoTableAdapter movimentacaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlocalestoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datahoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn saidaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnExcluirMovimentacao;
        private System.Windows.Forms.Button BtnAlterarMovimentacao;
    }
}