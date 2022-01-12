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
    public partial class frm_Gerente : Form
    {
        Funcionario f = new Funcionario();
        Gerente g = new Gerente();  
        public frm_Gerente()
        {
            InitializeComponent();
        }

        private void btnBonificacao_Click(object sender, EventArgs e)
        {
            f.salarioBase = double.Parse(txtSalarioGerente.Text);
            f.CalcularBonificacao();
            MessageBox.Show($"Valor da bonificação foi de: {f.valorBonificacao.ToString("0.00")}");
        }

        private void btnSalarioFinal_Click(object sender, EventArgs e)
        {
            g.gratificacao = double.Parse(txtGratificacao.Text);
            f.salarioBase = double.Parse(txtSalarioGerente.Text);

            g.CalcularSalarioFinal(f);
            MessageBox.Show($"Valor do seu salario final: {g.salarioFinal.ToString("0.00")}");

            f.nome = txtNomeGerente.Text;
            f.cpf = mskCPFGerente.Text;
            g.ApresentarSalario(f);

        }
    }
}
