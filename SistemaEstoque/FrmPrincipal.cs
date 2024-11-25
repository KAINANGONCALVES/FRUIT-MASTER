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
            // Exibe a mensagem de confirmação
            var confirmResult = MessageBox.Show(
                "Tem certeza de que deseja sair do sistema?", // Texto da mensagem
                "Confirmação",                               // Título da janela
                MessageBoxButtons.YesNo,                    // Botões "Sim" e "Não"
                MessageBoxIcon.Question                     // Ícone de pergunta
            );

            // Verifica se o usuário clicou em "Sim"
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit(); // Fecha o aplicativo
            }
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
            SistemaEstoque.Telas.FrmListaMovimentacao frm = new SistemaEstoque.Telas.FrmListaMovimentacao();
            frm.Show();
        }
        // Não apaga
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tROCARMUDARUSUÁRIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exibe a mensagem de confirmação
            var confirmResult = MessageBox.Show(
                "Tem certeza de que deseja trocar de Usuário?", // Texto da mensagem
                "Confirmação",                               // Título da janela
                MessageBoxButtons.YesNo,                    // Botões "Sim" e "Não"
                MessageBoxIcon.Question                     // Ícone de pergunta
            );

            // Verifica se o usuário clicou em "Sim"
            if (confirmResult == DialogResult.Yes)
            {
                SistemaEstoque.FrmLogin frm = new FrmLogin();
                frm.ShowDialog();
            }
        }

        private void BtnCastroMenu_Click(object sender, EventArgs e)
        {
            SistemaEstoque.Telas.FrmListaProduto frm = new Telas.FrmListaProduto();
            frm.Show();
        }

        private void BtnCastroEstoqueMenu_Click(object sender, EventArgs e)
        {
            SistemaEstoque.Telas.FrmListaLocalEstoque frm = new Telas.FrmListaLocalEstoque();
            frm.Show();
        }

        private void BtnAlterarUsuarioMenu_Click(object sender, EventArgs e)
        {
            // Exibe a mensagem de confirmação
            var confirmResult = MessageBox.Show(
                "Tem certeza de que deseja trocar de Usuário ?", // Texto da mensagem
                "Confirmação",                               // Título da janela
                MessageBoxButtons.YesNo,                    // Botões "Sim" e "Não"
                MessageBoxIcon.Question                     // Ícone de pergunta
            );

            // Verifica se o usuário clicou em "Sim"
            if (confirmResult == DialogResult.Yes)
            {
                SistemaEstoque.FrmLogin frm = new FrmLogin();
                frm.ShowDialog();
            }
        }

        private void BtnSairMenu_Click(object sender, EventArgs e)
        {
            // Exibe a mensagem de confirmação
            var confirmResult = MessageBox.Show(
                "Tem certeza de que deseja sair do sistema?", // Texto da mensagem
                "Confirmação",                               // Título da janela
                MessageBoxButtons.YesNo,                    // Botões "Sim" e "Não"
                MessageBoxIcon.Question                     // Ícone de pergunta
            );

            // Verifica se o usuário clicou em "Sim"
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit(); // Fecha o aplicativo
            }
        }

        private void mOVIMENTAÇÃOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SistemaEstoque.Telas.FrmListaMovimentacao frm = new SistemaEstoque.Telas.FrmListaMovimentacao();
            frm.Show();
        }

        private void BtnMovimentacao_Click(object sender, EventArgs e)
        {
            SistemaEstoque.Telas.FrmListaMovimentacao frm = new SistemaEstoque.Telas.FrmListaMovimentacao();
            frm.Show();
        }
    }
}
