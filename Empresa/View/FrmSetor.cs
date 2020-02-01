using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class FrmSetor : Form, ICadform
    {
        Setor objSetor;

        public FrmSetor()
        {
            InitializeComponent();
        }       

        public void lerDados()
        {
            objSetor = new Setor();

            objSetor.id = int.Parse(txtId.Text.Trim());
            objSetor.nome = txtNomeS.Text;            
        }       

        public void bloquearCampos()
        {
            txtId.ReadOnly = true;
            txtNomeS.ReadOnly = true;
            cmbStatus.Enabled = false;
        }

        public void desbloquearCampos()
        {
            txtId.ReadOnly = false;
            txtNomeS.ReadOnly = false;
            cmbStatus.Enabled = true;
        }

        public void limparCampos()
        {
            txtId.Text = "";
            txtNomeS.Text = "";
            cmbStatus.Text = "";
        }     

        public void atualizarGrid()
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
