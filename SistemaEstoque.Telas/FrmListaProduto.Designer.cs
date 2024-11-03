using System;

namespace SistemaEstoque.Telas
{
    partial class FrmListaProduto
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
            this.grd = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaEstoqueDataSet = new SistemaEstoque.Telas.SistemaEstoqueDataSet();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnExcluirProduto = new System.Windows.Forms.Button();
            this.BtnAlterarProduto = new System.Windows.Forms.Button();
            this.produtosTableAdapter = new SistemaEstoque.Telas.SistemaEstoqueDataSetTableAdapters.produtosTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaEstoqueDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.BtnFechar);
            this.panel1.Controls.Add(this.BtnNovo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 59);
            this.panel1.TabIndex = 0;
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
            this.BtnNovo.Text = "NOVO PRODUTO";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.grd);
            this.panel2.Controls.Add(this.TxtFiltro);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 311);
            this.panel2.TabIndex = 1;
            // 
            // grd
            // 
            this.grd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd.AutoGenerateColumns = false;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn});
            this.grd.DataSource = this.produtosBindingSource;
            this.grd.Location = new System.Drawing.Point(18, 68);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(463, 230);
            this.grd.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "peso";
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.sistemaEstoqueDataSet;
            // 
            // sistemaEstoqueDataSet
            // 
            this.sistemaEstoqueDataSet.DataSetName = "SistemaEstoqueDataSet";
            this.sistemaEstoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label1.Location = new System.Drawing.Point(12, 17);
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
            this.panel3.Controls.Add(this.BtnExcluirProduto);
            this.panel3.Controls.Add(this.BtnAlterarProduto);
            this.panel3.Location = new System.Drawing.Point(524, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 311);
            this.panel3.TabIndex = 2;
            // 
            // BtnExcluirProduto
            // 
            this.BtnExcluirProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluirProduto.Location = new System.Drawing.Point(29, 115);
            this.BtnExcluirProduto.Name = "BtnExcluirProduto";
            this.BtnExcluirProduto.Size = new System.Drawing.Size(135, 70);
            this.BtnExcluirProduto.TabIndex = 2;
            this.BtnExcluirProduto.Text = "EXCLUIR PRODUTO";
            this.BtnExcluirProduto.UseVisualStyleBackColor = true;
            this.BtnExcluirProduto.Click += new System.EventHandler(this.BtnExcluirProduto_Click);
            // 
            // BtnAlterarProduto
            // 
            this.BtnAlterarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlterarProduto.Location = new System.Drawing.Point(29, 17);
            this.BtnAlterarProduto.Name = "BtnAlterarProduto";
            this.BtnAlterarProduto.Size = new System.Drawing.Size(135, 70);
            this.BtnAlterarProduto.TabIndex = 1;
            this.BtnAlterarProduto.Text = "ALTERAR PRODUTO";
            this.BtnAlterarProduto.UseVisualStyleBackColor = true;
            this.BtnAlterarProduto.Click += new System.EventHandler(this.BtnAlterarProduto_Click);
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmListaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 400);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmListaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DE PRODUTOS";
            this.Load += new System.EventHandler(this.FrmListaProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaEstoqueDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void BtnExcluirProduto_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private System.Windows.Forms.DataGridView grd;
        private SistemaEstoqueDataSet sistemaEstoqueDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private SistemaEstoqueDataSetTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
    }
}