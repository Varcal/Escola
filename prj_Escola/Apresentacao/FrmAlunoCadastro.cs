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
    public partial class FrmAlunoCadastro : Form
    {
        AcaoNaTela acaoSelecionada;
        private Selecao selecionada;


        public FrmAlunoCadastro(AcaoNaTela acaoNaTela, Aluno aluno, Selecao selecao)
        {
            InitializeComponent();
            acaoSelecionada = acaoNaTela;
            selecionada = selecao;
            if (selecao == Selecao.Aluno)
            {
                panelAluno.Visible = true;
                panelDiario.Visible = false;
                if (acaoNaTela == AcaoNaTela.Inserir)
                {
                    this.Text = "Cadastra Aluno";
                    textBoxRA.Enabled = false;
                    buttonAlterarCurso.Visible = false;
                }

                if (acaoNaTela == AcaoNaTela.Alterar)
                {
                    CursoNegocios cursoNegocios = new CursoNegocios();
                    Curso curso = new Curso();
                    curso = cursoNegocios.ConsultaCursoId(aluno.IdCurso.ToString());
                    comboBoxCurso.Text = curso.NomeCurso;
                    textBoxRA.Text = aluno.IdAluno.ToString();
                    textBoxAluno.Text = aluno.NomeAluno;
                    comboBoxCurso.Enabled = false;
                    comboBoxCurso.TabStop = false;
                    textBoxRA.ReadOnly = true;
                    textBoxRA.TabStop = false;
                }
                if (acaoSelecionada == AcaoNaTela.Consultar)
                {
                    this.Text = "Consulta Cadastro Aluno";
                    CursoNegocios cursoNegocios = new CursoNegocios();
                    Curso curso = new Curso();
                    curso = cursoNegocios.ConsultaCursoId(aluno.IdCurso.ToString());
                    comboBoxCurso.Text = curso.NomeCurso;
                    textBoxRA.Text = aluno.IdAluno.ToString();
                    textBoxAluno.Text = aluno.NomeAluno;
                    comboBoxCurso.Enabled = false;
                    comboBoxCurso.TabStop = false;
                    textBoxRA.ReadOnly = true;
                    textBoxRA.TabStop = false;
                    textBoxAluno.ReadOnly = true;
                    textBoxAluno.TabStop = false;
                    buttonAlterarCurso.Visible = false;
                    buttonConfirmar.Visible = false;
                    buttonCancelar.Focus();
                }
            }
            if (selecao == Selecao.Disciplina)
            {
                panelAluno.Visible = false;
                panelDiario.Visible = true;

            }
        }

        private void FrmAlunoCadastro_Load(object sender, EventArgs e)
        {
            var cursoCollection = new CursoCollection();
            var cursoNegocios = new CursoNegocios();
            var dtCurso = cursoNegocios.CarregaComboBoxCurso("%");
            comboBoxCurso1.Items.Clear();
            comboBoxCurso1.Items.Add("Selecione o curso");
            foreach (DataRow linha in dtCurso.Rows)
            {
                var curso = new Curso();
                curso.IdCurso = Convert.ToInt32(linha["IdCurso"]);
                curso.NomeCurso = Convert.ToString(linha["NomeCurso"]);
                comboBoxCurso.Items.Add(curso.NomeCurso);
                comboBoxCurso1.Items.Add(curso.NomeCurso);
            }
            comboBoxCurso1.SelectedIndex = 0;

            comboBoxDisciplina.Enabled = false;
            comboBoxProfessor.Enabled = false;
            comboBoxAluno.Enabled = false;

            //var professorCollection = new ProfessorCollection();
            //var professorNegocios = new ProfessorNegocios();
            //var dtProfessor = professorNegocios.CarregaComboProfessor("%");
            //foreach (DataRow linha in dtProfessor.Rows)
            //{
            //    var professor = new Professor();
            //    professor.IdProfessor = Convert.ToInt32(linha["IdProfessor"]);
            //    professor.NomeProfessor = Convert.ToString(linha["NomeProfessor"]);
            //    comboBoxProfessor.Items.Add(professor.NomeProfessor);
            //}

            //var alunoCollection = new AlunoCollection();
            //var alunoNegocios = new AlunoNegocios();
            //var dtAluno = alunoNegocios.CarregaComboAluno("%");
            //foreach (DataRow linha in dtAluno.Rows)
            //{
            //    var aluno = new Aluno();
            //    aluno.IdAluno = Convert.ToInt32(linha["IdAluno"]);
            //    aluno.NomeAluno = Convert.ToString(linha["NomeAluno"]);
            //    comboBoxAluno.Items.Add(aluno.NomeAluno);
            //}
        }

        private void buttonAlterarCurso_Click(object sender, EventArgs e)
        {

            if (acaoSelecionada == AcaoNaTela.Alterar)
            {
                comboBoxCurso.Enabled = true;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {

            if (selecionada == Selecao.Aluno)
            {
                if (acaoSelecionada == AcaoNaTela.Inserir)
                {
                    if (comboBoxCurso.Text == "" || textBoxAluno.Text == "")
                    {
                        MessageBox.Show("Campo curso ou aluno invalido", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    var cursoNegocios = new CursoNegocios();
                    var cursoCollection = new CursoCollection();
                    cursoCollection = (CursoCollection)cursoNegocios.ConsultaCursoNome(comboBoxCurso.Text);
                    var aluno = new Aluno();
                    var alunoNegocios = new AlunoNegocios();
                    aluno.IdCurso = cursoCollection[0].IdCurso;
                    aluno.NomeAluno = textBoxAluno.Text.ToUpper();
                    string retorno = alunoNegocios.Salvar(aluno);
                    try
                    {
                        int IdAluno = Convert.ToInt32(retorno);
                        MessageBox.Show("Aluno " + retorno + " inserido com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel inserir novo aluno", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult = DialogResult.No;
                    }
                }
                if (acaoSelecionada == AcaoNaTela.Alterar)
                {
                    if (comboBoxCurso.Text == "" || textBoxAluno.Text == "")
                    {
                        MessageBox.Show("Campo curso ou aluno invalido", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    CursoNegocios cursoNegocios = new CursoNegocios();
                    CursoCollection cursoCollection = new CursoCollection();
                    cursoCollection = (CursoCollection)cursoNegocios.ConsultaCursoNome(comboBoxCurso.Text);
                    Aluno aluno = new Aluno();
                    AlunoNegocios alunoNegocios = new AlunoNegocios();
                    aluno.IdCurso = cursoCollection[0].IdCurso;
                    aluno.IdAluno = Convert.ToInt32(textBoxRA.Text);
                    aluno.NomeAluno = textBoxAluno.Text;
                    string retorno = alunoNegocios.Salvar(aluno);

                    try
                    {
                        int IdAluno = Convert.ToInt32(retorno);
                        MessageBox.Show("Aluno " + retorno + " alterado com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel efetuar alteração", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult = DialogResult.No;
                    }
                }
            }
            if (selecionada == Selecao.Disciplina)
            {

                if (comboBoxCurso1.Text == "Selecione o curso" || comboBoxDisciplina.Text == "Selecione a disciplina" ||
                    comboBoxProfessor.Text == "Selecione o professor" || comboBoxAluno.Text == "Selecione o aluno")
                {
                    MessageBox.Show("Todos os campos devem ser selecionados", "AVISO", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
                    var cursoNegocios = new CursoNegocios();
                    var cursoCollection = (CursoCollection) cursoNegocios.ConsultaCursoNome(comboBoxCurso1.Text);
                    var professorNegocios = new ProfessorNegocios();
                    var professorCollection =
                        (ProfessorCollection) professorNegocios.ConsultaProfessorNome(comboBoxProfessor.Text);
                    var disciplinaNegocios = new DisciplinaNegocios();
                    var disciplinaCollection =
                        (DisciplinaCollection) disciplinaNegocios.ConsultaDisciplinaNome(comboBoxDisciplina.Text);
                    var alunoNegocios = new AlunoNegocios();
                    var alunoCollection = (AlunoCollection) alunoNegocios.ListarNome(comboBoxAluno.Text);

                    var notas = new Notas();
                    notas.IdCurso = cursoCollection.First().IdCurso;
                    notas.IdProfessor = professorCollection.First().IdProfessor;
                    notas.IdDisciplina = disciplinaCollection.First().IdDisciplina;
                    notas.IdAluno = alunoCollection.First().IdAluno;

                    var notasNegocios = new NotasNegocios();
                    string retorno = notasNegocios.InserirAluno(notas);

                    try
                    {
                        int IdNotas = int.Parse(retorno);
                        MessageBox.Show("Aluno inserido no diário digital com sucesso", "AVISO", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        DialogResult = DialogResult.Yes;
                    }

                    catch
                    {
                        MessageBox.Show("Não foi possivel inserir aluno", "ERRO", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            buttonConfirmar_Click(sender, e);
        }

        private void comboBoxDisciplina_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxDisciplina.SelectedItem.ToString() == "Selecione a disciplina")
            {
                return;
            }
            comboBoxProfessor.Items.Clear();
            comboBoxProfessor.Items.Add("Selecione o professor");
            comboBoxProfessor.SelectedIndex = 0;
            var disciplinaNegocios = new DisciplinaNegocios();
            var disciplinaCollection = (DisciplinaCollection) disciplinaNegocios.ConsultaDisciplinaNome(comboBoxDisciplina.SelectedItem.ToString());
            var professorNegocios = new ProfessorNegocios();
            var professorCollection = (ProfessorCollection) professorNegocios.DisciplinaProfessor(disciplinaCollection[0].IdDisciplina);
            foreach (Professor professor in professorCollection)
            {
                comboBoxProfessor.Items.Add(professor.NomeProfessor);
            }
            comboBoxProfessor.Enabled = true;
        }

        private void comboBoxCurso1_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxCurso1.SelectedItem.ToString() == "Selecione o curso")
            {
                return;
            }
            comboBoxDisciplina.Items.Clear();
            comboBoxDisciplina.Items.Add("Selecione a disciplina");
            comboBoxDisciplina.SelectedIndex = 0;
            var cursoNegocios = new CursoNegocios();
            var cursoCollection =
                (CursoCollection) cursoNegocios.ConsultaCursoNome(comboBoxCurso1.SelectedItem.ToString());
            var discplinaNegocios = new DisciplinaNegocios();
            var disciplinaCollection = (DisciplinaCollection)discplinaNegocios.ConsultaCursoDisciplina(cursoCollection[0].IdCurso,0);
            foreach (Disciplina disciplina in disciplinaCollection)
            {
                comboBoxDisciplina.Items.Add(disciplina.NomeDisciplina);
            }
            comboBoxDisciplina.Enabled = true;
        }

        private void comboBoxProfessor_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxProfessor.SelectedItem.ToString() == "Selecione o professor")
            {
                return;
            }
            comboBoxAluno.Items.Clear();
            comboBoxAluno.Items.Add("Selecione o aluno");
            comboBoxAluno.SelectedIndex = 0;
            var alunoNegocios = new AlunoNegocios();
            var cursoNegocios = new CursoNegocios();
            var cursoCollection =(CursoCollection) cursoNegocios.ConsultaCursoNome(comboBoxCurso1.SelectedItem.ToString());
            var alunoCollection = (AlunoCollection)alunoNegocios.ConsultaAlunoCurso(cursoCollection[0].IdCurso);
            foreach (Aluno aluno in alunoCollection)
            {
                comboBoxAluno.Items.Add(aluno.NomeAluno);
            }
            comboBoxAluno.Enabled = true;
        }

      
    }
}
