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
            gerenteToolStripMenuItem.Enabled = false;
            atendenteToolStripMenuItem.Enabled = false; 
            vendedorToolStripMenuItem.Enabled = false;
            windowsToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
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

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Login F = new frm_Login();
            F.ShowDialog();

            if (F.DialogResult == DialogResult.OK)
            {
                string senha = F.senha;
                string login = F.login;

                if (Funcionario.validaSenhaLogin(senha) == true)
                {
                    gerenteToolStripMenuItem.Enabled = true;
                    atendenteToolStripMenuItem.Enabled = true;
                    vendedorToolStripMenuItem.Enabled = true;
                    windowsToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = true;

                    MessageBox.Show($"Bem vindo {login}!", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Senha inválida!", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja realmente se desconectar?", "Conexão",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                gerenteToolStripMenuItem.Enabled = false;
                atendenteToolStripMenuItem.Enabled = false;
                vendedorToolStripMenuItem.Enabled = false;
                windowsToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
                desconectarToolStripMenuItem.Enabled = false;
            }
        }
    }
}
