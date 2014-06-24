namespace Apresentacao
{
    partial class FrmAlunoCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlunoCadastro));
            this.panelAluno = new System.Windows.Forms.Panel();
            this.buttonAlterarCurso = new System.Windows.Forms.Button();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.labelAluno = new System.Windows.Forms.Label();
            this.textBoxAluno = new System.Windows.Forms.TextBox();
            this.textBoxRA = new System.Windows.Forms.TextBox();
            this.labelCurso = new System.Windows.Forms.Label();
            this.labelRA = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDiario = new System.Windows.Forms.Panel();
            this.comboBoxProfessor = new System.Windows.Forms.ComboBox();
            this.lbProfessor = new System.Windows.Forms.Label();
            this.comboBoxCurso1 = new System.Windows.Forms.ComboBox();
            this.lbCurso = new System.Windows.Forms.Label();
            this.comboBoxAluno = new System.Windows.Forms.ComboBox();
            this.comboBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.labelProfessor = new System.Windows.Forms.Label();
            this.lbDisciplina = new System.Windows.Forms.Label();
            this.panelAluno.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDiario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAluno
            // 
            this.panelAluno.BackColor = System.Drawing.Color.White;
            this.panelAluno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAluno.Controls.Add(this.buttonAlterarCurso);
            this.panelAluno.Controls.Add(this.comboBoxCurso);
            this.panelAluno.Controls.Add(this.labelAluno);
            this.panelAluno.Controls.Add(this.textBoxAluno);
            this.panelAluno.Controls.Add(this.textBoxRA);
            this.panelAluno.Controls.Add(this.labelCurso);
            this.panelAluno.Controls.Add(this.labelRA);
            this.panelAluno.Location = new System.Drawing.Point(18, 94);
            this.panelAluno.Name = "panelAluno";
            this.panelAluno.Size = new System.Drawing.Size(528, 125);
            this.panelAluno.TabIndex = 0;
            // 
            // buttonAlterarCurso
            // 
            this.buttonAlterarCurso.BackColor = System.Drawing.Color.White;
            this.buttonAlterarCurso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAlterarCurso.Image = global::Apresentacao.Properties.Resources.page_edit;
            this.buttonAlterarCurso.Location = new System.Drawing.Point(343, 17);
            this.buttonAlterarCurso.Name = "buttonAlterarCurso";
            this.buttonAlterarCurso.Size = new System.Drawing.Size(52, 23);
            this.buttonAlterarCurso.TabIndex = 2;
            this.buttonAlterarCurso.UseVisualStyleBackColor = false;
            this.buttonAlterarCurso.Click += new System.EventHandler(this.buttonAlterarCurso_Click);
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Location = new System.Drawing.Point(82, 19);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(255, 21);
            this.comboBoxCurso.TabIndex = 1;
            // 
            // labelAluno
            // 
            this.labelAluno.AutoSize = true;
            this.labelAluno.Location = new System.Drawing.Point(33, 86);
            this.labelAluno.Name = "labelAluno";
            this.labelAluno.Size = new System.Drawing.Size(37, 13);
            this.labelAluno.TabIndex = 5;
            this.labelAluno.Text = "Aluno:";
            // 
            // textBoxAluno
            // 
            this.textBoxAluno.BackColor = System.Drawing.Color.White;
            this.textBoxAluno.Location = new System.Drawing.Point(82, 82);
            this.textBoxAluno.Name = "textBoxAluno";
            this.textBoxAluno.Size = new System.Drawing.Size(313, 20);
            this.textBoxAluno.TabIndex = 6;
            // 
            // textBoxRA
            // 
            this.textBoxRA.BackColor = System.Drawing.Color.White;
            this.textBoxRA.Location = new System.Drawing.Point(82, 51);
            this.textBoxRA.Name = "textBoxRA";
            this.textBoxRA.Size = new System.Drawing.Size(92, 20);
            this.textBoxRA.TabIndex = 4;
            this.textBoxRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.ForeColor = System.Drawing.Color.Black;
            this.labelCurso.Location = new System.Drawing.Point(33, 23);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(37, 13);
            this.labelCurso.TabIndex = 0;
            this.labelCurso.Text = "Curso:";
            // 
            // labelRA
            // 
            this.labelRA.AutoSize = true;
            this.labelRA.ForeColor = System.Drawing.Color.Black;
            this.labelRA.Location = new System.Drawing.Point(33, 55);
            this.labelRA.Name = "labelRA";
            this.labelRA.Size = new System.Drawing.Size(25, 13);
            this.labelRA.TabIndex = 3;
            this.labelRA.Text = "RA:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(471, 248);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.White;
            this.buttonConfirmar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonConfirmar.Location = new System.Drawing.Point(387, 248);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmar.TabIndex = 1;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSair);
            this.panel1.Controls.Add(this.buttonSalvar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(18, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 59);
            this.panel1.TabIndex = 3;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.White;
            this.buttonSair.Image = ((System.Drawing.Image)(resources.GetObject("buttonSair.Image")));
            this.buttonSair.Location = new System.Drawing.Point(84, 7);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(50, 45);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.White;
            this.buttonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.Image")));
            this.buttonSalvar.Location = new System.Drawing.Point(28, 7);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(50, 45);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Apresentacao.Properties.Resources.CentroPaulaSouza;
            this.pictureBox1.Location = new System.Drawing.Point(217, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelDiario
            // 
            this.panelDiario.BackColor = System.Drawing.Color.White;
            this.panelDiario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDiario.Controls.Add(this.comboBoxProfessor);
            this.panelDiario.Controls.Add(this.lbProfessor);
            this.panelDiario.Controls.Add(this.comboBoxCurso1);
            this.panelDiario.Controls.Add(this.lbCurso);
            this.panelDiario.Controls.Add(this.comboBoxAluno);
            this.panelDiario.Controls.Add(this.comboBoxDisciplina);
            this.panelDiario.Controls.Add(this.labelProfessor);
            this.panelDiario.Controls.Add(this.lbDisciplina);
            this.panelDiario.Location = new System.Drawing.Point(18, 84);
            this.panelDiario.Name = "panelDiario";
            this.panelDiario.Size = new System.Drawing.Size(528, 146);
            this.panelDiario.TabIndex = 7;
            // 
            // comboBoxProfessor
            // 
            this.comboBoxProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfessor.FormattingEnabled = true;
            this.comboBoxProfessor.Location = new System.Drawing.Point(112, 75);
            this.comboBoxProfessor.Name = "comboBoxProfessor";
            this.comboBoxProfessor.Size = new System.Drawing.Size(330, 21);
            this.comboBoxProfessor.TabIndex = 10;
            this.comboBoxProfessor.TextChanged += new System.EventHandler(this.comboBoxProfessor_TextChanged);
            // 
            // lbProfessor
            // 
            this.lbProfessor.AutoSize = true;
            this.lbProfessor.ForeColor = System.Drawing.Color.Black;
            this.lbProfessor.Location = new System.Drawing.Point(39, 79);
            this.lbProfessor.Name = "lbProfessor";
            this.lbProfessor.Size = new System.Drawing.Size(54, 13);
            this.lbProfessor.TabIndex = 9;
            this.lbProfessor.Text = "Professor:";
            // 
            // comboBoxCurso1
            // 
            this.comboBoxCurso1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurso1.FormattingEnabled = true;
            this.comboBoxCurso1.Location = new System.Drawing.Point(112, 17);
            this.comboBoxCurso1.Name = "comboBoxCurso1";
            this.comboBoxCurso1.Size = new System.Drawing.Size(330, 21);
            this.comboBoxCurso1.TabIndex = 8;
            this.comboBoxCurso1.TextChanged += new System.EventHandler(this.comboBoxCurso1_TextChanged);
            // 
            // lbCurso
            // 
            this.lbCurso.AutoSize = true;
            this.lbCurso.ForeColor = System.Drawing.Color.Black;
            this.lbCurso.Location = new System.Drawing.Point(39, 21);
            this.lbCurso.Name = "lbCurso";
            this.lbCurso.Size = new System.Drawing.Size(37, 13);
            this.lbCurso.TabIndex = 7;
            this.lbCurso.Text = "Curso:";
            // 
            // comboBoxAluno
            // 
            this.comboBoxAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAluno.FormattingEnabled = true;
            this.comboBoxAluno.Location = new System.Drawing.Point(112, 104);
            this.comboBoxAluno.Name = "comboBoxAluno";
            this.comboBoxAluno.Size = new System.Drawing.Size(330, 21);
            this.comboBoxAluno.TabIndex = 6;
            // 
            // comboBoxDisciplina
            // 
            this.comboBoxDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisciplina.FormattingEnabled = true;
            this.comboBoxDisciplina.Location = new System.Drawing.Point(112, 46);
            this.comboBoxDisciplina.Name = "comboBoxDisciplina";
            this.comboBoxDisciplina.Size = new System.Drawing.Size(330, 21);
            this.comboBoxDisciplina.TabIndex = 5;
            this.comboBoxDisciplina.TextChanged += new System.EventHandler(this.comboBoxDisciplina_TextChanged);
            // 
            // labelProfessor
            // 
            this.labelProfessor.AutoSize = true;
            this.labelProfessor.ForeColor = System.Drawing.Color.Black;
            this.labelProfessor.Location = new System.Drawing.Point(39, 108);
            this.labelProfessor.Name = "labelProfessor";
            this.labelProfessor.Size = new System.Drawing.Size(37, 13);
            this.labelProfessor.TabIndex = 3;
            this.labelProfessor.Text = "Aluno:";
            // 
            // lbDisciplina
            // 
            this.lbDisciplina.AutoSize = true;
            this.lbDisciplina.ForeColor = System.Drawing.Color.Black;
            this.lbDisciplina.Location = new System.Drawing.Point(39, 50);
            this.lbDisciplina.Name = "lbDisciplina";
            this.lbDisciplina.Size = new System.Drawing.Size(55, 13);
            this.lbDisciplina.TabIndex = 0;
            this.lbDisciplina.Text = "Disciplina:";
            // 
            // FrmAlunoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 283);
            this.ControlBox = false;
            this.Controls.Add(this.panelDiario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.panelAluno);
            this.Controls.Add(this.buttonConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlunoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlunoCadastro";
            this.Load += new System.EventHandler(this.FrmAlunoCadastro_Load);
            this.panelAluno.ResumeLayout(false);
            this.panelAluno.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDiario.ResumeLayout(false);
            this.panelDiario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAluno;
        private System.Windows.Forms.TextBox textBoxAluno;
        private System.Windows.Forms.TextBox textBoxRA;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.Label labelRA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.ComboBox comboBoxCurso;
        private System.Windows.Forms.Label labelAluno;
        private System.Windows.Forms.Button buttonAlterarCurso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Panel panelDiario;
        private System.Windows.Forms.ComboBox comboBoxAluno;
        private System.Windows.Forms.ComboBox comboBoxDisciplina;
        private System.Windows.Forms.Label labelProfessor;
        private System.Windows.Forms.Label lbDisciplina;
        private System.Windows.Forms.ComboBox comboBoxCurso1;
        private System.Windows.Forms.Label lbCurso;
        private System.Windows.Forms.ComboBox comboBoxProfessor;
        private System.Windows.Forms.Label lbProfessor;
    }
}