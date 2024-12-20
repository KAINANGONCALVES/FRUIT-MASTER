﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaEstoque.Banco
{
    public class tbProduto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal peso { get; set; }

        public bool Inserir()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;

                comando.CommandText = "INSERT INTO produtos (nome, descricao, peso) VALUES (@nome, @descricao, @peso)";
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@descricao", descricao);
                comando.Parameters.AddWithValue("@peso", peso);

                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir o produto. Descrição: " + ex.Message);
                return false;
            }
        }

        public bool Alterar()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = SistemaEstoque.Utilitarios.ConexaoBanco.conexao;

                // Corrigido: Removido "INTO" da consulta SQL
                comando.CommandText = "UPDATE produtos SET nome = @nome, descricao = @descricao, peso = @peso WHERE id = @id";

                comando.Parameters.AddWithValue("@id", id); // Corrigido: Adicionado o '@' no parâmetro
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@descricao", descricao);
                comando.Parameters.AddWithValue("@peso", peso);

                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o produto. Descrição: " + ex.Message);
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
                    comando.CommandText = "SELECT * FROM produtos";

                    dataTable.Load(comando.ExecuteReader());
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar o produto. Descrição: " + ex.Message);
                return null;
            }
        }

        public static bool Excluir(tbProduto produto)
        {
            try
            {
                using (var connection = new SqlConnection("Data Source=DESKTOP-KQ61GO6\\MSSQLSERVER01;Initial Catalog=SistemaEstoque;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    connection.Open();
                    string query = "DELETE FROM produtos WHERE id = @id";

                    using (var command = new SqlCommand(query, connection))
                    {
                        // Corrigido para usar 'produto.id' em vez de 'id'
                        command.Parameters.AddWithValue("@id", produto.id);
                        command.ExecuteNonQuery();
                    }
                }
                return true; // Retorna true se a exclusão for bem-sucedida
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o produto. Descrição: " + ex.Message);
                return false;
            }
        }

        public static void Excluir(tbMovimentacao movimentacao)
        {
            throw new NotImplementedException();
        }
    }
}
