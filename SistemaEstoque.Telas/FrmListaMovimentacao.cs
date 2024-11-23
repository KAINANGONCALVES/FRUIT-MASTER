using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaEstoque.Telas
{
    public partial class FrmListaMovimentacao : Form
    {
        private DataTable dtGrid = new DataTable();
        private BindingSource bsGrid = new BindingSource();

        public FrmListaMovimentacao()
        {
            InitializeComponent();
        }

        private void FrmListaMovimentacao_Load(object sender, EventArgs e)
        {
            try
            {
                // Carrega os dados na grid
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar as movimentações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarGrid()
        {
            try
            {
                // Carrega os dados no DataTable e atualiza o DataSource
                this.movimentacaoTableAdapter.Fill(this.sistemaEstoqueDataSet7.movimentacao);
                dtGrid = this.sistemaEstoqueDataSet7.movimentacao; // Atualiza o DataTable
                bsGrid.DataSource = dtGrid;
                grdMovimentacao.DataSource = bsGrid;
                grdMovimentacao.Refresh(); // Atualiza visualmente a grid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar a lista de movimentações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Filtra a grid com base na descrição
                bsGrid.Filter = $"descricao LIKE '%{TxtFiltro.Text.Replace("'", "''")}%'"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao aplicar o filtro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                // Abre o formulário de movimentação para nova entrada
                using (FrmMovimentacao frm = new FrmMovimentacao(false, null))
                {
                    frm.ShowDialog();
                }

                AtualizarGrid(); // Atualiza a lista após inserir nova movimentação
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar uma nova movimentação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAlterarProduto_Click(object sender, EventArgs e)
        {
            if (bsGrid.Current == null)
            {
                MessageBox.Show("Nenhuma movimentação selecionada para alteração.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataRowView drv = (DataRowView)bsGrid.Current; // Obtém a linha selecionada

                Banco.tbMovimentacao movimentacao = new Banco.tbMovimentacao
                {
                    id = Convert.ToInt32(drv["id"]),
                    id_produto = Convert.ToInt32(drv["id_produto"]),
                    id_localestoque = Convert.ToInt32(drv["id_localestoque"]),
                    quantidade = Convert.ToDecimal(drv["quantidade"]),
                    datahora = Convert.ToDateTime(drv["datahora"]),
                    descricao = drv["descricao"].ToString()
                };

                using (FrmMovimentacao frm = new FrmMovimentacao(true, movimentacao))
                {
                    frm.ShowDialog();
                }

                AtualizarGrid(); // Atualiza a lista após alterar a movimentação
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar a movimentação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (bsGrid.Current == null)
            {
                MessageBox.Show("Por favor, selecione uma movimentação para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataRowView drv = (DataRowView)bsGrid.Current;
                int movimentacaoId = Convert.ToInt32(drv["id"]);

                var confirmResult = MessageBox.Show(
                    $"Tem certeza de que deseja excluir a movimentação com ID {movimentacaoId}?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    // Passando o ID corretamente para o método Excluir
                    Banco.tbMovimentacao.Excluir(movimentacaoId);

                    AtualizarGrid(); // Atualiza a lista após a exclusão

                    MessageBox.Show("Movimentação excluída com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir a movimentação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
