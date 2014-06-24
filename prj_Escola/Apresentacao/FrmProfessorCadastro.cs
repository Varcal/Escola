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
    public partial class FrmProfessorCadastro : Form
    {
        FrmProfessorSelecionar frm = new FrmProfessorSelecionar();
        AcaoNaTela acaoSelecionada;

        public FrmProfessorCadastro(AcaoNaTela acaoNaTela, Professor professor, Selecao selecao)
        {
            InitializeComponent();
            acaoSelecionada = acaoNaTela;

            if (selecao == Selecao.Professor)
            {
                if (acaoNaTela == AcaoNaTela.Inserir)
                {
                    this.Text = "Cadastro de Professores";
                    labelRegistro.Text = "Registro";
                    labelProfessor.Text = "Professor";
                    textBoxRegistro.ReadOnly = true;
                    textBoxRegistro.TabStop = false;
                    comboBoxDisciplina.Visible = false;
                    comboBoxProfessor.Visible = false;

                }
                if (acaoNaTela == AcaoNaTela.Alterar)
                {
                    labelRegistro.Text = "Registro";
                    labelProfessor.Text = "Professor";
                    textBoxRegistro.Text = professor.IdProfessor.ToString();
                    textBoxRegistro.ReadOnly = true;
                    textBoxRegistro.TabStop = false;
                    textBoxProfessor.Text = professor.NomeProfessor;
                    comboBoxProfessor.Visible = false;
                    comboBoxDisciplina.Visible = false;
                    textBoxProfessor.Focus();
                }
                if (acaoNaTela == AcaoNaTela.Consultar)
                {
                    labelRegistro.Text = "Registro";
                    labelProfessor.Text = "Professor";
                    textBoxRegistro.Text = professor.IdProfessor.ToString();
                    textBoxRegistro.ReadOnly = true;
                    textBoxRegistro.TabStop = false;
                    textBoxProfessor.Text = professor.NomeProfessor;
                    textBoxProfessor.ReadOnly = true;
                    textBoxProfessor.TabStop = false;
                    buttonConfirmar.Visible = false;
                    comboBoxDisciplina.Visible = false;
                    comboBoxProfessor.Visible = false;
                    buttonCancelar.Focus();
                }
            }
            if (selecao == Selecao.Disciplina)
            {
                textBoxRegistro.Visible = false;
                labelRegistro.Visible = true;
                labelRegistro.Text = "Professor";
                labelProfessor.Text = "Disciplina";
                comboBoxDisciplina.Visible = true;
                comboBoxProfessor.Visible = true;
            }
                          
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            

            if (comboBoxDisciplina.Visible == false)
            {
                if (acaoSelecionada == AcaoNaTela.Inserir)
                {
                    Professor professor = new Professor();
                    ProfessorNegocios professorNegocios = new ProfessorNegocios();
                    professor.NomeProfessor = textBoxProfessor.Text;
                    string retorno = professorNegocios.Salvar(professor);
                    try
                    {
                        int IdProfessor = int.Parse(retorno);
                        MessageBox.Show("Professor " + retorno + " inserido com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm.AtualizaGrid(Selecao.Nome);
                        DialogResult = DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel inserir novo professor", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (acaoSelecionada == AcaoNaTela.Alterar)
                {
                    Professor professor = new Professor();
                    ProfessorNegocios professorNegocios = new ProfessorNegocios();
                    professor.IdProfessor = int.Parse(textBoxRegistro.Text);
                    professor.NomeProfessor = textBoxProfessor.Text;
                    string retorno = professorNegocios.Salvar(professor);
                    try
                    {
                        int IdProfessor = int.Parse(retorno);
                        MessageBox.Show("Professor " + retorno + " alterado com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm.AtualizaGrid(Selecao.Nome);
                        DialogResult = DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel alterar professor", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (comboBoxDisciplina.Visible == true)
            {
                if (acaoSelecionada == AcaoNaTela.Inserir)
                {
                    var professorCollection = new ProfessorCollection();
                    var professorNegocios = new ProfessorNegocios();
                    professorCollection =(ProfessorCollection) professorNegocios.ConsultaProfessorNome(comboBoxProfessor.Text);
                    var disciplinaCollection = new DisciplinaCollection();
                    var disciplinaNegocios = new DisciplinaNegocios();
                    disciplinaCollection =(DisciplinaCollection) disciplinaNegocios.ConsultaDisciplinaNome(comboBoxDisciplina.Text);
                    var professor = new Professor();
                    professor.IdProfessor = professorCollection.First().IdProfessor;
                    professor.IdDisciplina = disciplinaCollection.First().IdDisciplina;
                    string retorno = professorNegocios.InserirDisciplina(professor);
                    try
                    {
                        int IdProfessor = int.Parse(retorno);
                        MessageBox.Show("Disciplina inserida com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel inserir Disciplina", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               }
            }
                                   
        }

        private void FrmProfessorCadastro_Load(object sender, EventArgs e)
        {
            var disciplinaNegocios = new DisciplinaNegocios();
            DataTable dtDisciplina = disciplinaNegocios.CarregaComboDisciplina("%");
            foreach (DataRow linha in dtDisciplina.Rows)
            {
                Disciplina disciplina = new Disciplina();
                disciplina.NomeDisciplina = Convert.ToString(linha["NomeDisciplina"]);
                comboBoxDisciplina.Items.Add(disciplina.NomeDisciplina);
            }

            var professorCollection = new ProfessorCollection();
            ProfessorNegocios professorNegocios = new ProfessorNegocios();
            professorCollection =(ProfessorCollection) professorNegocios.ConsultaProfessorNome("%");
            foreach (Professor professor in professorCollection)
            {
                comboBoxProfessor.Items.Add(professor.NomeProfessor);
            }

         
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            buttonConfirmar_Click(sender, e);
        }
    }
}