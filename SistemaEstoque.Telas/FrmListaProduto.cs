using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaEstoque.Telas
{
    public partial class FrmListaProduto : Form
    {
        private DataTable dtGrid = new DataTable();
        private BindingSource bsGrid = new BindingSource();

        public Banco.tbProduto ProdutoSelecionado { get; private set; } // Alterado para tipagem correta

        public FrmListaProduto()
        {
            InitializeComponent();
        }

        private void FrmListaProduto_Load(object sender, EventArgs e)
        {
            try
            {
                // Carrega dados na tabela 'sistemaEstoqueDataSet.produtos'
                this.produtosTableAdapter.Fill(this.sistemaEstoqueDataSet.produtos);
                bsGrid.DataSource = this.sistemaEstoqueDataSet.produtos; // Vincula o DataSource
                grd.DataSource = bsGrid; // Define a grid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsGrid.Filter = $"nome LIKE '%{TxtFiltro.Text}%'"; // Adicionado interpolação para maior clareza
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao aplicar filtro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmProdutos frm = new FrmProdutos(false, null)) // Usando 'using' para liberar recursos
                {
                    frm.ShowDialog();

                    // Recarrega os dados após a adição de um novo produto
                    this.produtosTableAdapter.Fill(this.sistemaEstoqueDataSet.produtos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar novo produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAlterarProduto_Click(object sender, EventArgs e)
        {
            if (bsGrid.Current == null)
            {
                MessageBox.Show("Nenhum produto selecionado para alteração.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataRowView drv = (DataRowView)bsGrid.Current; // Obtém a linha selecionada

                Banco.tbProduto produto = new Banco.tbProduto
                {
                    id = Convert.ToInt32(drv["id"]),
                    nome = drv["nome"].ToString(),
                    descricao = drv["descricao"].ToString(),
                    peso = Convert.ToDecimal(drv["peso"])
                };

                using (FrmProdutos frm = new FrmProdutos(true, produto))
                {
                    frm.ShowDialog();

                    // Atualiza a grid após fechar o formulário de edição
                    this.produtosTableAdapter.Fill(this.sistemaEstoqueDataSet.produtos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (bsGrid.Current == null)
            {
                MessageBox.Show("Por favor, selecione um produto para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataRowView drv = (DataRowView)bsGrid.Current;
                int produtoId = Convert.ToInt32(drv["id"]);

                var confirmResult = MessageBox.Show(
                    $"Tem certeza de que deseja excluir o produto '{drv["nome"]}'?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    Banco.tbProduto produto = new Banco.tbProduto { id = produtoId };

                    Banco.tbProduto.Excluir(produto); // Método para realizar a exclusão no banco

                    this.produtosTableAdapter.Fill(this.sistemaEstoqueDataSet.produtos);

                    MessageBox.Show("Produto excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Retorna o produto selecionado ao formulário pai (se necessário)
            if (e.RowIndex >= 0 && bsGrid.Current != null)
            {
                DataRowView drv = (DataRowView)bsGrid.Current;

                ProdutoSelecionado = new Banco.tbProduto
                {
                    id = Convert.ToInt32(drv["id"]),
                    nome = drv["nome"].ToString(),
                    descricao = drv["descricao"].ToString(),
                    peso = Convert.ToDecimal(drv["peso"])
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
