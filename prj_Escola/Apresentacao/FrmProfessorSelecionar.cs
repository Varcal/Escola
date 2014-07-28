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
    public partial class FrmProfessorSelecionar : Form
    {
        Selecao selecionado;

        public FrmProfessorSelecionar()
        {
            InitializeComponent();
            dgvProfessor.AutoGenerateColumns = false;
            dgvProfessorDisciplina.AutoGenerateColumns = false;
            comboBoxProfessor.Enabled = false;
            textBoxRegistro.Enabled = false;
            buttonPesquisar.Enabled = false;
            comboBoxSelecao.SelectedIndex = 0;     
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            FrmProfessorCadastro frm = new FrmProfessorCadastro(AcaoNaTela.Inserir, null, Selecao.Professor);
            DialogResult resultado = frm.ShowDialog();      
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {

            if (comboBoxSelecao.Text == "Registro"|| comboBoxSelecao.Text == "Nome")
            {
                if (dgvProfessor.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum professor selecionado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Professor professorSelecionado = dgvProfessor.SelectedRows[0].DataBoundItem as Professor;
                FrmProfessorCadastro frm = new FrmProfessorCadastro(AcaoNaTela.Consultar,professorSelecionado,Selecao.Professor);
                frm.ShowDialog();
            }
          
            if(comboBoxSelecao.Text == "Professor")
            {
                if (dgvProfessorDisciplina.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum professor selecionado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Professor professorSelecionado = dgvProfessorDisciplina.SelectedRows[0].DataBoundItem as Professor;
                FrmProfessorCadastro frm = new FrmProfessorCadastro(AcaoNaTela.Consultar, professorSelecionado, Selecao.Professor);
                frm.ShowDialog();
                }
        }

        public void AtualizaGrid(Selecao selecionado)
        {
            if (selecionado == Selecao.Disciplina)
            {
                ProfessorCollection professorCollection = new ProfessorCollection();
                ProfessorNegocios professorNegocios = new ProfessorNegocios();
                if (comboBoxProfessor.Text == "Mostrar Todos")
                {
                    professorCollection = professorNegocios.ConsultaProfessorDisciplina("%");
                }
                else
                {
                    professorCollection = professorNegocios.ConsultaProfessorDisciplina(comboBoxProfessor.Text);
                }
                dgvProfessorDisciplina.DataSource = null;
                dgvProfessorDisciplina.DataSource = professorCollection;
            }

            if (selecionado == Selecao.Professor)
            {
                Professor professor = new Professor();
                ProfessorCollection professorCollection = new ProfessorCollection();
                ProfessorNegocios professorNegocios = new ProfessorNegocios();              
                professor = professorNegocios.ConsultaProfessorId(textBoxRegistro.Text);
                professorCollection.Add(professor);        
                dgvProfessor.DataSource = null;
                dgvProfessor.DataSource = professorCollection;
            }
            if (selecionado == Selecao.Nome)
            {
                ProfessorCollection professorCollection = new ProfessorCollection();
                ProfessorNegocios professorNegocios = new ProfessorNegocios();
                if (textBoxRegistro.Text == "")
                {
                    professorCollection = (ProfessorCollection)professorNegocios.ListarTodos();
                }
                else 
                {
                    professorCollection = (ProfessorCollection)professorNegocios.ConsultaProfessorNome(textBoxRegistro.Text);
                }
                
                dgvProfessor.DataSource = null;
                dgvProfessor.DataSource = professorCollection;
            }

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (textBoxRegistro.Text == "" && comboBoxSelecao.Text == "Registro")
            {
                MessageBox.Show("Digite um resgsitro", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(comboBoxSelecao.Text == "Nome")
            {                
                selecionado = Selecao.Nome;
                AtualizaGrid(selecionado);
                textBoxRegistro.Clear();
            }
            if(comboBoxSelecao.Text == "Registro")
            {
                selecionado = Selecao.Professor;
                AtualizaGrid(selecionado);
                textBoxRegistro.Clear();
            }
            if (comboBoxSelecao.Text == "Professor")
            {
                selecionado = Selecao.Disciplina;
                AtualizaGrid(selecionado);
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if(comboBoxSelecao.Text == "Registro" || comboBoxSelecao.Text == "Nome")
            {
                if (dgvProfessor.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum professor selecionado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Professor professorSelecionado = dgvProfessor.SelectedRows[0].DataBoundItem as Professor;
                FrmProfessorCadastro frm = new FrmProfessorCadastro(AcaoNaTela.Alterar, professorSelecionado,Selecao.Professor);
                DialogResult resultado = frm.ShowDialog();
                if (resultado == DialogResult.Yes)
                {
                    if(comboBoxSelecao.Text == "Registro")
                    AtualizaGrid(Selecao.Professor);

                    if(comboBoxSelecao.Text == "Nome")
                    AtualizaGrid(Selecao.Nome);
                }
            }

            if (comboBoxSelecao.Text == "Professor")
            {
                if (dgvProfessorDisciplina.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum professor selecionado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Professor professorSelecionado = dgvProfessorDisciplina.SelectedRows[0].DataBoundItem as Professor;
                FrmProfessorCadastro frm = new FrmProfessorCadastro(AcaoNaTela.Alterar, professorSelecionado, Selecao.Professor);
                DialogResult resultado = frm.ShowDialog();
                if (resultado == DialogResult.Yes)
                {
                    AtualizaGrid(Selecao.Disciplina);
                }
            }
            

        }

        private void comboBoxSelecao_TextChanged(object sender, EventArgs e)
        {
            if(comboBoxSelecao.Text == "Registro")
            {
                
                dgvProfessor.DataSource = null;
                dgvProfessor.Visible = true;
                dgvProfessorDisciplina.Visible = false;
                buttonPesquisar.Enabled = true;
                comboBoxProfessor.Visible = false;
                textBoxRegistro.Visible = true;
                textBoxRegistro.Enabled = true;
                buttonPesquisar.Enabled = true;
                buttonAlterar.Enabled = true;
                buttonAlterar.TabStop = true;
                buttonConsultar.Enabled = true;
                buttonConsultar.TabStop = true;
                buttonExcluir.Enabled = true;
                buttonExcluir.TabStop = true;
                textBoxRegistro.TextAlign = HorizontalAlignment.Center;
            }

            if (comboBoxSelecao.Text == "Nome")
            {
                dgvProfessor.DataSource = null;
                dgvProfessor.Visible = true;
                dgvProfessorDisciplina.Visible = false;
                buttonPesquisar.Enabled = true;
                comboBoxProfessor.Visible = false;
                textBoxRegistro.Visible = true;
                textBoxRegistro.Enabled = true;
                buttonPesquisar.Enabled = true;
                buttonAlterar.Enabled = true;
                buttonAlterar.TabStop = true;
                buttonConsultar.Enabled = true;
                buttonConsultar.TabStop = true;
                buttonExcluir.Enabled = true;
                buttonExcluir.TabStop = true;
                textBoxRegistro.TextAlign = HorizontalAlignment.Left;
            }

            if(comboBoxSelecao.Text == "Professor")
            {
                dgvProfessorDisciplina.DataSource = null;
                dgvProfessor.Visible = false;
                dgvProfessorDisciplina.Visible = true;
                buttonPesquisar.Enabled = true;
                textBoxRegistro.Visible = false;
                textBoxRegistro.Enabled = false;
                comboBoxProfessor.Visible = true;
                comboBoxProfessor.Enabled = true;
                buttonPesquisar.Enabled = true;              
                comboBoxProfessor.Items.Clear();
                comboBoxProfessor.Items.Add("Mostrar Todos");
                comboBoxProfessor.SelectedIndex = 0;
                buttonAlterar.Enabled = false;
                buttonAlterar.TabStop = false;
                buttonConsultar.Enabled = false;
                buttonConsultar.TabStop = false;
                buttonExcluir.Enabled = false;
                buttonExcluir.TabStop = false;
                ProfessorCollection professorCollection = new ProfessorCollection();
                ProfessorNegocios professorNegocios = new ProfessorNegocios();
                professorCollection =(ProfessorCollection) professorNegocios.ConsultaProfessorNome("%");
                foreach (Professor professor in professorCollection)
                {
                    comboBoxProfessor.Items.Add(professor.NomeProfessor);
                }              
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (comboBoxSelecao.Text == "Nome" || comboBoxSelecao.Text == "Registro")
            {
                if (dgvProfessor.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum professor selecionado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Professor professorSelecionado = dgvProfessor.SelectedRows[0].DataBoundItem as Professor;
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir", "PERGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                ProfessorNegocios professorNegocios = new ProfessorNegocios();
                string retorno = professorNegocios.Excluir(professorSelecionado);
                string retornoDisciplina = professorNegocios.ExcluirProfessorDisciplina(professorSelecionado);
                try
                {
                    int IdProfessor = Convert.ToInt32(retorno);
                    int IdProfessorDisciplina = Convert.ToInt32(retornoDisciplina);
                    MessageBox.Show("Professor excluido com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizaGrid(Selecao.Nome);
                }
                catch
                {
                    MessageBox.Show("Professor não pode ser excluido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
            if (comboBoxSelecao.Text == "Professor")
            {
                if (dgvProfessorDisciplina.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum professor selecionado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Professor professorSelecionado = dgvProfessorDisciplina.SelectedRows[0].DataBoundItem as Professor;
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir", "PERGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                ProfessorNegocios professorNegocios = new ProfessorNegocios();
                string retorno = professorNegocios.Excluir(professorSelecionado);
                string retornoDisciplina = professorNegocios.ExcluirProfessorDisciplina(professorSelecionado);
                try
                {
                    int IdProfessor = Convert.ToInt32(retorno);
                    int IdProfessorDisciplina = Convert.ToInt32(retornoDisciplina);
                    MessageBox.Show("Professor excluido com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizaGrid(Selecao.Disciplina);
                }
                catch
                {
                    MessageBox.Show("Professor não pode ser excluido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
