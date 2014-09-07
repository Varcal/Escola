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
using JetBrains.ReSharper.Psi.Resx.Utils;
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
            try
            {
                var loginNegocios = new LoginNegocios();
                var login = new Login { IdLogin = loginNegocios.Logon(textBoxUsuario.Text, textBoxSenha.Text) };
               
                    if (login.IdLogin > 0)
                    {
                        this.Visible = false;
                        var frm = new FrmMenu();
                        frm.Show();
                    }
                       
            }
            catch (Exception)
            {
                MessageBox.Show(@"Usuario ou senha inválidos", @"ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
                           
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
