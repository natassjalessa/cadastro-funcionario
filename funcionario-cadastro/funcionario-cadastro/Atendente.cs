using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionario_cadastro
{
    public class Atendente:Funcionario
    {
        public double adicionalNoturno { get; set; }

        public Atendente(double adicionalNoturno, string nome, string cpf, double salarioBase, double salarioFinal, double valorBonificacao) :
            base(nome, cpf, salarioBase, salarioFinal, valorBonificacao)
        {
            this.adicionalNoturno = adicionalNoturno;
        }

        public Atendente()
        {
            this.adicionalNoturno = 0;
            this.nome = "";
            this.cpf = "";
            this.salarioBase = 0;
            this.salarioFinal = 0;
            this.valorBonificacao = 0;
        }

        public void CalcularSalarioFinal(Funcionario f)
        {
            this.salarioFinal = adicionalNoturno + f.salarioBase + f.valorBonificacao;
        }

        public void ApresentarSalario(Funcionario f)
        {
            MessageBox.Show($"Dados do Gerente\n\n" +
                $"Nome: {f.nome}\n" +
                $"CPF: {f.cpf}\n" +
                $"Salario Base: {f.salarioBase:f2}\n" +
                $"Valor Bonificação: {f.valorBonificacao:f2}\n" +
                $"Noturno: {this.adicionalNoturno:f2}\n" +
                $"Salario Final: {this.salarioFinal:f2}");
        }
    }
}
