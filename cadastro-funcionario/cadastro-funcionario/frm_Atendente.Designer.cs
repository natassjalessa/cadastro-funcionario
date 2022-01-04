namespace cadastro_funcionario
{
    partial class frm_Atendente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Atendente));
            this.txtNoturno = new System.Windows.Forms.TextBox();
            this.txtSalarioAtendente = new System.Windows.Forms.TextBox();
            this.btnSalarioFinal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBonificacao = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCPFAtendente = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeAtendente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNoturno
            // 
            this.txtNoturno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoturno.Location = new System.Drawing.Point(134, 256);
            this.txtNoturno.Name = "txtNoturno";
            this.txtNoturno.Size = new System.Drawing.Size(214, 26);
            this.txtNoturno.TabIndex = 16;
            // 
            // txtSalarioAtendente
            // 
            this.txtSalarioAtendente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalarioAtendente.Location = new System.Drawing.Point(134, 210);
            this.txtSalarioAtendente.Name = "txtSalarioAtendente";
            this.txtSalarioAtendente.Size = new System.Drawing.Size(214, 26);
            this.txtSalarioAtendente.TabIndex = 15;
            // 
            // btnSalarioFinal
            // 
            this.btnSalarioFinal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalarioFinal.Location = new System.Drawing.Point(36, 368);
            this.btnSalarioFinal.Name = "btnSalarioFinal";
            this.btnSalarioFinal.Size = new System.Drawing.Size(312, 44);
            this.btnSalarioFinal.TabIndex = 18;
            this.btnSalarioFinal.Text = "SALÁRIO FINAL";
            this.btnSalarioFinal.UseVisualStyleBackColor = true;
            this.btnSalarioFinal.Click += new System.EventHandler(this.btnSalarioFinal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Noturno:";
            // 
            // btnBonificacao
            // 
            this.btnBonificacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBonificacao.Location = new System.Drawing.Point(36, 304);
            this.btnBonificacao.Name = "btnBonificacao";
            this.btnBonificacao.Size = new System.Drawing.Size(312, 44);
            this.btnBonificacao.TabIndex = 17;
            this.btnBonificacao.Text = "BONIFICAÇÃO";
            this.btnBonificacao.UseVisualStyleBackColor = true;
            this.btnBonificacao.Click += new System.EventHandler(this.btnBonificacao_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Salário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "CPF:";
            // 
            // mskCPFAtendente
            // 
            this.mskCPFAtendente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mskCPFAtendente.Location = new System.Drawing.Point(134, 160);
            this.mskCPFAtendente.Mask = "000,000,000-00";
            this.mskCPFAtendente.Name = "mskCPFAtendente";
            this.mskCPFAtendente.Size = new System.Drawing.Size(214, 26);
            this.mskCPFAtendente.TabIndex = 13;
            // 
            // txtNomeAtendente
            // 
            this.txtNomeAtendente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeAtendente.Location = new System.Drawing.Point(134, 103);
            this.txtNomeAtendente.Name = "txtNomeAtendente";
            this.txtNomeAtendente.Size = new System.Drawing.Size(214, 26);
            this.txtNomeAtendente.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "ATENDENTE:";
            // 
            // frm_Atendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 446);
            this.Controls.Add(this.txtNoturno);
            this.Controls.Add(this.txtSalarioAtendente);
            this.Controls.Add(this.btnSalarioFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBonificacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskCPFAtendente);
            this.Controls.Add(this.txtNomeAtendente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Atendente";
            this.Text = "frm_Atendente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoturno;
        private System.Windows.Forms.TextBox txtSalarioAtendente;
        private System.Windows.Forms.Button btnSalarioFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBonificacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCPFAtendente;
        private System.Windows.Forms.TextBox txtNomeAtendente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}