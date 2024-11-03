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

                    CommandText = "INSERT INTO localestoque VALUES (@nome)"
                };
                comando.Parameters.AddWithValue("nome", Nome);

                comando.ExecuteNonQuery();
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir o Local de Estoque. Descrição!" + ex.Message.ToString());
                return false;
            }
        }

        public bool alterar()
        {
            try
            {

                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;

                comando.CommandText = "UPDATE INTO localestoque SET nome = @nome WHERE ID = @ID";
                comando.Parameters.AddWithValue("id", id);
                comando.Parameters.AddWithValue("nome", Nome);
                comando.ExecuteNonQuery();
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar  Local de Esatoque. Descrição!" + ex.Message.ToString());
                return false;
            }
        }

        public bool excluir()
        {
            try
            {

                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;

                comando.CommandText = "DELET FROM localestoque WHERE ID = @ID";
                comando.Parameters.AddWithValue("id", id);
                comando.ExecuteNonQuery();
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro o excluir o local de Estoque. Descrição!" + ex.Message.ToString());
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
                    comando.CommandText = "SELECT * FROM Local Estoque";
                    DataTable dtRetorno = new DataTable();
                    dtRetorno.Load(comando.ExecuteReader());
                    comando.ExecuteReader();
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar o Local de Estoque. Descrição: " + ex.Message);
                return null;
            }
        }
    }
}