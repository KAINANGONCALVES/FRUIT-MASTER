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

        public bool Inserir()
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;
                    comando.CommandText = "INSERT INTO movimentacao (id_produto, id_localestoque, datahora, quantidade, saida, descricao) VALUES (@id_produto, @id_localestoque, @datahora, @quantidade, @saida, @descricao)";
                    comando.Parameters.AddWithValue("id_produto", id_produto);
                    comando.Parameters.AddWithValue("id_localestoque", id_localestoque);
                    comando.Parameters.AddWithValue("datahora", datahora);
                    comando.Parameters.AddWithValue("quantidade", quantidade);
                    comando.Parameters.AddWithValue("saida", saida);
                    comando.Parameters.AddWithValue("descricao", descricao);

                    comando.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir a movimentação: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Alterar()
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;
                    comando.CommandText = "UPDATE movimentacao SET id_produto = @id_produto, id_localestoque = @id_localestoque, datahora = @datahora, quantidade = @quantidade, saida = @saida, descricao = @descricao WHERE id = @id";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar a movimentação: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Método Excluir corrigido: agora usa um parâmetro `int id`
        public static bool Excluir(int id)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;
                    comando.CommandText = "DELETE FROM movimentacao WHERE id = @id";
                    comando.Parameters.AddWithValue("id", id);

                    comando.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir a movimentação: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Método de consulta (sem alteração)
        public DataTable Consulta()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;
                    comando.CommandText = "SELECT * FROM movimentacao";

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar a movimentação: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }
    }
}
