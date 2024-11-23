using System;
using System.Windows.Forms;

namespace SistemaEstoque.Telas
{
    public partial class FrmMovimentacao : Form
    {
        private bool EstaAlterando = false;
        private Banco.tbMovimentacao Movimentacao;

        public FrmMovimentacao(bool estaAlterando, Banco.tbMovimentacao movimentacao)
        {
            InitializeComponent();

            this.EstaAlterando = estaAlterando;
            this.Movimentacao = movimentacao;

            if (this.EstaAlterando)
            {
                // Preenchendo os campos do formulário ao alterar
                TxtIdProduto.Text = Movimentacao.id_produto.ToString();
                TxtIdLocalEstoque.Text = Movimentacao.id_localestoque.ToString();
                TxtQuantidade.Text = Movimentacao.quantidade.ToString();

                // Verificando se Movimentacao.datahora() é válido
                if (Movimentacao.datahora != null)
                {
                    dtpDataHora.Value = Movimentacao.datahora;
                }
                else
                {
                    dtpDataHora.Value = DateTime.Now; // Valor padrão em caso de nulo
                }

                TxtDescricaoProduto.Text = Movimentacao.descricao; // Corrigido uso da propriedade Text
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
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (this.EstaAlterando)
                {
                    UpdateMovimentacao(); // Atualizando movimentação
                }
                else
                {
                    InsertMovimentacao(); // Inserindo nova movimentação
                }

                MessageBox.Show("Movimentação salva com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar movimentação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            // Validação dos campos
            return !string.IsNullOrWhiteSpace(TxtIdProduto.Text) &&
                   !string.IsNullOrWhiteSpace(TxtIdLocalEstoque.Text) &&
                   !string.IsNullOrWhiteSpace(TxtDescricaoProduto.Text) &&
                   decimal.TryParse(TxtQuantidade.Text, out _) &&
                   dtpDataHora.Value != null;
        }

        private void UpdateMovimentacao()
        {
            // Atualizando os dados da movimentação
            this.Movimentacao.id_produto = Convert.ToInt32(TxtIdProduto.Text);
            this.Movimentacao.id_localestoque = Convert.ToInt32(TxtIdLocalEstoque.Text);
            this.Movimentacao.quantidade = Convert.ToDecimal(TxtQuantidade.Text);
            this.Movimentacao.datahora = dtpDataHora.Value;
            this.Movimentacao.descricao = TxtDescricaoProduto.Text;

            // Método para salvar alterações no banco
            this.Movimentacao.Alterar();
        }

        private void InsertMovimentacao()
        {
            // Criando uma nova movimentação
            this.Movimentacao = new Banco.tbMovimentacao
            {
                id_produto = Convert.ToInt32(TxtIdProduto.Text),
                id_localestoque = Convert.ToInt32(TxtIdLocalEstoque.Text),
                quantidade = Convert.ToDecimal(TxtQuantidade.Text),
                datahora = dtpDataHora.Value,
                descricao = TxtDescricaoProduto.Text
            };

            // Método para inserir nova movimentação no banco
            this.Movimentacao.Inserir();
        }

        private void BntPesquisarProduto_Click(object sender, EventArgs e)
        {
            // Abrindo o formulário de pesquisa de produtos
            using (var frm = new SistemaEstoque.Telas.FrmListaProduto())
            {
                frm.ShowDialog();

                // Aqui você pode adicionar lógica para capturar o produto selecionado
                if (frm.ProdutoSelecionado != null)
                {
                    TxtIdProduto.Text = frm.ProdutoSelecionado.id.ToString();
                    TxtDescricaoProduto.Text = frm.ProdutoSelecionado.descricao;
                }
            }
        }

        private void BtnPesquisaLocalEstoque_Click(object sender, EventArgs e)
        {
            // Abrindo o formulário de pesquisa de locais de estoque
            using (var frm = new SistemaEstoque.Telas.FrmListaLocalEstoque())
            {
                frm.ShowDialog();

                // Aqui você pode adicionar lógica para capturar o local de estoque selecionado
                if (frm.LocalEstoqueSelecionado != null)
                {
                    TxtIdLocalEstoque.Text = frm.LocalEstoqueSelecionado.ToString();
                }
            }
        }
    }
}
