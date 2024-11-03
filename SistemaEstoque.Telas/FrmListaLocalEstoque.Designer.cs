namespace SistemaEstoque.Telas
{
    partial class FrmListaLocalEstoque
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnExcluirLocaldeEstoque = new System.Windows.Forms.Button();
            this.BtnAlterarLocaldeEstoque = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdLocalEstoque = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localestoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaEstoqueDataSet2 = new SistemaEstoque.Telas.SistemaEstoqueDataSet2();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.localestoqueTableAdapter = new SistemaEstoque.Telas.SistemaEstoqueDataSet2TableAdapters.localestoqueTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLocalEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localestoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaEstoqueDataSet2)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            this.BtnNovo.Text = "NOVO LOCAL ESTOQUE";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.BtnExcluirLocaldeEstoque);
            this.panel3.Controls.Add(this.BtnAlterarLocaldeEstoque);
            this.panel3.Location = new System.Drawing.Point(536, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 311);
            this.panel3.TabIndex = 3;
            // 
            // BtnExcluirLocaldeEstoque
            // 
            this.BtnExcluirLocaldeEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluirLocaldeEstoque.Location = new System.Drawing.Point(29, 115);
            this.BtnExcluirLocaldeEstoque.Name = "BtnExcluirLocaldeEstoque";
            this.BtnExcluirLocaldeEstoque.Size = new System.Drawing.Size(135, 70);
            this.BtnExcluirLocaldeEstoque.TabIndex = 2;
            this.BtnExcluirLocaldeEstoque.Text = "EXCLUIR LOCAL DE ESTOQUE";
            this.BtnExcluirLocaldeEstoque.UseVisualStyleBackColor = true;
            // 
            // BtnAlterarLocaldeEstoque
            // 
            this.BtnAlterarLocaldeEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlterarLocaldeEstoque.Location = new System.Drawing.Point(29, 17);
            this.BtnAlterarLocaldeEstoque.Name = "BtnAlterarLocaldeEstoque";
            this.BtnAlterarLocaldeEstoque.Size = new System.Drawing.Size(135, 70);
            this.BtnAlterarLocaldeEstoque.TabIndex = 1;
            this.BtnAlterarLocaldeEstoque.Text = "ALTERAR LOCAL DE ESTOQUE";
            this.BtnAlterarLocaldeEstoque.UseVisualStyleBackColor = true;
            this.BtnAlterarLocaldeEstoque.Click += new System.EventHandler(this.BtnAlterarLocaldeEstoque_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.grdLocalEstoque);
            this.panel2.Controls.Add(this.TxtFiltro);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 311);
            this.panel2.TabIndex = 4;
            // 
            // grdLocalEstoque
            // 
            this.grdLocalEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdLocalEstoque.AutoGenerateColumns = false;
            this.grdLocalEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLocalEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.grdLocalEstoque.DataSource = this.localestoqueBindingSource;
            this.grdLocalEstoque.Location = new System.Drawing.Point(15, 59);
            this.grdLocalEstoque.Name = "grdLocalEstoque";
            this.grdLocalEstoque.Size = new System.Drawing.Size(503, 239);
            this.grdLocalEstoque.TabIndex = 2;
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
            // localestoqueBindingSource
            // 
            this.localestoqueBindingSource.DataMember = "localestoque";
            this.localestoqueBindingSource.DataSource = this.sistemaEstoqueDataSet2;
            // 
            // sistemaEstoqueDataSet2
            // 
            this.sistemaEstoqueDataSet2.DataSetName = "SistemaEstoqueDataSet2";
            this.sistemaEstoqueDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE O LOCAL DE ESTOQUE";
            // 
            // localestoqueTableAdapter
            // 
            this.localestoqueTableAdapter.ClearBeforeFill = true;
            // 
            // FrmListaLocalEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmListaLocalEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DE LOCAIS DE ESTOQUE";
            this.Load += new System.EventHandler(this.FrmListaLocalEstoque_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLocalEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localestoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaEstoqueDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnExcluirLocaldeEstoque;
        private System.Windows.Forms.Button BtnAlterarLocaldeEstoque;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdLocalEstoque;
        private SistemaEstoqueDataSet2 sistemaEstoqueDataSet2;
        private System.Windows.Forms.BindingSource localestoqueBindingSource;
        private SistemaEstoqueDataSet2TableAdapters.localestoqueTableAdapter localestoqueTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    }
}