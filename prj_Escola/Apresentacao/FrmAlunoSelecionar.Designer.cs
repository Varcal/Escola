namespace Apresentacao
{
    partial class FrmAlunoSelecionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlunoSelecionar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxSelecao = new System.Windows.Forms.ComboBox();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.textBoxAluno = new System.Windows.Forms.TextBox();
            this.dgvAlunoSelecionar = new System.Windows.Forms.DataGridView();
            this.colRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.dgvAlunoCurso = new System.Windows.Forms.DataGridView();
            this.colCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunoSelecionar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunoCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBoxSelecao);
            this.panel2.Controls.Add(this.comboBoxCurso);
            this.panel2.Controls.Add(this.buttonPesquisar);
            this.panel2.Controls.Add(this.textBoxAluno);
            this.panel2.Location = new System.Drawing.Point(27, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 74);
            this.panel2.TabIndex = 1;
            // 
            // comboBoxSelecao
            // 
            this.comboBoxSelecao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelecao.FormattingEnabled = true;
            this.comboBoxSelecao.Items.AddRange(new object[] {
            "Escolha Opção",
            "RA",
            "Aluno",
            "Curso"});
            this.comboBoxSelecao.Location = new System.Drawing.Point(20, 24);
            this.comboBoxSelecao.Name = "comboBoxSelecao";
            this.comboBoxSelecao.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelecao.TabIndex = 0;
            this.comboBoxSelecao.TextChanged += new System.EventHandler(this.comboBoxSelecao_TextChanged);
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.BackColor = System.Drawing.Color.White;
            this.comboBoxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Location = new System.Drawing.Point(157, 24);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(327, 21);
            this.comboBoxCurso.TabIndex = 2;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackColor = System.Drawing.Color.White;
            this.buttonPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("buttonPesquisar.Image")));
            this.buttonPesquisar.Location = new System.Drawing.Point(499, 23);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(52, 23);
            this.buttonPesquisar.TabIndex = 3;
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // textBoxAluno
            // 
            this.textBoxAluno.Location = new System.Drawing.Point(157, 24);
            this.textBoxAluno.Name = "textBoxAluno";
            this.textBoxAluno.Size = new System.Drawing.Size(327, 20);
            this.textBoxAluno.TabIndex = 1;
            // 
            // dgvAlunoSelecionar
            // 
            this.dgvAlunoSelecionar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAlunoSelecionar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunoSelecionar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRA,
            this.colAluno});
            this.dgvAlunoSelecionar.Location = new System.Drawing.Point(27, 201);
            this.dgvAlunoSelecionar.MultiSelect = false;
            this.dgvAlunoSelecionar.Name = "dgvAlunoSelecionar";
            this.dgvAlunoSelecionar.ReadOnly = true;
            this.dgvAlunoSelecionar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunoSelecionar.Size = new System.Drawing.Size(590, 238);
            this.dgvAlunoSelecionar.TabIndex = 2;
            // 
            // colRA
            // 
            this.colRA.DataPropertyName = "IdAluno";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colRA.DefaultCellStyle = dataGridViewCellStyle1;
            this.colRA.HeaderText = "RA";
            this.colRA.Name = "colRA";
            this.colRA.ReadOnly = true;
            this.colRA.Width = 98;
            // 
            // colAluno
            // 
            this.colAluno.DataPropertyName = "NomeAluno";
            this.colAluno.HeaderText = "Aluno";
            this.colAluno.Name = "colAluno";
            this.colAluno.ReadOnly = true;
            this.colAluno.Width = 447;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonSair);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonConsultar);
            this.panel1.Controls.Add(this.buttonAlterar);
            this.panel1.Controls.Add(this.buttonExcluir);
            this.panel1.Controls.Add(this.buttonNovo);
            this.panel1.Location = new System.Drawing.Point(27, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 70);
            this.panel1.TabIndex = 0;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.White;
            this.buttonSair.Image = global::Apresentacao.Properties.Resources.door_out;
            this.buttonSair.Location = new System.Drawing.Point(384, 10);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 47);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(477, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackColor = System.Drawing.Color.White;
            this.buttonConsultar.Image = global::Apresentacao.Properties.Resources.lupa_16x16;
            this.buttonConsultar.Location = new System.Drawing.Point(293, 10);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 47);
            this.buttonConsultar.TabIndex = 3;
            this.buttonConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.Color.White;
            this.buttonAlterar.Image = global::Apresentacao.Properties.Resources.page_edit;
            this.buttonAlterar.Location = new System.Drawing.Point(202, 10);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 47);
            this.buttonAlterar.TabIndex = 2;
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.White;
            this.buttonExcluir.Image = global::Apresentacao.Properties.Resources.Delete_1_;
            this.buttonExcluir.Location = new System.Drawing.Point(111, 10);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 47);
            this.buttonExcluir.TabIndex = 1;
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackColor = System.Drawing.Color.White;
            this.buttonNovo.Image = global::Apresentacao.Properties.Resources.Add_1_;
            this.buttonNovo.Location = new System.Drawing.Point(20, 10);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(75, 47);
            this.buttonNovo.TabIndex = 0;
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // dgvAlunoCurso
            // 
            this.dgvAlunoCurso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAlunoCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunoCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCurso,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvAlunoCurso.Location = new System.Drawing.Point(27, 201);
            this.dgvAlunoCurso.MultiSelect = false;
            this.dgvAlunoCurso.Name = "dgvAlunoCurso";
            this.dgvAlunoCurso.ReadOnly = true;
            this.dgvAlunoCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunoCurso.Size = new System.Drawing.Size(590, 245);
            this.dgvAlunoCurso.TabIndex = 3;
            // 
            // colCurso
            // 
            this.colCurso.DataPropertyName = "NomeCurso";
            this.colCurso.HeaderText = "Curso";
            this.colCurso.Name = "colCurso";
            this.colCurso.ReadOnly = true;
            this.colCurso.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdAluno";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "RA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeAluno";
            this.dataGridViewTextBoxColumn2.HeaderText = "Aluno";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 247;
            // 
            // FrmAlunoSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 459);
            this.Controls.Add(this.dgvAlunoCurso);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvAlunoSelecionar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmAlunoSelecionar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlunoSelecionar";
            this.Load += new System.EventHandler(this.FrmAlunoSelecionar_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunoSelecionar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunoCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxAluno;
        private System.Windows.Forms.DataGridView dgvAlunoSelecionar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.DataGridView dgvAlunoCurso;
        private System.Windows.Forms.ComboBox comboBoxCurso;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.ComboBox comboBoxSelecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}