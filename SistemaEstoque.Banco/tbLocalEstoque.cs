using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaEstoque.Banco
{
    public class tbLocalEstoque
    {
        public int id { get; set; }
        public string Nome { get; set; }

        public bool inserir()
        {
            try
            {
                SqlCommand comando = new SqlCommand
                {
                    Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao,
                    CommandText = "INSERT INTO localestoque (nome) VALUES (@nome)"
                };
                comando.Parameters.AddWithValue("@nome", Nome);

                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir o Local de Estoque. Descrição: " + ex.Message);
                return false;
            }
        }

        public bool alterar()
        {
            try
            {
                SqlCommand comando = new SqlCommand
                {
                    Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao,
                    CommandText = "UPDATE localestoque SET nome = @nome WHERE id = @id"
                };

                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nome", Nome);

                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o Local de Estoque. Descrição: " + ex.Message);
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
                    comando.CommandText = "SELECT * FROM localestoque";
                    dataTable.Load(comando.ExecuteReader());
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar o Local de Estoque. Descrição: " + ex.Message);
                return null;
            }
        }

        public bool Excluir()
        {
            try
            {
                using (var connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao) // Usando a conexão já existente
                {
                    string query = "DELETE FROM localestoque WHERE id = @id";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o Local de Estoque. Descrição: " + ex.Message);
                return false;
            }
        }
    }
}
