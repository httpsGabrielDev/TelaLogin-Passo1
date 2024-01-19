using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLogin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAcesso_Click(object sender, EventArgs e)
        {
            string User = "admin";
            string Password = "admin";

            if(TxtUsuario.Text == User & TxtSenha.Text == Password)
            {
                MessageBox.Show("Acesso Liberado");
                Form1 frmMain = new Form1();
                frmMain.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Usuario/Senha Incorretos!");
            }
        }
    }
}
