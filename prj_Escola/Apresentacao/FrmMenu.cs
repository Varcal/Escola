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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

        }

       
        private void MenuItemNotas_Click(object sender, EventArgs e)
        {
            FrmNotasCadastrar frm = new FrmNotasCadastrar(AcaoNaTela.Inserir,null);
            frm.ShowDialog();
        }

        private void MenuItemCursos_Click(object sender, EventArgs e)
        {
            FrmCursoSelecionar frm = new FrmCursoSelecionar();
            frm.Show();
        }

        private void MenuItemAlunos_Click(object sender, EventArgs e)
        {
            FrmAlunoSelecionar frm = new FrmAlunoSelecionar();
            frm.Show();
        }

        private void MenuItemDisciplina_Click(object sender, EventArgs e)
        {
            FrmDisciplinaSelecionar frm = new FrmDisciplinaSelecionar();
            frm.Show();
        }

        private void MenuItemProfessor_Click(object sender, EventArgs e)
        {
            FrmProfessorSelecionar frm = new FrmProfessorSelecionar();
            frm.Show();
        }

        private void MenuItemSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemInserirDisciplinaCurso_Click(object sender, EventArgs e)
        {
            
            FrmCursoCadastro frm = new FrmCursoCadastro(AcaoNaTela.Inserir, null,Selecao.Disciplina);
            frm.ShowDialog();       
        }

        private void MenuItemInserirProfessorDisciplna_Click(object sender, EventArgs e)
        {
            FrmProfessorCadastro frm = new FrmProfessorCadastro(AcaoNaTela.Inserir, null, Selecao.Disciplina);
            frm.ShowDialog();
        }

        private void consultaNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRAConsulta frm = new FrmRAConsulta();
            frm.ShowDialog();
        }

        private void inserirAlunoNoDisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmAlunoCadastro(AcaoNaTela.Inserir, null, Selecao.Disciplina);
            frm.ShowDialog();
        }

      

   

        
    }
}