namespace SistemaEstoque.Telas
{
    partial class FrmLocalEstoque
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
            this.TxtNomeLocalEstoque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 1;
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackgroundImage = global::SistemaEstoque.Telas.Properties.Resources.seta_esquerda;
            this.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.Location = new System.Drawing.Point(138, 0);
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
            // TxtNomeLocalEstoque
            // 
            this.TxtNomeLocalEstoque.Location = new System.Drawing.Point(15, 151);
            this.TxtNomeLocalEstoque.Name = "TxtNomeLocalEstoque";
            this.TxtNomeLocalEstoque.Size = new System.Drawing.Size(294, 20);
            this.TxtNomeLocalEstoque.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(22, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DIGITE O NOME DO LOCAL DE ESTOQUE";
            // 
            // FrmLocalEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(91)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(544, 217);
            this.Controls.Add(this.TxtNomeLocalEstoque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLocalEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLocalEstoque";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox TxtNomeLocalEstoque;
        private System.Windows.Forms.Label label1;
    }
}