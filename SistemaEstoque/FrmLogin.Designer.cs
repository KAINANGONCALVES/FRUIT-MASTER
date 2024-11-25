namespace SistemaEstoque
{
    partial class FrmLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(20, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUÁRIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(38, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "SENHA:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(113, 105);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(196, 20);
            this.TxtUsuario.TabIndex = 3;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(113, 143);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '#';
            this.TxtSenha.Size = new System.Drawing.Size(196, 20);
            this.TxtSenha.TabIndex = 4;
            this.TxtSenha.UseSystemPasswordChar = true;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEntrar.Location = new System.Drawing.Point(113, 184);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(78, 23);
            this.BtnEntrar.TabIndex = 5;
            this.BtnEntrar.Text = "ENTRAR";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnFechar.Location = new System.Drawing.Point(231, 184);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(78, 23);
            this.BtnFechar.TabIndex = 6;
            this.BtnFechar.Text = "FECHAR";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::SistemaEstoque.Properties.Resources.cara;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(164, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 76);
            this.panel1.TabIndex = 7;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEstoque.Properties.Resources.fundo_sistema;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(409, 230);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(425, 269);
            this.MinimumSize = new System.Drawing.Size(425, 269);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRUIT MASTER - LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Panel panel1;
    }
}