using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaEstoque.Banco
{
    public class tbMovimentacao
    {
        public int id { get; set; }

        public int id_produto { get; set; }

        public int id_localestoque { get; set; }

        public DateTime datahora { get; set; }

        public decimal quantidade { get; set; }

        public bool saida { get; set; }

        public string descricao { get; set; }

        public bool inserir()

        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;

                comando.CommandText = "INSERT INTO movimentacao VALUES (@id_produto, @id_localestoque, @datahora, @quantidade, @saida, @descricao)";
                comando.Parameters.AddWithValue("id_produto", id_produto);
                comando.Parameters.AddWithValue("id_localestoque", id_localestoque);
                comando.Parameters.AddWithValue("datahora", datahora);
                comando.Parameters.AddWithValue("quantidade", quantidade);
                comando.Parameters.AddWithValue("saida", saida);
                comando.Parameters.AddWithValue("descricao", descricao);

                comando.ExecuteNonQuery();
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir a movimentação de Estoque!" + ex.Message.ToString());
                return false;
            }
        }

        public bool alterar()
        {
            try
            {

                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;

                comando.CommandText = "UPDATE INTO movimentacao SET id_produto = @id_produto, id_localestoque = @id_localestoque, datahora = @datahora, quantidade = @quantidade, saida = @saida, descricao = @descricao WHERE ID = @ID";
                comando.Parameters.AddWithValue("id", id);
                comando.Parameters.AddWithValue("id_produto", id_produto);
                comando.Parameters.AddWithValue("id_localestoque", id_localestoque);
                comando.Parameters.AddWithValue("datahora", datahora);
                comando.Parameters.AddWithValue("quantidade", quantidade);
                comando.Parameters.AddWithValue("saida", saida);
                comando.Parameters.AddWithValue("descricao", descricao);
                comando.ExecuteNonQuery();
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o movimentação de estoque. Descrição!" + ex.Message.ToString());
                return false;
            }
        }

        public bool excluir()
        {
            try
            {

                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;

                comando.CommandText = "DELET FROM movimentacao WHERE ID = @ID";
                comando.Parameters.AddWithValue("id", id);
                comando.ExecuteNonQuery();
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir a movimentaçaõ de Estoque. Descrição!" + ex.Message.ToString());
                return false;
            }
        }

        public DataTable Consulta()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;
                    comando.CommandText = "SELECT * FROM movimentacao";
                    DataTable dtRetorno = new DataTable();
                    dtRetorno.Load(comando.ExecuteReader());
                    comando.ExecuteReader();
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar a movimentação de estoque. Descrição: " + ex.Message);
                return null;
            }
        }
    }
}