using SistemaEstoque.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstoque
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SistemaEstoque.Telas.FrmListaProduto frm = new Telas.FrmListaProduto();
            frm.Show();
        }

        private void locaisDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //aqui vai encaminhar para o meu frmLista Local estoque
            SistemaEstoque.Telas.FrmListaLocalEstoque frm = new Telas.FrmListaLocalEstoque();
            frm.Show();
        }

        private void movimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SistemaEstoque.Telas.FrmListaMovimentacao frm = new FrmListaMovimentacao();
            frm.Show();
        }
    }
}
