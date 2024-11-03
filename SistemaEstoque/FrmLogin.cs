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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text.Equals("adm"))
            { 
                if(TxtSenha.Text.Equals("123"))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("SENHA INVALIDA!!!");
                }
            }
            else
            {
                MessageBox.Show("USUÁRIO INVALIDO!!!");
            }
        }
    }
}
