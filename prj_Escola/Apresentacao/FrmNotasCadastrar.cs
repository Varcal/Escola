using System.Globalization;
using DTO;
using Negocios;
using System;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmNotasCadastrar : Form
    {

        public FrmNotasCadastrar(AcaoNaTela acaoNaTela,Professor professor)
        {
            
            InitializeComponent();                     
            textBoxProfessor.Focus();

                if (acaoNaTela == AcaoNaTela.Inserir)
                {
                    textBoxProfessor.ReadOnly = true;
                    textBoxProfessor.Text = @"Clique no botão de pesquisa";                    
                    comboBoxDisciplina.Enabled = false;
                    comboBoxCurso.Enabled = false;
                }

                if (acaoNaTela == AcaoNaTela.Consultar)
                {
                    textBoxRegistro.Text = professor.IdProfessor.ToString(CultureInfo.InvariantCulture);
                    textBoxProfessor.ReadOnly = true;
                    textBoxProfessor.Text = professor.NomeProfessor;
                    comboBoxDisciplina.Enabled = true;  
                }
         }        
         
        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPesquisaProfessor_Click(object sender, EventArgs e)
        {
            var professorNegocios = new ProfessorNegocios();
            var professorCollection = (ProfessorCollection) professorNegocios.ConsultaProfessorNome("%");        
            var frm = new FrmSelecionaProfessor(professorCollection);
            frm.ShowDialog();
            DialogResult = DialogResult.Yes;
        }

        private void buttonSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPesquisaRegistro_Click(object sender, EventArgs e)
        {
            if (textBoxRegistro.Text == "")
            {
                MessageBox.Show("Campo registro não digitado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var professorNegocios = new ProfessorNegocios();
            Professor professor = professorNegocios.ConsultaProfessorId(textBoxRegistro.Text);
            textBoxRegistro.Text = professor.IdProfessor.ToString();
            textBoxProfessor.Text = professor.NomeProfessor;        
            comboBoxDisciplina.Enabled = true;        
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            var frm = new FrmDiarioNotas(comboBoxDisciplina.SelectedItem.ToString(),textBoxProfessor.Text, comboBoxCurso.SelectedItem.ToString());
            Visible = false;
            frm.ShowDialog();
            DialogResult = DialogResult.Yes;
        }

        private void buttonSalvar_Click_1(object sender, EventArgs e)
        {
            buttonInserir_Click(sender, e);
        }

       

        private void textBoxProfessor_TextChanged(object sender, EventArgs e)
        {
            string selecionado = textBoxProfessor.Text;
            comboBoxDisciplina.Items.Clear();
            comboBoxDisciplina.Items.Add("Selecione Disciplina");
            var professorNegocios = new ProfessorNegocios();
            var professorCollection = professorNegocios.ConsultaProfessorDisciplina(selecionado);    
            foreach (Professor professor in professorCollection)
            {
                comboBoxDisciplina.Items.Add(professor.NomeDisciplina);
            }
            comboBoxDisciplina.SelectedIndex = 0;
        }

        private void comboBoxDisciplina_TextChanged(object sender, EventArgs e)
        {

            if (comboBoxDisciplina.SelectedItem.ToString() == "Selecione Disciplina")
            {
                return;
            }
            comboBoxCurso.Items.Clear();
            comboBoxCurso.Items.Add("Selecione o curso");
            comboBoxCurso.SelectedIndex = 0;
            var disciplinaNegocios = new DisciplinaNegocios();
            var disciplinaCollection = (DisciplinaCollection) disciplinaNegocios.ConsultaDisciplinaNome(comboBoxDisciplina.SelectedItem.ToString());
            disciplinaCollection = disciplinaNegocios.ConsultaCursoDisciplina(0,disciplinaCollection[0].IdDisciplina);
            foreach (Disciplina disciplina in disciplinaCollection)
            {
                comboBoxCurso.Items.Add(disciplina.NomeCurso);
            }
            comboBoxCurso.Enabled = true;
        } 
    }
}
