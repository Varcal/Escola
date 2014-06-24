namespace Apresentacao
{
    partial class FrmDisciplinaSelecionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisciplinaSelecionar));
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxSelecao = new System.Windows.Forms.ComboBox();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.textBoxDisciplina = new System.Windows.Forms.TextBox();
            this.dgvDisciplinaSelecionar = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDisciplinaCurso = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinaSelecionar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinaCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBoxSelecao);
            this.panel2.Controls.Add(this.comboBoxCurso);
            this.panel2.Controls.Add(this.buttonPesquisar);
            this.panel2.Controls.Add(this.textBoxDisciplina);
            this.panel2.Location = new System.Drawing.Point(27, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 74);
            this.panel2.TabIndex = 5;
            // 
            // comboBoxSelecao
            // 
            this.comboBoxSelecao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelecao.FormattingEnabled = true;
            this.comboBoxSelecao.Items.AddRange(new object[] {
            "Disciplina",
            "Curso"});
            this.comboBoxSelecao.Location = new System.Drawing.Point(20, 27);
            this.comboBoxSelecao.Name = "comboBoxSelecao";
            this.comboBoxSelecao.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelecao.TabIndex = 5;
            this.comboBoxSelecao.TextChanged += new System.EventHandler(this.comboBoxSelecao_TextChanged);
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Location = new System.Drawing.Point(158, 27);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(326, 21);
            this.comboBoxCurso.TabIndex = 4;
            // 
            // textBoxDisciplina
            // 
            this.textBoxDisciplina.Location = new System.Drawing.Point(158, 27);
            this.textBoxDisciplina.Name = "textBoxDisciplina";
            this.textBoxDisciplina.Size = new System.Drawing.Size(326, 20);
            this.textBoxDisciplina.TabIndex = 1;
            this.textBoxDisciplina.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCurso_KeyDown);
            // 
            // dgvDisciplinaSelecionar
            // 
            this.dgvDisciplinaSelecionar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDisciplinaSelecionar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplinaSelecionar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colCurso});
            this.dgvDisciplinaSelecionar.Location = new System.Drawing.Point(27, 201);
            this.dgvDisciplinaSelecionar.MultiSelect = false;
            this.dgvDisciplinaSelecionar.Name = "dgvDisciplinaSelecionar";
            this.dgvDisciplinaSelecionar.ReadOnly = true;
            this.dgvDisciplinaSelecionar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisciplinaSelecionar.Size = new System.Drawing.Size(590, 238);
            this.dgvDisciplinaSelecionar.TabIndex = 4;
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "IdDisciplina";
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colCurso
            // 
            this.colCurso.DataPropertyName = "NomeDisciplina";
            this.colCurso.HeaderText = "Disciplina";
            this.colCurso.Name = "colCurso";
            this.colCurso.ReadOnly = true;
            this.colCurso.Width = 447;
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
            this.panel1.TabIndex = 3;
            // 
            // dgvDisciplinaCurso
            // 
            this.dgvDisciplinaCurso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDisciplinaCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplinaCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvDisciplinaCurso.Location = new System.Drawing.Point(27, 201);
            this.dgvDisciplinaCurso.MultiSelect = false;
            this.dgvDisciplinaCurso.Name = "dgvDisciplinaCurso";
            this.dgvDisciplinaCurso.ReadOnly = true;
            this.dgvDisciplinaCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisciplinaCurso.Size = new System.Drawing.Size(590, 238);
            this.dgvDisciplinaCurso.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomeCurso";
            this.dataGridViewTextBoxColumn1.HeaderText = "Curso";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 274;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeDisciplina";
            this.dataGridViewTextBoxColumn2.HeaderText = "Disciplina";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 273;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackColor = System.Drawing.Color.White;
            this.buttonPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("buttonPesquisar.Image")));
            this.buttonPesquisar.Location = new System.Drawing.Point(503, 26);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(52, 23);
            this.buttonPesquisar.TabIndex = 2;
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(477, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 53);
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
            // FrmDisciplinaSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 459);
            this.Controls.Add(this.dgvDisciplinaCurso);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvDisciplinaSelecionar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmDisciplinaSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDisciplinaSelecionar";
            this.Load += new System.EventHandler(this.FrmDisciplinaSelecionar_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinaSelecionar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinaCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.TextBox textBoxDisciplina;
        private System.Windows.Forms.DataGridView dgvDisciplinaSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.ComboBox comboBoxCurso;
        private System.Windows.Forms.DataGridView dgvDisciplinaCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox comboBoxSelecao;
    }
}