using SistemaEstoque.Banco;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaEstoque.Telas
{
    public partial class FrmListaLocalEstoque : Form
    {
        private DataTable dtGrid = new DataTable();
        private BindingSource bsGrid = new BindingSource();

        public FrmListaLocalEstoque()
        {
            InitializeComponent();
        }

        private void FrmListaLocalEstoque_Load(object sender, EventArgs e)
        {
            LoadData(); // Carrega os dados ao iniciar o formulário
        }

        private void LoadData()
        {
            try
            {
                this.localestoqueTableAdapter.Fill(this.sistemaEstoqueDataSet2.localestoque);
                bsGrid.DataSource = this.sistemaEstoqueDataSet2.localestoque; // Vincula o DataSource
                grdLocalEstoque.DataSource = bsGrid; // Define a grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
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
            FrmLocalEstoque frm = new FrmLocalEstoque(false, null); // Supondo que o formulário de produtos tem esse construtor
            frm.ShowDialog();

            LoadData(); // Recarrega os dados após a adição de um novo local de estoque
        }

        private void BtnAlterarLocaldeEstoque_Click(object sender, EventArgs e)
        {
            if (bsGrid.Current == null) return; // Verifica se há um local de estoque selecionado

            DataRowView drv = (DataRowView)bsGrid.Current; // Obtém a linha selecionada

            // Cria uma instância de tbLocalEstoque com os dados do local selecionado
            Banco.tbLocalEstoque localEstoque = new Banco.tbLocalEstoque
            {
                id = Convert.ToInt32(drv["id"]),
                Nome = drv["nome"].ToString(),
            };

            // Abre o formulário de produtos para edição
            FrmLocalEstoque frm = new FrmLocalEstoque(true, localEstoque);
            frm.ShowDialog();

            // Atualiza a grid após fechar o formulário de edição
            LoadData(); // Chama o método LoadData para atualizar a grid
        }
    }
}
