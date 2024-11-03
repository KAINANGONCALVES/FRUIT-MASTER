using System;
using System.Windows.Forms;

namespace SistemaEstoque.Telas
{
    public partial class FrmProdutos : Form
    {
        private bool EstaAlterando = false;
        private Banco.tbProduto Produto;

        public FrmProdutos(bool estaAlterando, Banco.tbProduto produto)
        {
            InitializeComponent();

            this.EstaAlterando = estaAlterando;
            this.Produto = produto;

            if (this.EstaAlterando)
            {
                TxtNomeProduto.Text = Produto.nome;
                TxtDescricaoProduto.Text = Produto.descricao;
                TxtPesoProduto.Text = Produto.peso.ToString();
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
                UpdateProduto();
            }
            else
            {
                InsertProduto();
            }

            MessageBox.Show("Produto salvo com sucesso.");
            this.Close();
        }

        private bool ValidateInputs()
        {
            return !string.IsNullOrWhiteSpace(TxtNomeProduto.Text) &&
                   !string.IsNullOrWhiteSpace(TxtDescricaoProduto.Text) &&
                   decimal.TryParse(TxtPesoProduto.Text, out _);
        }

        private void UpdateProduto()
        {
            this.Produto.nome = TxtNomeProduto.Text;
            this.Produto.descricao = TxtDescricaoProduto.Text;
            this.Produto.peso = Convert.ToDecimal(TxtPesoProduto.Text);
            this.Produto.Alterar();
        }

        private void InsertProduto()
        {
            this.Produto = new Banco.tbProduto
            {
                nome = TxtNomeProduto.Text,
                descricao = TxtDescricaoProduto.Text
            };
            this.Produto.peso = Convert.ToDecimal(TxtPesoProduto.Text);
            this.Produto.Inserir();
        }
    }
}
