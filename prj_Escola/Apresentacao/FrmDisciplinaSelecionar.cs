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
    public partial class FrmDisciplinaSelecionar : Form
    {
        Selecao selecionado;

        public FrmDisciplinaSelecionar()
        {
            InitializeComponent();
            dgvDisciplinaSelecionar.AutoGenerateColumns = false;
            dgvDisciplinaCurso.AutoGenerateColumns = false;
     
            this.Text = "Cadastra Disciplina";
            dgvDisciplinaCurso.Visible = false;
            comboBoxCurso.Visible = false;
            buttonPesquisar.Enabled = false;
            textBoxDisciplina.Enabled = false;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {

            if (comboBoxSelecao.Text == "Disciplina")
            {
                if (textBoxDisciplina.Text == "")
                {
                    MessageBox.Show("Campo disciplina em branco", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
               
                    selecionado = Selecao.Disciplina;
                    AtualizaGrid(selecionado);
                
            }
          if (comboBoxSelecao.Text == "Curso")
          {
              if (comboBoxCurso.Text == "")
              {
                  MessageBox.Show("Campo curso não selecionado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  return;
              }
              selecionado = Selecao.Curso;
              AtualizaGrid(selecionado);
          }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            if (comboBoxSelecao.Text == "Disciplina")
            {
                if (dgvDisciplinaSelecionar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhuma disciplina selecionada", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Disciplina disciplinaSelecionada = dgvDisciplinaSelecionar.SelectedRows[0].DataBoundItem as Disciplina;
                FrmDisciplinaCadastro frm = new FrmDisciplinaCadastro(AcaoNaTela.Consultar, disciplinaSelecionada);
                DialogResult resultado = frm.ShowDialog();
                if (resultado == DialogResult.Yes)
                {
                    AtualizaGrid(Selecao.Disciplina);
                }
            }
            if (comboBoxSelecao.Text == "Curso")
            {
                if (dgvDisciplinaCurso.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhuma disciplina selecionada", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Disciplina disciplinaSelecionada = dgvDisciplinaCurso.SelectedRows[0].DataBoundItem as Disciplina;
                FrmDisciplinaCadastro frm = new FrmDisciplinaCadastro(AcaoNaTela.Consultar, disciplinaSelecionada);
                frm.ShowDialog();
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (dgvDisciplinaSelecionar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma disciplina selecionada", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Disciplina disciplinaSelecionada = dgvDisciplinaSelecionar.SelectedRows[0].DataBoundItem as Disciplina;
            FrmDisciplinaCadastro frm = new FrmDisciplinaCadastro(AcaoNaTela.Alterar, disciplinaSelecionada);
            DialogResult resultado = frm.ShowDialog();
            if(resultado == DialogResult.Yes)
            {
                AtualizaGrid(Selecao.Disciplina);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dgvDisciplinaSelecionar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma disciplina selecionada", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Disciplina disciplinaSelecionada = dgvDisciplinaSelecionar.SelectedRows[0].DataBoundItem as Disciplina;
            DialogResult resultado = MessageBox.Show("Deseja mesmo excluir a disciplina", "PERGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }        
            DisciplinaNegocios disciplinaNegocios = new DisciplinaNegocios();
            string retorno = disciplinaNegocios.Excluir(disciplinaSelecionada);
            try
            {
                int IdDisciplina = Convert.ToInt32(retorno);
                MessageBox.Show("Disciplina " + retorno + " excluida com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizaGrid(Selecao.Disciplina);
            }
            catch 
            {
                MessageBox.Show("Não foi possivel excluir a disciplina", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            FrmDisciplinaCadastro frm = new FrmDisciplinaCadastro(AcaoNaTela.Inserir, null);
            frm.ShowDialog();
            AtualizaGrid(Selecao.Nome);
        }

        public void AtualizaGrid(Selecao selecao)
        {
            if (selecao == Selecao.Disciplina)
            {
                var disciplinaCollection = new DisciplinaCollection();
                var disciplinaNegocios = new DisciplinaNegocios();
                disciplinaCollection = (DisciplinaCollection)disciplinaNegocios.ConsultaDisciplinaNome(textBoxDisciplina.Text);
                dgvDisciplinaSelecionar.DataSource = null;
                dgvDisciplinaSelecionar.DataSource = disciplinaCollection;
            }
            if (selecao == Selecao.Curso)
            {
                DisciplinaCollection disciplinaCollection = new DisciplinaCollection();
                DisciplinaNegocios disciplinaNegocios = new DisciplinaNegocios();
                disciplinaCollection = disciplinaNegocios.ConsultaDisciplinaCurso(comboBoxCurso.Text);
                dgvDisciplinaCurso.DataSource = null;
                dgvDisciplinaCurso.DataSource = disciplinaCollection;
            }
        }

        private void textBoxCurso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonPesquisar.PerformClick();
            }
        }

        private void FrmDisciplinaSelecionar_Load(object sender, EventArgs e)
        {
            CursoCollection cursoCollection = new CursoCollection();
            CursoNegocios cursoNegocios = new CursoNegocios();
            DataTable dtCurso = cursoNegocios.CarregaComboBoxCurso("%");
            foreach (DataRow linha in dtCurso.Rows)
            {
                Curso curso = new Curso();
                curso.NomeCurso = Convert.ToString(linha["NomeCurso"]);
                comboBoxCurso.Items.Add(curso.NomeCurso);
            }
        }

        private void comboBoxSelecao_TextChanged(object sender, EventArgs e)
        {
            if(comboBoxSelecao.Text == "Disciplina")
            {
                textBoxDisciplina.Clear();
                this.Text = "Cadastra Disciplina";
                comboBoxCurso.Visible = false;
                textBoxDisciplina.Visible = true;
                buttonExcluir.Enabled = true;
                dgvDisciplinaCurso.Visible = false;
                dgvDisciplinaSelecionar.Visible = true;
                buttonPesquisar.Enabled = true;
                textBoxDisciplina.Enabled = true;
            }
            if (comboBoxSelecao.Text == "Curso")
            {
                this.Text = "Consulta Disciplina";
                comboBoxCurso.Visible = true;
                textBoxDisciplina.Visible = false;
                buttonExcluir.Enabled = false;
                dgvDisciplinaCurso.Visible = true;
                dgvDisciplinaSelecionar.Visible = false;
                buttonPesquisar.Enabled = true;
            }
        }

    }
}
