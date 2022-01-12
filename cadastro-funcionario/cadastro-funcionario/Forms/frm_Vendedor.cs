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
    public partial class frm_Vendedor : Form
    {
        Funcionario f = new Funcionario();
        Vendedor v = new Vendedor();
        public frm_Vendedor()
        {
            InitializeComponent();
        }

        private void btnBonificacao_Click(object sender, EventArgs e)
        {
            f.salarioBase = double.Parse(txtSalarioVendedor.Text);
            f.CalcularBonificacao();
            MessageBox.Show($"Valor da bonificação foi de: {f.valorBonificacao.ToString("0.00")}");
        }

        private void btnSalarioFinal_Click(object sender, EventArgs e)
        {
            v.valorComissao = double.Parse(txtComissao.Text);
            f.salarioBase = double.Parse(txtSalarioVendedor.Text);

            v.CalcularSalarioFinal(f);
            MessageBox.Show($"Valor do seu salario final: {v.salarioFinal.ToString("0.00")}");

            f.nome = txtNomeVendedor.Text;
            f.cpf = mskCPFVendedor.Text;

            v.ApresentarSalario(f);
        }
    }
}
