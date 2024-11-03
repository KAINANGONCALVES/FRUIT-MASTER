using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstoque
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin frm = new FrmLogin();
            if(frm.ShowDialog() == DialogResult.OK)
            {

                //conexão com o banco
                SistemaEstoque.Utilitarios.ConexaoBanco.conexao = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["conexaoBDSSistemaEstoque"].ConnectionString);
                SistemaEstoque.Utilitarios.ConexaoBanco.conexao.Open();

                Application.Run(new FrmPrincipal());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
