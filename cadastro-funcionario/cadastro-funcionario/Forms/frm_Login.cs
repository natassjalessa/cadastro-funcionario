﻿using System;
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
    public partial class frm_Login : Form
    {
        public string senha;
        public string login;
        public frm_Login()
        {
            InitializeComponent();

            lblLogin.Text = "Usuário";
            lblPassword.Text = "Senha";
            btnOk.Text = "OK";
            btnCancel.Text = "Cancel";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            senha = txtPassword.Text;
            login = txtLogin.Text;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
