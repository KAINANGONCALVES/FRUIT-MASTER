using SistemaEstoque.Banco;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaEstoque.Telas
{
    public partial class FrmMovimentacao : Form
    {
        private bool EstaAlterando;
        private tbMovimentacao Movimentacao;

        public FrmMovimentacao(bool estaAlterando, tbMovimentacao movimentacao)
        {
            InitializeComponent();
            this.EstaAlterando = estaAlterando;
            this.Movimentacao = movimentacao;
        }

        private void FrmMovimentacao_Load(object sender, EventArgs e)
        {
            // Carrega os dados nos ComboBoxes
            this.produtosTableAdapter1.Fill(this.sistemaEstoqueDataSet6.produtos);
            this.localestoqueTableAdapter.Fill(this.sistemaEstoqueDataSet5.localestoque);

            // Se estamos alterando, carregar os dados nos controles
            if (this.EstaAlterando && this.Movimentacao != null)
            {
                LoadMovimentacaoData();
            }

            // Verifica se o CmbProduto está preenchido
            if (CmbProduto.Items.Count == 0)
            {
                MessageBox.Show("Nenhum produto encontrado. Por favor, adicione produtos antes de realizar uma movimentação.");
            }
        }

        private void LoadMovimentacaoData()
        {
            TxtDescricao.Text = this.Movimentacao.descricao;
            TxtQuantidade.Text = this.Movimentacao.quantidade.ToString();
            chkSaida.Checked = this.Movimentacao.saida;
            dtpDataHora.Value = this.Movimentacao.datahora;

            if (CmbProduto.DataSource != null && CmbProduto.Items.Count > 0)
            {
                CmbProduto.SelectedValue = this.Movimentacao.id_produto;
            }
            if (CmbLocalEstoque.DataSource != null && CmbLocalEstoque.Items.Count > 0)
            {
                CmbLocalEstoque.SelectedValue = this.Movimentacao.id_localestoque;
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

            // Debug para verificar valores selecionados
            MessageBox.Show($"Produto selecionado: {CmbProduto.SelectedValue} (Tipo: {CmbProduto.SelectedValue?.GetType()})");
            MessageBox.Show($"Local de estoque selecionado: {CmbLocalEstoque.SelectedValue} (Tipo: {CmbLocalEstoque.SelectedValue?.GetType()})");

            try
            {
                if (this.EstaAlterando)
                {
                    UpdateMovimentacao();
                }
                else
                {
                    InsertMovimentacao();
                }

                MessageBox.Show("Movimentação salva com sucesso.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar movimentação: " + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private bool ValidateInputs()
        {
            bool validProduct = CmbProduto.SelectedValue != null && int.TryParse(CmbProduto.SelectedValue.ToString(), out _);
            bool validLocation = CmbLocalEstoque.SelectedValue != null && int.TryParse(CmbLocalEstoque.SelectedValue.ToString(), out _);

            if (!validProduct)
            {
                MessageBox.Show("Por favor, selecione um produto válido.");
                return false; // Retorna false se não for válido
            }

            if (!validLocation)
            {
                MessageBox.Show("Por favor, selecione um local de estoque válido.");
                return false; // Retorna false se não for válido
            }

            return !string.IsNullOrWhiteSpace(TxtDescricao.Text) &&
                   int.TryParse(TxtQuantidade.Text, out _); // Verifica se a quantidade é um número
        }

        private void UpdateMovimentacao()
        {
            this.Movimentacao.descricao = TxtDescricao.Text;

            // Verifica se a quantidade é um número antes de atribuir
            if (!int.TryParse(TxtQuantidade.Text, out int quantidade))
            {
                MessageBox.Show("Quantidade deve ser um número válido.");
                return;
            }
            this.Movimentacao.quantidade = quantidade;

            this.Movimentacao.saida = chkSaida.Checked;
            this.Movimentacao.datahora = dtpDataHora.Value;

            // Certifique-se de que os valores selecionados são válidos
            if (CmbProduto.SelectedValue != null && CmbLocalEstoque.SelectedValue != null)
            {
                this.Movimentacao.id_produto = Convert.ToInt32(CmbProduto.SelectedValue);
                this.Movimentacao.id_localestoque = Convert.ToInt32(CmbLocalEstoque.SelectedValue);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um produto e um local de estoque.");
                return;
            }

            this.Movimentacao.alterar();
        }

        private void InsertMovimentacao()
        {
            if (string.IsNullOrWhiteSpace(TxtDescricao.Text))
            {
                MessageBox.Show("A descrição não pode estar vazia.");
                return;
            }

            if (!int.TryParse(TxtQuantidade.Text, out int quantidade))
            {
                MessageBox.Show("Quantidade deve ser um número válido.");
                return;
            }

            int idProduto = Convert.ToInt32(CmbProduto.SelectedValue);
            int idLocalEstoque = Convert.ToInt32(CmbLocalEstoque.SelectedValue);

            // Verificação dos IDs antes da inserção
            if (!ValidateForeignKeys(idProduto, idLocalEstoque))
            {
                return; // Não prossegue se a validação falhar
            }

            var novaMovimentacao = new tbMovimentacao
            {
                descricao = TxtDescricao.Text,
                quantidade = quantidade,
                saida = chkSaida.Checked,
                datahora = dtpDataHora.Value,
                id_produto = idProduto,
                id_localestoque = idLocalEstoque
            };

            novaMovimentacao.inserir();
        }

        private bool ValidateForeignKeys(int idProduto, int idLocalEstoque)
        {
            using (var connection = new SqlConnection("sua_string_de_conexao"))
            {
                connection.Open();

                // Verifica se o produto existe
                using (var command = new SqlCommand("SELECT COUNT(*) FROM produtos WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", idProduto);
                    int count = (int)command.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Produto não encontrado.");
                        return false;
                    }
                }

                // Verifica se o local de estoque existe
                using (var command = new SqlCommand("SELECT COUNT(*) FROM localestoque WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", idLocalEstoque);
                    int count = (int)command.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Local de estoque não encontrado.");
                        return false;
                    }
                }
            }
            return true; // Ambos os IDs existem
        }
    }
}
