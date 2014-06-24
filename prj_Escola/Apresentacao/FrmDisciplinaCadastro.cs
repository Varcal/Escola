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
    public partial class FrmDisciplinaCadastro : Form
    {
        AcaoNaTela acaoSelecionada;
        

        public FrmDisciplinaCadastro(AcaoNaTela acaoNaTela, Disciplina disciplina)
        {
            InitializeComponent();
            acaoSelecionada = acaoNaTela;         

           
                if (acaoNaTela == AcaoNaTela.Inserir)
                {
                    this.Text = "Cadastro de Disciplinas";
                    textBoxCodigo.ReadOnly = true;
                    textBoxCodigo.TabStop = false;
                    textBoxDisciplina.Focus();
                }
                if (acaoNaTela == AcaoNaTela.Alterar)
                {
                    this.Text = "Altera Disciplinas";
                    textBoxCodigo.Text = disciplina.IdDisciplina.ToString();
                    textBoxDisciplina.Text = disciplina.NomeDisciplina;
                    textBoxCodigo.ReadOnly = true;
                    textBoxCodigo.TabStop = false;
                    textBoxDisciplina.Focus();
                }
                if (acaoNaTela == AcaoNaTela.Consultar)
                {
                    this.Text = "Consulta Disciplinas";
                    textBoxCodigo.Text = disciplina.IdDisciplina.ToString();
                    textBoxDisciplina.Text = disciplina.NomeDisciplina;
                    textBoxCodigo.ReadOnly = true;
                    textBoxCodigo.TabStop = false;
                    textBoxDisciplina.ReadOnly = true;
                    textBoxDisciplina.TabStop = false;
                    buttonConfirmar.Visible = false;
                    buttonCancelar.Text = "Sair";                   
                    buttonCancelar.Focus();
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
                Disciplina disciplina = new Disciplina();
                DisciplinaNegocios disiciplinaNegocios = new DisciplinaNegocios();
                disciplina.NomeDisciplina = textBoxDisciplina.Text;
                string retorno = disiciplinaNegocios.Salvar(disciplina);
                try
                {
                    int IdDisciplina = Convert.ToInt32(retorno);
                    MessageBox.Show("Disciplina " + retorno + " inserida com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel inserir nova disciplina", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.No;
                }

            }
            if (acaoSelecionada == AcaoNaTela.Alterar)
            {
                Disciplina disciplina = new Disciplina();
                DisciplinaNegocios disciplinaNegocios = new DisciplinaNegocios();
                disciplina.IdDisciplina = Convert.ToInt32(textBoxCodigo.Text);
                disciplina.NomeDisciplina = textBoxDisciplina.Text;
                string retorno = disciplinaNegocios.Salvar(disciplina);
                try
                {
                    int IdDisciplina = Convert.ToInt32(retorno);
                    MessageBox.Show("Disciplina " + retorno + " alterada com sucesso.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel alterar a disciplina.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.No;
                }
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            buttonConfirmar_Click(sender,e);
        }
    }
}
