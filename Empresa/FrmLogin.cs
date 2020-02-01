using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Empresa
{
    public partial class FrmLogin : Form
    {
        Conexao con = new Conexao();
        Usuario objUsuario = new Usuario();


        public FrmLogin()
        {
            objUsuario = new Usuario();
            con = new Conexao();
            InitializeComponent();

        }

        private void lerDados()
        {
            objUsuario.user = txtusuario.Text.Trim();
            objUsuario.senha = txtsenha.Text.Trim();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            lerDados();

            String HashSenha = CrypHash.ComputeSha256Hash(objUsuario.senha);
            con.OpenConnection();

            String sql = $"select * from tb_usuario where usuario = '{objUsuario.user}' and senha = '{HashSenha}' and status = true";

            MySqlDataReader reader;

            reader = con.executeQuery(sql);

            if (reader.HasRows)
            {                
                FrmTelaPrincipal principal = new FrmTelaPrincipal();
                principal.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Falha ao Logar!");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtusuario.Text = "";
            txtsenha.Text = "";
        }
    }
}
