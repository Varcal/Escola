namespace Apresentacao
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemSecretaria = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCadastroAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDisciplina = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.apoioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInserirDisciplinasNosCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemInserirProfessorDisciplna = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirAlunoNoDisciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxInicial = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(780, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.IsLink = true;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel1.Text = "Versão 1.0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSecretaria,
            this.MenuItemNotas,
            this.MenuItemAluno,
            this.MenuItemSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemSecretaria
            // 
            this.MenuItemSecretaria.BackColor = System.Drawing.Color.White;
            this.MenuItemSecretaria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCadastro,
            this.apoioToolStripMenuItem});
            this.MenuItemSecretaria.ForeColor = System.Drawing.Color.Red;
            this.MenuItemSecretaria.Name = "MenuItemSecretaria";
            this.MenuItemSecretaria.Size = new System.Drawing.Size(70, 20);
            this.MenuItemSecretaria.Text = "Secretaria";
            // 
            // MenuItemCadastro
            // 
            this.MenuItemCadastro.BackColor = System.Drawing.Color.White;
            this.MenuItemCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCursos,
            this.MenuItemCadastroAlunos,
            this.MenuItemDisciplina,
            this.MenuItemProfessor});
            this.MenuItemCadastro.ForeColor = System.Drawing.Color.Red;
            this.MenuItemCadastro.Name = "MenuItemCadastro";
            this.MenuItemCadastro.Size = new System.Drawing.Size(152, 22);
            this.MenuItemCadastro.Text = "Cadastros";
            // 
            // MenuItemCursos
            // 
            this.MenuItemCursos.BackColor = System.Drawing.Color.White;
            this.MenuItemCursos.ForeColor = System.Drawing.Color.Red;
            this.MenuItemCursos.Name = "MenuItemCursos";
            this.MenuItemCursos.Size = new System.Drawing.Size(125, 22);
            this.MenuItemCursos.Text = "Cursos";
            this.MenuItemCursos.Click += new System.EventHandler(this.MenuItemCursos_Click);
            // 
            // MenuItemCadastroAlunos
            // 
            this.MenuItemCadastroAlunos.BackColor = System.Drawing.Color.White;
            this.MenuItemCadastroAlunos.ForeColor = System.Drawing.Color.Red;
            this.MenuItemCadastroAlunos.Name = "MenuItemCadastroAlunos";
            this.MenuItemCadastroAlunos.Size = new System.Drawing.Size(125, 22);
            this.MenuItemCadastroAlunos.Text = "Alunos";
            this.MenuItemCadastroAlunos.Click += new System.EventHandler(this.MenuItemAlunos_Click);
            // 
            // MenuItemDisciplina
            // 
            this.MenuItemDisciplina.BackColor = System.Drawing.Color.White;
            this.MenuItemDisciplina.ForeColor = System.Drawing.Color.Red;
            this.MenuItemDisciplina.Name = "MenuItemDisciplina";
            this.MenuItemDisciplina.Size = new System.Drawing.Size(125, 22);
            this.MenuItemDisciplina.Text = "Disciplina";
            this.MenuItemDisciplina.Click += new System.EventHandler(this.MenuItemDisciplina_Click);
            // 
            // MenuItemProfessor
            // 
            this.MenuItemProfessor.BackColor = System.Drawing.Color.White;
            this.MenuItemProfessor.ForeColor = System.Drawing.Color.Red;
            this.MenuItemProfessor.Name = "MenuItemProfessor";
            this.MenuItemProfessor.Size = new System.Drawing.Size(125, 22);
            this.MenuItemProfessor.Text = "Professor";
            this.MenuItemProfessor.Click += new System.EventHandler(this.MenuItemProfessor_Click);
            // 
            // apoioToolStripMenuItem
            // 
            this.apoioToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.apoioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemInserirDisciplinasNosCursos,
            this.MenuItemInserirProfessorDisciplna,
            this.inserirAlunoNoDisciplinaToolStripMenuItem});
            this.apoioToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.apoioToolStripMenuItem.Name = "apoioToolStripMenuItem";
            this.apoioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.apoioToolStripMenuItem.Text = "Apoio";
            // 
            // MenuItemInserirDisciplinasNosCursos
            // 
            this.MenuItemInserirDisciplinasNosCursos.BackColor = System.Drawing.Color.White;
            this.MenuItemInserirDisciplinasNosCursos.ForeColor = System.Drawing.Color.Red;
            this.MenuItemInserirDisciplinasNosCursos.Name = "MenuItemInserirDisciplinasNosCursos";
            this.MenuItemInserirDisciplinasNosCursos.Size = new System.Drawing.Size(226, 22);
            this.MenuItemInserirDisciplinasNosCursos.Text = "Inserir Disciplinas nos Cursos";
            this.MenuItemInserirDisciplinasNosCursos.Click += new System.EventHandler(this.MenuItemInserirDisciplinaCurso_Click);
            // 
            // MenuItemInserirProfessorDisciplna
            // 
            this.MenuItemInserirProfessorDisciplna.BackColor = System.Drawing.Color.White;
            this.MenuItemInserirProfessorDisciplna.ForeColor = System.Drawing.Color.Red;
            this.MenuItemInserirProfessorDisciplna.Name = "MenuItemInserirProfessorDisciplna";
            this.MenuItemInserirProfessorDisciplna.Size = new System.Drawing.Size(226, 22);
            this.MenuItemInserirProfessorDisciplna.Text = "Inserir Professor na Disciplna";
            this.MenuItemInserirProfessorDisciplna.Click += new System.EventHandler(this.MenuItemInserirProfessorDisciplna_Click);
            // 
            // inserirAlunoNoDisciplinaToolStripMenuItem
            // 
            this.inserirAlunoNoDisciplinaToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.inserirAlunoNoDisciplinaToolStripMenuItem.Name = "inserirAlunoNoDisciplinaToolStripMenuItem";
            this.inserirAlunoNoDisciplinaToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.inserirAlunoNoDisciplinaToolStripMenuItem.Text = "Inserir Aluno no Disciplina";
            this.inserirAlunoNoDisciplinaToolStripMenuItem.Click += new System.EventHandler(this.inserirAlunoNoDisciplinaToolStripMenuItem_Click);
            // 
            // MenuItemNotas
            // 
            this.MenuItemNotas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem});
            this.MenuItemNotas.ForeColor = System.Drawing.Color.Red;
            this.MenuItemNotas.Name = "MenuItemNotas";
            this.MenuItemNotas.Size = new System.Drawing.Size(106, 20);
            this.MenuItemNotas.Text = "Diario Eletronico";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.inserirToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.inserirToolStripMenuItem.Text = "Inserir Notas";
            this.inserirToolStripMenuItem.Click += new System.EventHandler(this.MenuItemNotas_Click);
            // 
            // MenuItemAluno
            // 
            this.MenuItemAluno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaNotasToolStripMenuItem});
            this.MenuItemAluno.ForeColor = System.Drawing.Color.Red;
            this.MenuItemAluno.Name = "MenuItemAluno";
            this.MenuItemAluno.Size = new System.Drawing.Size(51, 20);
            this.MenuItemAluno.Text = "Aluno";
            // 
            // consultaNotasToolStripMenuItem
            // 
            this.consultaNotasToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.consultaNotasToolStripMenuItem.Name = "consultaNotasToolStripMenuItem";
            this.consultaNotasToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.consultaNotasToolStripMenuItem.Text = "Consulta Notas";
            this.consultaNotasToolStripMenuItem.Click += new System.EventHandler(this.consultaNotasToolStripMenuItem_Click);
            // 
            // MenuItemSair
            // 
            this.MenuItemSair.BackColor = System.Drawing.Color.Transparent;
            this.MenuItemSair.ForeColor = System.Drawing.Color.Red;
            this.MenuItemSair.Name = "MenuItemSair";
            this.MenuItemSair.Size = new System.Drawing.Size(38, 20);
            this.MenuItemSair.Text = "Sair";
            this.MenuItemSair.Click += new System.EventHandler(this.MenuItemSair_Click);
            // 
            // pictureBoxInicial
            // 
            this.pictureBoxInicial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxInicial.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInicial.Image")));
            this.pictureBoxInicial.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxInicial.Name = "pictureBoxInicial";
            this.pictureBoxInicial.Size = new System.Drawing.Size(780, 511);
            this.pictureBoxInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInicial.TabIndex = 4;
            this.pictureBoxInicial.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.pictureBoxInicial);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "FrmMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FATEC  - ZL";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSair;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNotas;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSecretaria;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCadastro;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCursos;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCadastroAlunos;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDisciplina;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProfessor;
        private System.Windows.Forms.PictureBox pictureBoxInicial;
        private System.Windows.Forms.ToolStripMenuItem apoioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInserirDisciplinasNosCursos;
        private System.Windows.Forms.ToolStripMenuItem MenuItemInserirProfessorDisciplna;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAluno;
        private System.Windows.Forms.ToolStripMenuItem consultaNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirAlunoNoDisciplinaToolStripMenuItem;
    }
}