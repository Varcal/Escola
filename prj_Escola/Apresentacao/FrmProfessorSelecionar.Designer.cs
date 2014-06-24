namespace Apresentacao
{
    partial class FrmProfessorSelecionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfessorSelecionar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.dgvProfessorDisciplina = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxRegistro = new System.Windows.Forms.TextBox();
            this.comboBoxSelecao = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxProfessor = new System.Windows.Forms.ComboBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.dgvProfessor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessorDisciplina)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonSair);
            this.panel1.Controls.Add(this.buttonConsultar);
            this.panel1.Controls.Add(this.buttonAlterar);
            this.panel1.Controls.Add(this.buttonExcluir);
            this.panel1.Controls.Add(this.buttonNovo);
            this.panel1.Location = new System.Drawing.Point(29, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 70);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.White;
            this.buttonSair.Image = ((System.Drawing.Image)(resources.GetObject("buttonSair.Image")));
            this.buttonSair.Location = new System.Drawing.Point(304, 10);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(55, 47);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackColor = System.Drawing.Color.White;
            this.buttonConsultar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConsultar.Image")));
            this.buttonConsultar.Location = new System.Drawing.Point(233, 10);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(55, 47);
            this.buttonConsultar.TabIndex = 3;
            this.buttonConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.Color.White;
            this.buttonAlterar.Image = global::Apresentacao.Properties.Resources.page_edit;
            this.buttonAlterar.Location = new System.Drawing.Point(162, 10);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(55, 47);
            this.buttonAlterar.TabIndex = 2;
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.White;
            this.buttonExcluir.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluir.Image")));
            this.buttonExcluir.Location = new System.Drawing.Point(91, 10);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(55, 47);
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
            this.buttonNovo.Size = new System.Drawing.Size(55, 47);
            this.buttonNovo.TabIndex = 0;
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // dgvProfessorDisciplina
            // 
            this.dgvProfessorDisciplina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProfessorDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessorDisciplina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvProfessorDisciplina.Location = new System.Drawing.Point(29, 203);
            this.dgvProfessorDisciplina.MultiSelect = false;
            this.dgvProfessorDisciplina.Name = "dgvProfessorDisciplina";
            this.dgvProfessorDisciplina.ReadOnly = true;
            this.dgvProfessorDisciplina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfessorDisciplina.Size = new System.Drawing.Size(590, 238);
            this.dgvProfessorDisciplina.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomeProfessor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Professor";
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
            // textBoxRegistro
            // 
            this.textBoxRegistro.Location = new System.Drawing.Point(165, 28);
            this.textBoxRegistro.Name = "textBoxRegistro";
            this.textBoxRegistro.Size = new System.Drawing.Size(308, 20);
            this.textBoxRegistro.TabIndex = 1;
            // 
            // comboBoxSelecao
            // 
            this.comboBoxSelecao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelecao.FormattingEnabled = true;
            this.comboBoxSelecao.Items.AddRange(new object[] {
            "Escolha uma Opção",
            "Registro",
            "Nome",
            "Professor"});
            this.comboBoxSelecao.Location = new System.Drawing.Point(20, 28);
            this.comboBoxSelecao.Name = "comboBoxSelecao";
            this.comboBoxSelecao.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelecao.TabIndex = 3;
            this.comboBoxSelecao.TextChanged += new System.EventHandler(this.comboBoxSelecao_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBoxProfessor);
            this.panel2.Controls.Add(this.comboBoxSelecao);
            this.panel2.Controls.Add(this.buttonPesquisar);
            this.panel2.Controls.Add(this.textBoxRegistro);
            this.panel2.Location = new System.Drawing.Point(29, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 79);
            this.panel2.TabIndex = 7;
            // 
            // comboBoxProfessor
            // 
            this.comboBoxProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfessor.FormattingEnabled = true;
            this.comboBoxProfessor.Location = new System.Drawing.Point(165, 28);
            this.comboBoxProfessor.Name = "comboBoxProfessor";
            this.comboBoxProfessor.Size = new System.Drawing.Size(308, 21);
            this.comboBoxProfessor.TabIndex = 4;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackColor = System.Drawing.Color.White;
            this.buttonPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("buttonPesquisar.Image")));
            this.buttonPesquisar.Location = new System.Drawing.Point(479, 27);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(52, 23);
            this.buttonPesquisar.TabIndex = 2;
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // dgvProfessor
            // 
            this.dgvProfessor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.dgvProfessor.Location = new System.Drawing.Point(29, 203);
            this.dgvProfessor.MultiSelect = false;
            this.dgvProfessor.Name = "dgvProfessor";
            this.dgvProfessor.ReadOnly = true;
            this.dgvProfessor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfessor.Size = new System.Drawing.Size(590, 238);
            this.dgvProfessor.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdProfessor";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Registro";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomeProfessor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Professor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 457;
            // 
            // FrmProfessorSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(648, 463);
            this.Controls.Add(this.dgvProfessor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProfessorDisciplina);
            this.Controls.Add(this.panel2);
            this.Name = "FrmProfessorSelecionar";
            this.Text = "Consulta Professores";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessorDisciplina)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.DataGridView dgvProfessorDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox textBoxRegistro;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.ComboBox comboBoxSelecao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox comboBoxProfessor;

    }
}