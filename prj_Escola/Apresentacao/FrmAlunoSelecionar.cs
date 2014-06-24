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
    public partial class FrmAlunoSelecionar : Form
    {
        Selecao selecionado;

        public FrmAlunoSelecionar()
        {
            InitializeComponent();
            dgvAlunoSelecionar.AutoGenerateColumns = false;
            dgvAlunoCurso.AutoGenerateColumns = false;

            dgvAlunoCurso.Visible = false;
            this.Text = "Cadastro Alunos";
            comboBoxCurso.Visible = false;
            textBoxAluno.Enabled = false;
            buttonPesquisar.Enabled = false;
           
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            FrmAlunoCadastro frm = new FrmAlunoCadastro(AcaoNaTela.Inserir,null,Selecao.Aluno);
            DialogResult resultado = frm.ShowDialog();
            if (resultado == DialogResult.Yes)
            {
                AtualizaGrid(Selecao.Nome);
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            switch (comboBoxSelecao.Text)
                {
                    case "RA":
                        selecionado = Selecao.RA;
                        AtualizaGrid(selecionado);                 
                        break;

                    case "Aluno":
                        selecionado = Selecao.Nome;
                        AtualizaGrid(selecionado);
                        break;

                    case "Curso":
                        selecionado = Selecao.Curso;
                        AtualizaGrid(selecionado);
                        break;
                }
        }
            
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            
                if (dgvAlunoSelecionar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum aluno foi selecionado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Aluno alunoSelecionado = dgvAlunoSelecionar.SelectedRows[0].DataBoundItem as Aluno;
                DialogResult resultado = MessageBox.Show("Deseja mesmo excluir o Aluno?", "PERGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                AlunoNegocios alunoNegocios = new AlunoNegocios();
                string retorno = alunoNegocios.Excluir(alunoSelecionado);
                try
                {
                    int IdAluno = Convert.ToInt32(retorno);
                    MessageBox.Show("Aluno " + retorno + " excluido com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizaGrid(Selecao.Nome);
                }
                catch
                {
                    MessageBox.Show("Não foi possivel excluir o aluno", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (dgvAlunoSelecionar.Visible == true)
            {
                if (dgvAlunoSelecionar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum aluno selecionado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Aluno alunoSelecionado = dgvAlunoSelecionar.SelectedRows[0].DataBoundItem as Aluno;
                FrmAlunoCadastro frm = new FrmAlunoCadastro(AcaoNaTela.Alterar, alunoSelecionado,Selecao.Aluno);
                DialogResult resultado = frm.ShowDialog();
                if (resultado == DialogResult.Yes)
                {
                    AtualizaGrid(Selecao.Nome);
                }
            }
            else
            {
                if (dgvAlunoCurso.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum aluno selecionado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Aluno alunoSelecionado = dgvAlunoCurso.SelectedRows[0].DataBoundItem as Aluno;
                FrmAlunoCadastro frm = new FrmAlunoCadastro(AcaoNaTela.Alterar, alunoSelecionado,Selecao.Aluno);
                DialogResult resultado = frm.ShowDialog();
                if (resultado == DialogResult.Yes)
                {
                    AtualizaGrid(Selecao.Curso);
                }
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            if (dgvAlunoSelecionar.Visible == true)
            {
                if (dgvAlunoSelecionar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum aluno selecionado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Aluno alunoSelecionado = dgvAlunoSelecionar.SelectedRows[0].DataBoundItem as Aluno;
                FrmAlunoCadastro frm = new FrmAlunoCadastro(AcaoNaTela.Consultar, alunoSelecionado,Selecao.Aluno);
                DialogResult resultado = frm.ShowDialog();
                if (resultado == DialogResult.Yes)
                {
                    AtualizaGrid(Selecao.Nome);
                }
            }
            else 
            {
                if (dgvAlunoCurso.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum aluno selecionado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Aluno alunoSelecionado = dgvAlunoCurso.SelectedRows[0].DataBoundItem as Aluno;
                FrmAlunoCadastro frm = new FrmAlunoCadastro(AcaoNaTela.Consultar, alunoSelecionado,Selecao.Aluno);
                DialogResult resultado = frm.ShowDialog();
                if (resultado == DialogResult.Yes)
                {
                    AtualizaGrid(Selecao.Curso);
                }
            }
            
        }

        public void AtualizaGrid(Selecao selecionado)
        {
            if (selecionado == Selecao.Curso)
            {
                if (comboBoxCurso.Text == " ")
                {               
                    MessageBox.Show("Nenhum curso foi selecionado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                    var alunoCollection = new AlunoCollection();
                    var alunoNegocios = new AlunoNegocios();
                    var cursoCollection = new CursoCollection();
                    var cursoNegocios = new CursoNegocios();
                    cursoCollection =(CursoCollection) cursoNegocios.ConsultaCursoNome(comboBoxCurso.Text);
                    alunoCollection = alunoNegocios.ConsultaAlunoCurso(cursoCollection[0].IdCurso);
                    dgvAlunoCurso.DataSource = null;
                    dgvAlunoCurso.DataSource = alunoCollection;
                
           }
            
            if(selecionado == Selecao.Nome)
            {
                var alunoCollection = new AlunoCollection();
                var alunoNegocios = new AlunoNegocios();
                alunoCollection = (AlunoCollection)alunoNegocios.ConsultaAlunoNome(textBoxAluno.Text);
                dgvAlunoSelecionar.DataSource = null;
                dgvAlunoSelecionar.DataSource = alunoCollection;
                textBoxAluno.Clear();
            }

            if (selecionado == Selecao.RA)
            {
                try
                {
                    var aluno = new Aluno();
                    var alunoNegocios = new AlunoNegocios();
                    aluno = alunoNegocios.ConsultaAlunoId(textBoxAluno.Text);
                    var alunoCollection = new AlunoCollection();
                    alunoCollection.Add(aluno);
                    dgvAlunoSelecionar.DataSource = null;
                    dgvAlunoSelecionar.DataSource = alunoCollection;
                    textBoxAluno.Clear();
                }
                catch
                {
                    MessageBox.Show("RA inválido ou inexistente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxAluno.Clear();
                }
            }
            
        }

        private void FrmAlunoSelecionar_Load(object sender, EventArgs e)
        {
            CursoCollection cursoCollection = new CursoCollection();
            CursoNegocios cursoNegocios = new CursoNegocios();
            DataTable dtCurso = cursoNegocios.CarregaComboBoxCurso("%");
            foreach (DataRow linha in dtCurso.Rows)
            {
                Curso curso = new Curso();
                curso.IdCurso = Convert.ToInt32(linha["IdCurso"]);
                curso.NomeCurso = Convert.ToString(linha["NomeCurso"]);
                comboBoxCurso.Items.Add(curso.NomeCurso);
            }
            comboBoxSelecao.SelectedIndex = 0;
        }

        private void comboBoxSelecao_TextChanged(object sender, EventArgs e)
        {
            switch (comboBoxSelecao.Text)
            {
                case "RA":
                    dgvAlunoSelecionar.DataSource = null;
                    textBoxAluno.Clear();
                    this.Text = "Cadastro Aluno";
                    textBoxAluno.Visible = true;
                    textBoxAluno.Enabled = true;
                    buttonPesquisar.Enabled = true;
                    dgvAlunoSelecionar.Visible = true;
                    comboBoxCurso.Visible = false;
                    dgvAlunoCurso.Visible = false;
                    textBoxAluno.TextAlign = HorizontalAlignment.Center;
                    buttonExcluir.Enabled = true;
                    break;

                case "Aluno":
                    dgvAlunoSelecionar.DataSource = null;
                    textBoxAluno.Clear();
                    this.Text = "Cadastro Aluno";
                    textBoxAluno.Visible = true;
                    dgvAlunoSelecionar.Visible = true;
                    textBoxAluno.Enabled = true;
                    buttonPesquisar.Enabled = true;
                    comboBoxCurso.Visible = false;
                    dgvAlunoCurso.Visible = false;
                    textBoxAluno.TextAlign = HorizontalAlignment.Left;
                    buttonExcluir.Enabled = true;
                    break;

                case "Curso":
                    
                    dgvAlunoCurso.DataSource = null;
                    this.Text = "Consulta Aluno Curso";
                    textBoxAluno.Visible = false;
                    dgvAlunoSelecionar.Visible = false;
                    buttonPesquisar.Enabled = true;
                    comboBoxCurso.Visible = true;
                    dgvAlunoCurso.Visible = true;
                    buttonExcluir.Enabled = false;
                    break;
                    
            }
        }
    }
}
