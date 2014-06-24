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
using System.IO;


namespace Apresentacao
{
    public partial class FrmDiarioNotas : Form
    {
        private CursoCollection _cursoCollection = new CursoCollection();
        private readonly CursoNegocios _cursoNegocios = new CursoNegocios();
        private DisciplinaCollection _disciplinaCollection = new DisciplinaCollection();
        private readonly DisciplinaNegocios _disciplinaNegocios = new DisciplinaNegocios();
        private ProfessorCollection _professorCollection = new ProfessorCollection();
        private readonly ProfessorNegocios _professorNegocios = new ProfessorNegocios();
        private NotasCollection _notasCollection = new NotasCollection();
        private readonly NotasNegocios _notasNegocios = new NotasNegocios();

        readonly string _cursoSelecionado;

        public FrmDiarioNotas(string disciplina, string professor, string curso)
        {
            _cursoSelecionado = curso;

            InitializeComponent();
            dgv_DiarioNotas.AutoGenerateColumns = false;
            textBoxDisciplina.Text = disciplina.ToUpper();
            textBoxProfessor.Text = professor.ToUpper();

            _cursoCollection = (CursoCollection) _cursoNegocios.ConsultaCursoNome(curso);          
            _disciplinaCollection =(DisciplinaCollection) _disciplinaNegocios.ConsultaDisciplinaNome(disciplina);
            _professorCollection = (ProfessorCollection) _professorNegocios.ConsultaProfessorNome(professor);
            _notasCollection = _notasNegocios.ConsultaNotasAluno(_disciplinaCollection.First().IdDisciplina, _professorCollection.First().IdProfessor, _cursoCollection.First().IdCurso);
            dgv_DiarioNotas.DataSource = null;
            dgv_DiarioNotas.DataSource = _notasCollection;

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            dgv_DiarioNotas.SelectionMode = DataGridViewSelectionMode.CellSelect;
            colP1.ReadOnly = false;
            colP2.ReadOnly = false;
            colTrabalho.ReadOnly = false;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            
            _cursoCollection = (CursoCollection)_cursoNegocios.ConsultaCursoNome(_cursoSelecionado);           
            _disciplinaCollection =(DisciplinaCollection) _disciplinaNegocios.ConsultaDisciplinaNome(textBoxDisciplina.Text);           
            _professorCollection =(ProfessorCollection) _professorNegocios.ConsultaProfessorNome(textBoxProfessor.Text);          
            _notasCollection = dgv_DiarioNotas.DataSource as NotasCollection;
            int qtde = _notasCollection.Count;
            for (int i = 0; i < qtde; i++ )
            {
                try
                {
                    Notas notas = new Notas();
                    notas.IdCurso = _cursoCollection.First().IdCurso;
                    notas.IdDisciplina = _disciplinaCollection.First().IdDisciplina;
                    notas.IdProfessor = _professorCollection.First().IdProfessor;
                    notas.IdAluno = _notasCollection[i].IdAluno;
                    notas.P1 = _notasCollection[i].P1;
                    notas.Trabalho = _notasCollection[i].Trabalho;
                    notas.P2 = _notasCollection[i].P2;
                    notas.Media = (notas.P1 * 0.2) + (notas.Trabalho * 0.3) + (notas.P2 * 0.5);
                    if (notas.Media >= 6)
                    {
                        notas.Situacao = true;
                    }
                    else
                    {
                        notas.Situacao = false;
                    }

                    string idNotas = _notasNegocios.Alterar(notas);
                    int IdNotas = Convert.ToInt32(idNotas);
                }
                catch
                {
                    MessageBox.Show("Não foi possivel atualizar as notas", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }        
            MessageBox.Show("Notas atualizadas com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_DiarioNotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            
            _cursoCollection = (CursoCollection)_cursoNegocios.ConsultaCursoNome(_cursoSelecionado);           
            _disciplinaCollection = (DisciplinaCollection)_disciplinaNegocios.ConsultaDisciplinaNome(textBoxDisciplina.Text);
            _professorCollection =(ProfessorCollection)_professorNegocios.ConsultaProfessorNome(textBoxProfessor.Text);
            _notasCollection = _notasNegocios.ConsultaNotasAluno(_disciplinaCollection.First().IdDisciplina, _professorCollection.First().IdProfessor, _cursoCollection.First().IdCurso);
            dgv_DiarioNotas.DataSource = null;
            dgv_DiarioNotas.DataSource = _notasCollection;
        }
    }
}
