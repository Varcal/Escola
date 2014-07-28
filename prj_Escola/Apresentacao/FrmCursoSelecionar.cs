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
    public partial class FrmCursoSelecionar : Form
    {
        public FrmCursoSelecionar()
        {
            InitializeComponent();
            dgvCursoSelecionar.AutoGenerateColumns = false;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            FrmCursoCadastro frm = new FrmCursoCadastro(AcaoNaTela.Inserir, null,Selecao.Curso);
            DialogResult resultado = frm.ShowDialog();
            if (resultado == DialogResult.Yes)
            {
                AtualizaGrid();
            } 
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            if (dgvCursoSelecionar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum curso selecionado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Curso cursoSelecionado = dgvCursoSelecionar.SelectedRows[0].DataBoundItem as Curso;
            FrmCursoCadastro frm = new FrmCursoCadastro(AcaoNaTela.Consultar, cursoSelecionado,Selecao.Curso);
            DialogResult resultado = frm.ShowDialog();
            if (resultado == DialogResult.Yes)
            {
                AtualizaGrid();
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        public void AtualizaGrid()
        {
            CursoNegocios cursoNegocios = new CursoNegocios();
            CursoCollection cursoCollection = new CursoCollection();
            if (textBoxCurso.Text == "")
            {
                cursoCollection = (CursoCollection)cursoNegocios.ListarTodos();
            }
            else
            {
                cursoCollection = (CursoCollection)cursoNegocios.ConsultaCursoNome(textBoxCurso.Text);
            }           
            dgvCursoSelecionar.DataSource = null;
            dgvCursoSelecionar.DataSource = cursoCollection;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dgvCursoSelecionar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum curso selecionado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }      
            Curso cursoSelecionado = dgvCursoSelecionar.SelectedRows[0].DataBoundItem as Curso;
            DialogResult resultado =  MessageBox.Show("Deseja mesmo excluir o curso selecionado?", "PERGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultado==DialogResult.No)
            {
                return;
            }            
                CursoNegocios cursoNegocios = new CursoNegocios();
                string retorno = cursoNegocios.Excluir(cursoSelecionado);

                try
                {
                    int IdCurso = Convert.ToInt32(retorno);
                    MessageBox.Show("Curso " + retorno + " excluído com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizaGrid();
                }
                catch 
                {
                    MessageBox.Show("Não foi possível excluir o curso", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if(dgvCursoSelecionar.SelectedRows.Count==0)
            {
                MessageBox.Show("Nenhum curso foi selecionado","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            Curso cursoSelecionado = dgvCursoSelecionar.SelectedRows[0].DataBoundItem as Curso;
            FrmCursoCadastro frm = new FrmCursoCadastro(AcaoNaTela.Alterar, cursoSelecionado,Selecao.Curso);
            DialogResult resultado = frm.ShowDialog();
            if (resultado == DialogResult.Yes)
            {
                AtualizaGrid();
            }
            
        }

        private void FrmCursoSelecionar_Load(object sender, EventArgs e)
        {

        }
    }
}
