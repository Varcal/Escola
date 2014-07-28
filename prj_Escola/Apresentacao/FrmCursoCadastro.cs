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
    public partial class FrmCursoCadastro : Form
    {
        AcaoNaTela acaoSelecionada;

        public FrmCursoCadastro(AcaoNaTela acaoNaTela, Curso curso, Selecao selecao)
        {
            InitializeComponent();
            acaoSelecionada = acaoNaTela;
            comboBoxCurso.Visible = false;
            comboBoxDisciplina.Visible = false;

            if (selecao == Selecao.Curso)
            {
                if (acaoNaTela == AcaoNaTela.Inserir)
                {
                    this.Text = "Cadastra Curso";
                    textBoxCodigo.ReadOnly = true;
                    textBoxCodigo.TabStop = false;
                    textBoxCurso.Focus();
                }
                if (acaoNaTela == AcaoNaTela.Alterar)
                {
                    this.Text = "Altera Curso";
                    textBoxCodigo.Text = curso.IdCurso.ToString();
                    textBoxCurso.Text = curso.NomeCurso;
                    textBoxCodigo.ReadOnly = true;
                    textBoxCodigo.TabStop = false;
                    textBoxCurso.Focus();
                }
                if (acaoNaTela == AcaoNaTela.Consultar)
                {
                    this.Text = "Consulta Curso";
                    textBoxCodigo.Text = curso.IdCurso.ToString();
                    textBoxCurso.Text = curso.NomeCurso;
                    textBoxCodigo.ReadOnly = true;
                    textBoxCodigo.TabStop = false;
                    textBoxCurso.ReadOnly = true;
                    textBoxCurso.TabStop = false;
                    buttonConfirmar.Visible = false;
                    buttonCancelar.Focus();
                }
            }
            if (selecao == Selecao.Disciplina)
            {
                comboBoxCurso.Visible = true;
                labelCodigo.Text = "Curso";
                labelCurso.Text = "Disciplina";
                textBoxCurso.Visible = false;
                comboBoxDisciplina.Visible = true;
            }
            
        }
   
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (acaoSelecionada == AcaoNaTela.Inserir)
            {
                if (comboBoxDisciplina.Visible == false)
                {
                    Curso curso = new Curso();
                    curso.NomeCurso = textBoxCurso.Text;
                    CursoNegocios cursoNegocios = new CursoNegocios();
                    string retorno = cursoNegocios.Salvar(curso);

                    try
                    {
                        int IdCurso = Convert.ToInt32(retorno);
                        MessageBox.Show("Curso " + retorno + " inserido com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel inserir novo curso", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.No;
                    }
                }
                if (comboBoxDisciplina.Visible == true)
                {
                    
                    CursoCollection cursoCollection = new CursoCollection();
                    CursoNegocios cursoNegocios = new CursoNegocios();
                    cursoCollection = (CursoCollection)cursoNegocios.ConsultaCursoNome(comboBoxCurso.Text);
                    DisciplinaCollection disciplinaCollection = new DisciplinaCollection();
                    DisciplinaNegocios disciplinaNegocios = new DisciplinaNegocios();
                    disciplinaCollection =(DisciplinaCollection) disciplinaNegocios.ConsultaDisciplinaNome(comboBoxDisciplina.Text);
                    Disciplina disciplina = new Disciplina();
                    disciplina.IdCurso = cursoCollection[0].IdCurso;
                    disciplina.IdDisciplina = disciplinaCollection[0].IdDisciplina;

                    string retorno = disciplinaNegocios.InserirDisciplinaCurso(disciplina);
                    try
                    {
                        int IdCurso = Convert.ToInt32(retorno);
                        MessageBox.Show("Disciplina inserida com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel inserir disciplina neste curso", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.No;
                    }
                    
                }
                
            }
            
            if (acaoSelecionada == AcaoNaTela.Alterar)
            { 
                Curso curso = new Curso();
                curso.IdCurso = Convert.ToInt32(textBoxCodigo.Text);
                curso.NomeCurso = textBoxCurso.Text;
                CursoNegocios cursoNegocios = new CursoNegocios();
                string retorno = cursoNegocios.Salvar(curso);

                try
                {
                    int IdCurso = Convert.ToInt32(retorno);
                    MessageBox.Show("Curso " + retorno + " alterado com sucesso");
                    this.DialogResult = DialogResult.Yes;
                }
                catch 
                {
                    MessageBox.Show("Não foi possível alterar o curso", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
        }

        private void FrmCursoCadastro_Load(object sender, EventArgs e)
        {
            DisciplinaCollection disciplinaCollection = new DisciplinaCollection();
            DisciplinaNegocios disciplinaNegocios = new DisciplinaNegocios();
            disciplinaCollection =(DisciplinaCollection) disciplinaNegocios.ListarTodos();
            foreach (Disciplina disciplina in disciplinaCollection)
            {
                comboBoxDisciplina.Items.Add(disciplina.NomeDisciplina);
            }

            CursoCollection cursoCollection = new CursoCollection();
            CursoNegocios cursoNegocios = new CursoNegocios();
            cursoCollection =(CursoCollection) cursoNegocios.ListarTodos();
            foreach(Curso curso in cursoCollection)
            {
                comboBoxCurso.Items.Add(curso.NomeCurso);
            }
        }

    

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            buttonCancelar_Click(sender, e);
        }   
    }
}

