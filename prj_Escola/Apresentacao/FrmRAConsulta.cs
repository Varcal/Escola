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
    public partial class FrmRAConsulta : Form
    {
        public FrmRAConsulta()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxRA.Text == "")
            {
                MessageBox.Show("Favor informar nº do RA","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            var alunoNegocios = new AlunoNegocios();
            var aluno = alunoNegocios.ListarId(textBoxRA.Text);

            if (aluno.IdAluno == 0)
            {
                MessageBox.Show(@"Aluno não localizado", @"AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxRA.Clear();
                return;
            }
            var frm = new FrmAlunoConsultaNotas(int.Parse(textBoxRA.Text));
            this.Visible = false;           
            DialogResult result = frm.ShowDialog();
            DialogResult = DialogResult.Yes;
        }
    }
}
