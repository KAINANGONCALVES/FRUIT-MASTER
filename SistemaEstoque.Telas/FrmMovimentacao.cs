using SistemaEstoque.Banco;
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
            

            // Se estamos alterando, carregar os dados nos controles
            if (this.EstaAlterando && this.Movimentacao != null)
            {
                TxtDescricao.Text = this.Movimentacao.descricao;
                TxtQuantidade.Text = Convert.ToString(this.Movimentacao.quantidade);
                chkSaida.Checked = this.Movimentacao.saida;
                dtpDataHora.Value = this.Movimentacao.datahora;

                // Verifica se os ComboBoxes foram preenchidos antes de definir os valores
                if (CmbProduto.Items.Count > 0)
                {
                    CmbProduto.SelectedValue = this.Movimentacao.id_produto;
                }
                if (CmbLocalEstoque.Items.Count > 0)
                {
                    CmbLocalEstoque.SelectedValue = this.Movimentacao.id_localestoque;
                }
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
                UpdateMovimentacao();
            }
            else
            {
                InsertMovimentacao();
            }

            MessageBox.Show("Movimentação salva com sucesso.");
            this.Close();
        }

        private bool ValidateInputs()
        {
            return !string.IsNullOrWhiteSpace(TxtDescricao.Text) &&
                   !string.IsNullOrWhiteSpace(TxtQuantidade.Text);
        }

        private void UpdateMovimentacao()
        {
            this.Movimentacao.descricao = TxtDescricao.Text;
            this.Movimentacao.quantidade = int.Parse(TxtQuantidade.Text);
            this.Movimentacao.saida = chkSaida.Checked;
            this.Movimentacao.datahora = dtpDataHora.Value;
            this.Movimentacao.id_produto = (int)CmbProduto.SelectedValue;
            this.Movimentacao.id_localestoque = (int)CmbLocalEstoque.SelectedValue;

            this.Movimentacao.alterar();
        }

        private void InsertMovimentacao()
        {
            var novaMovimentacao = new tbMovimentacao
            {
                descricao = TxtDescricao.Text,
                quantidade = int.Parse(TxtQuantidade.Text),
                saida = chkSaida.Checked,
                datahora = dtpDataHora.Value,
                id_produto = (int)CmbProduto.SelectedValue,
                id_localestoque = (int)CmbLocalEstoque.SelectedValue
            };

            novaMovimentacao.inserir();
        }
    }
}
