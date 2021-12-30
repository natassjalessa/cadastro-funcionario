namespace funcionario_cadastro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnBonificacao = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnApresentarGerente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGratificacao = new System.Windows.Forms.TextBox();
            this.btnSalarioFinal = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnApresentarVendedor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.btnSalarioFinalVendedor = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnApresentarAtendente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoturno = new System.Windows.Forms.TextBox();
            this.btnSalarioFinalAtendente = new System.Windows.Forms.Button();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(98, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(150, 31);
            this.txtNome.TabIndex = 0;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(98, 87);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(150, 31);
            this.txtSalario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salario";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(98, 124);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 34);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnBonificacao
            // 
            this.btnBonificacao.Location = new System.Drawing.Point(216, 124);
            this.btnBonificacao.Name = "btnBonificacao";
            this.btnBonificacao.Size = new System.Drawing.Size(112, 34);
            this.btnBonificacao.TabIndex = 7;
            this.btnBonificacao.Text = "Bonificação";
            this.btnBonificacao.UseVisualStyleBackColor = true;
            this.btnBonificacao.Click += new System.EventHandler(this.btnBonificacao_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 173);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 152);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnApresentarGerente);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtGratificacao);
            this.tabPage1.Controls.Add(this.btnSalarioFinal);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 114);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gerente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnApresentarGerente
            // 
            this.btnApresentarGerente.Location = new System.Drawing.Point(162, 58);
            this.btnApresentarGerente.Name = "btnApresentarGerente";
            this.btnApresentarGerente.Size = new System.Drawing.Size(150, 31);
            this.btnApresentarGerente.TabIndex = 3;
            this.btnApresentarGerente.Text = "Apresentar";
            this.btnApresentarGerente.UseVisualStyleBackColor = true;
            this.btnApresentarGerente.Click += new System.EventHandler(this.btnApresentarGerente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gratificacao";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtGratificacao
            // 
            this.txtGratificacao.Location = new System.Drawing.Point(124, 21);
            this.txtGratificacao.Name = "txtGratificacao";
            this.txtGratificacao.Size = new System.Drawing.Size(188, 31);
            this.txtGratificacao.TabIndex = 1;
            // 
            // btnSalarioFinal
            // 
            this.btnSalarioFinal.Location = new System.Drawing.Point(6, 58);
            this.btnSalarioFinal.Name = "btnSalarioFinal";
            this.btnSalarioFinal.Size = new System.Drawing.Size(150, 31);
            this.btnSalarioFinal.TabIndex = 0;
            this.btnSalarioFinal.Text = "Salario Final";
            this.btnSalarioFinal.UseVisualStyleBackColor = true;
            this.btnSalarioFinal.Click += new System.EventHandler(this.btnSalarioFinal_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnApresentarVendedor);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtComissao);
            this.tabPage2.Controls.Add(this.btnSalarioFinalVendedor);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(331, 114);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vendedor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnApresentarVendedor
            // 
            this.btnApresentarVendedor.Location = new System.Drawing.Point(162, 58);
            this.btnApresentarVendedor.Name = "btnApresentarVendedor";
            this.btnApresentarVendedor.Size = new System.Drawing.Size(150, 31);
            this.btnApresentarVendedor.TabIndex = 7;
            this.btnApresentarVendedor.Text = "Apresentar";
            this.btnApresentarVendedor.UseVisualStyleBackColor = true;
            this.btnApresentarVendedor.Click += new System.EventHandler(this.btnApresentarVendedor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Comissão:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtComissao
            // 
            this.txtComissao.Location = new System.Drawing.Point(124, 21);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(188, 31);
            this.txtComissao.TabIndex = 5;
            // 
            // btnSalarioFinalVendedor
            // 
            this.btnSalarioFinalVendedor.Location = new System.Drawing.Point(6, 58);
            this.btnSalarioFinalVendedor.Name = "btnSalarioFinalVendedor";
            this.btnSalarioFinalVendedor.Size = new System.Drawing.Size(150, 31);
            this.btnSalarioFinalVendedor.TabIndex = 4;
            this.btnSalarioFinalVendedor.Text = "Salario Final";
            this.btnSalarioFinalVendedor.UseVisualStyleBackColor = true;
            this.btnSalarioFinalVendedor.Click += new System.EventHandler(this.btnSalarioFinalVendedor_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnApresentarAtendente);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtNoturno);
            this.tabPage3.Controls.Add(this.btnSalarioFinalAtendente);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(331, 114);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Atendente";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnApresentarAtendente
            // 
            this.btnApresentarAtendente.Location = new System.Drawing.Point(162, 58);
            this.btnApresentarAtendente.Name = "btnApresentarAtendente";
            this.btnApresentarAtendente.Size = new System.Drawing.Size(150, 31);
            this.btnApresentarAtendente.TabIndex = 11;
            this.btnApresentarAtendente.Text = "Apresentar";
            this.btnApresentarAtendente.UseVisualStyleBackColor = true;
            this.btnApresentarAtendente.Click += new System.EventHandler(this.btnApresentarAtendente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Noturno:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNoturno
            // 
            this.txtNoturno.Location = new System.Drawing.Point(124, 21);
            this.txtNoturno.Name = "txtNoturno";
            this.txtNoturno.Size = new System.Drawing.Size(188, 31);
            this.txtNoturno.TabIndex = 9;
            // 
            // btnSalarioFinalAtendente
            // 
            this.btnSalarioFinalAtendente.Location = new System.Drawing.Point(6, 58);
            this.btnSalarioFinalAtendente.Name = "btnSalarioFinalAtendente";
            this.btnSalarioFinalAtendente.Size = new System.Drawing.Size(150, 31);
            this.btnSalarioFinalAtendente.TabIndex = 8;
            this.btnSalarioFinalAtendente.Text = "Salario Final";
            this.btnSalarioFinalAtendente.UseVisualStyleBackColor = true;
            this.btnSalarioFinalAtendente.Click += new System.EventHandler(this.btnSalarioFinalAtendente_Click);
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(98, 50);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(150, 31);
            this.mskCPF.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(377, 375);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnBonificacao);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "CADASTRO ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNome;
        private TextBox txtSalario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCadastrar;
        private Button btnBonificacao;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label4;
        private TextBox txtGratificacao;
        private Button btnSalarioFinal;
        private TabPage tabPage2;
        private Button btnApresentarGerente;
        private Button btnApresentarVendedor;
        private Label label5;
        private TextBox txtComissao;
        private Button btnSalarioFinalVendedor;
        private TabPage tabPage3;
        private Button btnApresentarAtendente;
        private Label label6;
        private TextBox txtNoturno;
        private Button btnSalarioFinalAtendente;
        private MaskedTextBox mskCPF;
    }
}