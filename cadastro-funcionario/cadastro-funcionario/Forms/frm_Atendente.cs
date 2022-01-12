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
    public partial class frm_Atendente : Form
    {
        Funcionario f = new Funcionario();
        Atendente a = new Atendente();
        public frm_Atendente()
        {
            InitializeComponent();
        }

        private void btnBonificacao_Click(object sender, EventArgs e)
        {
            f.salarioBase = double.Parse(txtSalarioAtendente.Text);
            f.CalcularBonificacao();
            MessageBox.Show($"Valor da bonificação foi de: {f.valorBonificacao.ToString("0.00")}");
        }

        private void btnSalarioFinal_Click(object sender, EventArgs e)
        {
            a.adicionalNoturno = double.Parse(txtNoturno.Text);
            f.salarioBase = double.Parse(txtSalarioAtendente.Text);

            a.CalcularSalarioFinal(f);
            MessageBox.Show($"Valor do seu salario final: {a.salarioFinal.ToString("0.00")}");

            f.nome = txtNomeAtendente.Text;
            f.cpf = mskCPFAtendente.Text;

            a.ApresentarSalario(f);
        }
    }
}
