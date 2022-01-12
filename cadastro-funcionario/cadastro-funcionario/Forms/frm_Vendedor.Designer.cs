namespace cadastro_funcionario
{
    partial class frm_Vendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Vendedor));
            this.label1 = new System.Windows.Forms.Label();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.txtSalarioVendedor = new System.Windows.Forms.TextBox();
            this.btnSalarioFinal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBonificacao = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCPFVendedor = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "VENDEDOR:";
            // 
            // txtComissao
            // 
            this.txtComissao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComissao.Location = new System.Drawing.Point(134, 222);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(214, 26);
            this.txtComissao.TabIndex = 15;
            // 
            // txtSalarioVendedor
            // 
            this.txtSalarioVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalarioVendedor.Location = new System.Drawing.Point(134, 176);
            this.txtSalarioVendedor.Name = "txtSalarioVendedor";
            this.txtSalarioVendedor.Size = new System.Drawing.Size(214, 26);
            this.txtSalarioVendedor.TabIndex = 14;
            // 
            // btnSalarioFinal
            // 
            this.btnSalarioFinal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalarioFinal.Location = new System.Drawing.Point(36, 334);
            this.btnSalarioFinal.Name = "btnSalarioFinal";
            this.btnSalarioFinal.Size = new System.Drawing.Size(312, 44);
            this.btnSalarioFinal.TabIndex = 17;
            this.btnSalarioFinal.Text = "SALÁRIO FINAL";
            this.btnSalarioFinal.UseVisualStyleBackColor = true;
            this.btnSalarioFinal.Click += new System.EventHandler(this.btnSalarioFinal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Comissão:";
            // 
            // btnBonificacao
            // 
            this.btnBonificacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBonificacao.Location = new System.Drawing.Point(36, 270);
            this.btnBonificacao.Name = "btnBonificacao";
            this.btnBonificacao.Size = new System.Drawing.Size(312, 44);
            this.btnBonificacao.TabIndex = 16;
            this.btnBonificacao.Text = "BONIFICAÇÃO";
            this.btnBonificacao.UseVisualStyleBackColor = true;
            this.btnBonificacao.Click += new System.EventHandler(this.btnBonificacao_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Salário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "CPF:";
            // 
            // mskCPFVendedor
            // 
            this.mskCPFVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mskCPFVendedor.Location = new System.Drawing.Point(134, 126);
            this.mskCPFVendedor.Mask = "000,000,000-00";
            this.mskCPFVendedor.Name = "mskCPFVendedor";
            this.mskCPFVendedor.Size = new System.Drawing.Size(214, 26);
            this.mskCPFVendedor.TabIndex = 12;
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeVendedor.Location = new System.Drawing.Point(134, 69);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.Size = new System.Drawing.Size(214, 26);
            this.txtNomeVendedor.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome:";
            // 
            // frm_Vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 446);
            this.Controls.Add(this.txtComissao);
            this.Controls.Add(this.txtSalarioVendedor);
            this.Controls.Add(this.btnSalarioFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBonificacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskCPFVendedor);
            this.Controls.Add(this.txtNomeVendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Vendedor";
            this.Text = "frm_Vendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.TextBox txtSalarioVendedor;
        private System.Windows.Forms.Button btnSalarioFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBonificacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCPFVendedor;
        private System.Windows.Forms.TextBox txtNomeVendedor;
        private System.Windows.Forms.Label label2;
    }
}