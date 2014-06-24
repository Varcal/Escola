using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using DTO;

namespace Apresentacao
{
    public partial class FrmSelecionaProfessor : Form
    {
        public FrmSelecionaProfessor(ProfessorCollection professorCollection)
        {
            InitializeComponent();
            dgvSelecionaProfessor.AutoGenerateColumns = false;
            dgvSelecionaProfessor.DataSource = null;
            dgvSelecionaProfessor.DataSource = professorCollection;
            buttonSalvar.Enabled = false;
        }

        private void dgvSelecionaProfessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Professor professorSelecionado = dgvSelecionaProfessor.SelectedRows[0].DataBoundItem as Professor;
                FrmNotasCadastrar frm = new FrmNotasCadastrar(AcaoNaTela.Consultar, professorSelecionado);
                frm.ShowDialog();
                DialogResult = DialogResult.Yes;
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro : " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
