namespace funcionario_cadastro
{
    public partial class Form1 : Form
    {
        Funcionario f = new Funcionario();
        Gerente g = new Gerente();
        Vendedor v = new Vendedor();
        Atendente at = new Atendente();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            f.nome = txtNome.Text;
            f.cpf = txtCPF.Text;
            f.salarioBase = double.Parse(txtSalario.Text);
            f.CadastrarFuncionario();
        }

        private void btnBonificacao_Click(object sender, EventArgs e)
        {
            f.salarioBase = double.Parse(txtSalario.Text);
            f.CalcularBonificacao();
            MessageBox.Show ($"Valor da bonificação foi de: {f.valorBonificacao.ToString("0.00")}");

        }

        private void btnSalarioFinal_Click(object sender, EventArgs e)
        {
            g.gratificacao = double.Parse(txtGratificacao.Text);
            f.salarioBase = double.Parse(txtSalario.Text);

            g.CalcularSalarioFinal(f);
            MessageBox.Show($"Valor do seu salario final: {g.salarioFinal.ToString("0.00")}");
        }

        private void btnApresentarGerente_Click(object sender, EventArgs e)
        {
            f.nome = txtNome.Text;
            f.cpf = txtCPF.Text;
            g.ApresentarSalario(f);
        }

        private void btnSalarioFinalVendedor_Click(object sender, EventArgs e)
        {
            v.valorComissao = double.Parse(txtComissao.Text);
            f.salarioBase = double.Parse(txtSalario.Text);

            v.CalcularSalarioFinal(f);
            MessageBox.Show($"Valor do seu salario final: {v.salarioFinal.ToString("0.00")}");
        }

        private void btnApresentarVendedor_Click(object sender, EventArgs e)
        {
            f.nome = txtNome.Text;
            f.cpf = txtCPF.Text;

            v.ApresentarSalario(f);
        }

        private void btnSalarioFinalAtendente_Click(object sender, EventArgs e)
        {
            at.adicionalNoturno = double.Parse(txtNoturno.Text);
            f.salarioBase = double.Parse(txtSalario.Text);

            at.CalcularSalarioFinal(f);
            MessageBox.Show($"Valor do seu salario final: {at.salarioFinal.ToString("0.00")}");
        }

        private void btnApresentarAtendente_Click(object sender, EventArgs e)
        {
            f.nome = txtNome.Text;
            f.cpf = txtCPF.Text;

            at.ApresentarSalario(f);
        }
    }
}