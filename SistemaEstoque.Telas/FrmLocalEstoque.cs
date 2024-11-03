using SistemaEstoque.Banco;
using System;
using System.Windows.Forms;

namespace SistemaEstoque.Telas
{
    public partial class FrmLocalEstoque : Form
    {
        private bool EstaAlterando;
        private tbLocalEstoque localEstoque;

        public FrmLocalEstoque(bool estaAlterando, tbLocalEstoque localEstoque)
        {
            InitializeComponent();
            this.EstaAlterando = estaAlterando;
            this.localEstoque = localEstoque;

            if (this.EstaAlterando)
            {
                TxtNomeLocalEstoque.Text = localEstoque.Nome;
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.");
                return;
            }

            if (this.EstaAlterando)
            {
                UpdateLocalEstoque();
            }
            else
            {
                InsertLocalEstoque();
            }

            MessageBox.Show("Local de estoque salvo com sucesso.");
            this.Close();
        }

        private bool ValidateInputs()
        {
            return !string.IsNullOrWhiteSpace(TxtNomeLocalEstoque.Text);
        }

        private void UpdateLocalEstoque()
        {
            this.localEstoque.Nome = TxtNomeLocalEstoque.Text;
            this.localEstoque.alterar();
        }

        private void InsertLocalEstoque()
        {
            this.localEstoque = new tbLocalEstoque
            {
                Nome = TxtNomeLocalEstoque.Text,
            };

            this.localEstoque.inserir();
        }
    }
}
