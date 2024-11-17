using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaEstoque.Telas
{
    public partial class FrmListaProduto : Form
    {
        private DataTable dtGrid = new DataTable();
        private BindingSource bsGrid = new BindingSource();

        public FrmListaProduto()
        {
            InitializeComponent();
        }

        private void FrmListaProduto_Load(object sender, EventArgs e)
        {
            // Carrega dados na tabela 'sistemaEstoqueDataSet.produtos'.
            this.produtosTableAdapter.Fill(this.sistemaEstoqueDataSet.produtos);
            bsGrid.DataSource = this.sistemaEstoqueDataSet.produtos; // Vincula o DataSource
            grd.DataSource = bsGrid; // Define a grid
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            bsGrid.Filter = "nome LIKE '%" + TxtFiltro.Text + "%'"; // Mantendo a funcionalidade de filtro.
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            // Aqui, você deve abrir um formulário para adicionar um novo produto
            FrmProdutos frm = new FrmProdutos(false, null); // Supondo que o formulário de produtos tem esse construtor
            frm.ShowDialog();

            // Recarrega os dados após a adição de um novo produto
            this.produtosTableAdapter.Fill(this.sistemaEstoqueDataSet.produtos);
        }

        private void BtnAlterarProduto_Click(object sender, EventArgs e)
        {
            if (bsGrid.Current == null) return; // Verifica se há um produto selecionado

            DataRowView drv = (DataRowView)bsGrid.Current; // Obtém a linha selecionada

            // Cria uma instância de tbProduto com os dados do produto selecionado
            Banco.tbProduto produto = new Banco.tbProduto
            {
                id = Convert.ToInt32(drv["id"]),
                nome = drv["nome"].ToString(),
                descricao = drv["descricao"].ToString(),
                peso = Convert.ToDecimal(drv["peso"])
            };

            // Abre o formulário de produtos para edição
            FrmProdutos frm = new FrmProdutos(true, produto);
            frm.ShowDialog();

            // Atualiza a grid após fechar o formulário de edição
            this.produtosTableAdapter.Fill(this.sistemaEstoqueDataSet.produtos);
        }

        private void BtnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (bsGrid.Current == null)
            {
                MessageBox.Show("Por favor, selecione um produto para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém a linha selecionada
            DataRowView drv = (DataRowView)bsGrid.Current;
            int produtoId = Convert.ToInt32(drv["id"]);

            // Confirmação de exclusão
            var confirmResult = MessageBox.Show(
                $"Tem certeza de que deseja excluir o produto '{drv["nome"]}'?",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Exclui o produto do banco de dados
                    Banco.tbProduto produto = new Banco.tbProduto { id = produtoId };

                    Banco.tbProduto.Excluir(produto); // Método para realizar a exclusão no banco

                    // Atualiza a lista de produtos
                    this.produtosTableAdapter.Fill(this.sistemaEstoqueDataSet.produtos);

                    MessageBox.Show("Produto excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao tentar excluir o produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
