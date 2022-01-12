using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro_funcionario
{
    public class Funcionario
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public double salarioBase { get; set; }
        public double salarioFinal { get; set; }
        public double valorBonificacao { get; set; }

        public Funcionario(string nome, string cpf, double salarioBase, double salarioFinal, double valorBonificacao)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.salarioBase = salarioBase;
            this.salarioFinal = salarioFinal;
            this.valorBonificacao = valorBonificacao;
        }

        public Funcionario()
        {
            this.nome = "";
            this.cpf = "";
            this.salarioBase = 0;
            this.salarioFinal = 0;
            this.valorBonificacao = 0;

        }

        public void CalcularBonificacao()
        {
            valorBonificacao = salarioBase * 0.5;
        }

        public void CadastrarFuncionario()
        {
            MessageBox.Show("Cadastro feito com sucesso");
        }

        public static bool validaSenhaLogin(string senha)
        {
            if (senha == "curso")
            {
                return true;
            }
            return false;
        }
    }
}
