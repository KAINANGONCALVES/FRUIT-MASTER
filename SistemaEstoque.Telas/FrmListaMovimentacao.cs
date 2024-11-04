using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void FrmListaMovimentacao_Load_1(object sender, EventArgs e)
        {
            LoadData(); // Carrega os dados ao iniciar o formulário
        }

        private void LoadData()
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'sistemaEstoqueDataSet3.movimentacao'. Você pode movê-la ou removê-la conforme necessário.
                this.movimentacaoTableAdapter.Fill(this.sistemaEstoqueDataSet3.movimentacao);
                bsGrid.DataSource = sistemaEstoqueDataSet3.movimentacao; // Define a fonte de dados do BindingSource
                grdMovimentacao.DataSource = bsGrid; // Define a grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            bsGrid.Filter = "nome LIKE '%" + TxtFiltro.Text + "%'";
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            // Abre o formulário de Movimentação para criação de novo registro
            FrmMovimentacao frm = new FrmMovimentacao(false, new Banco.tbMovimentacao());
            frm.ShowDialog();

            // Atualiza a grid após fechar o formulário de novo registro
            LoadData();
        }

        private void BtnAlterarMovimentacao_Click(object sender, EventArgs e)
        {
            if (bsGrid.Current == null) return; // Verifica se há uma movimentação selecionada

            DataRowView drv = (DataRowView)bsGrid.Current; // Obtém a linha selecionada

            // Cria uma instância de tbMovimentacao com os dados da movimentação selecionada
            Banco.tbMovimentacao movimentacao = new Banco.tbMovimentacao
            {
                id = Convert.ToInt32(drv["id"]),
                descricao = drv["descricao"].ToString(),
                quantidade = Convert.ToInt32(drv["quantidade"]),
                saida = Convert.ToBoolean(drv["saida"]),
                datahora = Convert.ToDateTime(drv["datahora"]),
                id_produto = Convert.ToInt32(drv["id_produto"]),
                id_localestoque = Convert.ToInt32(drv["id_localestoque"])
            };

            // Abre o formulário de Movimentação para edição
            FrmMovimentacao frm = new FrmMovimentacao(true, movimentacao);
            frm.ShowDialog();

            // Atualiza a grid após fechar o formulário de edição
            LoadData();
        }
    }
}
