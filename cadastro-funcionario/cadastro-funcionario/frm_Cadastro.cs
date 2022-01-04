using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro_funcionario
{
    public partial class frm_CadastroMDI : Form
    {
        public frm_CadastroMDI()
        {
            InitializeComponent();
        }

        private void gerenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Gerente gerente = new frm_Gerente();
            gerente.MdiParent = this;
            gerente.Show();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Vendedor vendedor = new frm_Vendedor();
            vendedor.MdiParent = this;
            vendedor.Show();    
        }

        private void atendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Atendente atendente = new frm_Atendente();
            atendente.MdiParent = this; 
            atendente.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja realmente finalizar o cadastro?", "Cadastro",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }
    }
}
