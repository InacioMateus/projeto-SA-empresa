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
    public partial class FrmTelaPrincipal : Form
    {
        public FrmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Setor_Click(object sender, EventArgs e)
        {
           
            FrmSetor s = new FrmSetor();
            s.Show();
            this.Visible = false;

            
        }
    }
}
