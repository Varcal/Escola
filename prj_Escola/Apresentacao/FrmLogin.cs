using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Negocios;

namespace Apresentacao
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            LoginNegocios loginNegocios = new LoginNegocios();
            Login login = new Login();
            login.IdLogin = loginNegocios.Logon(textBoxUsuario.Text,textBoxSenha.Text);
            if(login.IdLogin>0)
            {
              this.Visible = false;
              FrmMenu frm = new FrmMenu();
              frm.Show();
              
            }
            else 
            {
                MessageBox.Show("Usuario ou senha inválidos","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
