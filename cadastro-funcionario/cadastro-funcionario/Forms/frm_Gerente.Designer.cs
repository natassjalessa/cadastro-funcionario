namespace cadastro_funcionario
{
    partial class frm_Gerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Gerente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeGerente = new System.Windows.Forms.TextBox();
            this.mskCPFGerente = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBonificacao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalarioFinal = new System.Windows.Forms.Button();
            this.txtSalarioGerente = new System.Windows.Forms.TextBox();
            this.txtGratificacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "GERENTE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txtNomeGerente
            // 
            this.txtNomeGerente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeGerente.Location = new System.Drawing.Point(117, 78);
            this.txtNomeGerente.Name = "txtNomeGerente";
            this.txtNomeGerente.Size = new System.Drawing.Size(214, 26);
            this.txtNomeGerente.TabIndex = 1;
            // 
            // mskCPFGerente
            // 
            this.mskCPFGerente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mskCPFGerente.Location = new System.Drawing.Point(117, 135);
            this.mskCPFGerente.Mask = "000,000,000-00";
            this.mskCPFGerente.Name = "mskCPFGerente";
            this.mskCPFGerente.Size = new System.Drawing.Size(214, 26);
            this.mskCPFGerente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salário:";
            // 
            // btnBonificacao
            // 
            this.btnBonificacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBonificacao.Location = new System.Drawing.Point(19, 279);
            this.btnBonificacao.Name = "btnBonificacao";
            this.btnBonificacao.Size = new System.Drawing.Size(312, 44);
            this.btnBonificacao.TabIndex = 5;
            this.btnBonificacao.Text = "BONIFICAÇÃO";
            this.btnBonificacao.UseVisualStyleBackColor = true;
            this.btnBonificacao.Click += new System.EventHandler(this.btnBonificacao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gratificação:";
            // 
            // btnSalarioFinal
            // 
            this.btnSalarioFinal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalarioFinal.Location = new System.Drawing.Point(19, 343);
            this.btnSalarioFinal.Name = "btnSalarioFinal";
            this.btnSalarioFinal.Size = new System.Drawing.Size(312, 44);
            this.btnSalarioFinal.TabIndex = 6;
            this.btnSalarioFinal.Text = "SALÁRIO FINAL";
            this.btnSalarioFinal.UseVisualStyleBackColor = true;
            this.btnSalarioFinal.Click += new System.EventHandler(this.btnSalarioFinal_Click);
            // 
            // txtSalarioGerente
            // 
            this.txtSalarioGerente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalarioGerente.Location = new System.Drawing.Point(117, 185);
            this.txtSalarioGerente.Name = "txtSalarioGerente";
            this.txtSalarioGerente.Size = new System.Drawing.Size(214, 26);
            this.txtSalarioGerente.TabIndex = 3;
            // 
            // txtGratificacao
            // 
            this.txtGratificacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGratificacao.Location = new System.Drawing.Point(117, 231);
            this.txtGratificacao.Name = "txtGratificacao";
            this.txtGratificacao.Size = new System.Drawing.Size(214, 26);
            this.txtGratificacao.TabIndex = 4;
            // 
            // frm_Gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 446);
            this.Controls.Add(this.txtGratificacao);
            this.Controls.Add(this.txtSalarioGerente);
            this.Controls.Add(this.btnSalarioFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBonificacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskCPFGerente);
            this.Controls.Add(this.txtNomeGerente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Gerente";
            this.Text = "frm_Gerente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeGerente;
        private System.Windows.Forms.MaskedTextBox mskCPFGerente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBonificacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalarioFinal;
        private System.Windows.Forms.TextBox txtSalarioGerente;
        private System.Windows.Forms.TextBox txtGratificacao;
    }
}