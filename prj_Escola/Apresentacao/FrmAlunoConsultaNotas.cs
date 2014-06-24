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
    public partial class FrmAlunoConsultaNotas : Form
    {
        public FrmAlunoConsultaNotas(int IdAluno)
        {

            InitializeComponent();
          
                       
                NotasCollection notasCollection = new NotasCollection();
                NotasNegocios notasNegocios = new NotasNegocios();
                notasCollection = notasNegocios.ConsultaNotasRA(IdAluno);
                dgv_AlunoNotas.AutoGenerateColumns = false;
                textBoxAluno.Text = notasCollection[0].NomeAluno;
                textBoxCurso.Text = notasCollection[0].NomeCurso;
                dgv_AlunoNotas.DataSource = null;
                dgv_AlunoNotas.DataSource = notasCollection;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
