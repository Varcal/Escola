using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                progressBar.Value = progressBar.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Visible = false;
            }

        }
    }
}
