namespace Apresentacao
{
    partial class FrmCursoSelecionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursoSelecionar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.dgvCursoSelecionar = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.textBoxCurso = new System.Windows.Forms.TextBox();
            this.labelCurso = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursoSelecionar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonSair);
            this.panel1.Controls.Add(this.buttonConsultar);
            this.panel1.Controls.Add(this.buttonAlterar);
            this.panel1.Controls.Add(this.buttonExcluir);
            this.panel1.Controls.Add(this.buttonNovo);
            this.panel1.Location = new System.Drawing.Point(26, 16);
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
            // dgvCursoSelecionar
            // 
            this.dgvCursoSelecionar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCursoSelecionar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursoSelecionar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colCurso});
            this.dgvCursoSelecionar.Location = new System.Drawing.Point(26, 200);
            this.dgvCursoSelecionar.MultiSelect = false;
            this.dgvCursoSelecionar.Name = "dgvCursoSelecionar";
            this.dgvCursoSelecionar.ReadOnly = true;
            this.dgvCursoSelecionar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursoSelecionar.Size = new System.Drawing.Size(590, 238);
            this.dgvCursoSelecionar.TabIndex = 1;
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "IdCurso";
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colCurso
            // 
            this.colCurso.DataPropertyName = "NomeCurso";
            this.colCurso.HeaderText = "Curso";
            this.colCurso.Name = "colCurso";
            this.colCurso.ReadOnly = true;
            this.colCurso.Width = 447;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.buttonPesquisar);
            this.panel2.Controls.Add(this.textBoxCurso);
            this.panel2.Controls.Add(this.labelCurso);
            this.panel2.Location = new System.Drawing.Point(26, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 74);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(474, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackColor = System.Drawing.Color.White;
            this.buttonPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("buttonPesquisar.Image")));
            this.buttonPesquisar.Location = new System.Drawing.Point(393, 26);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(52, 23);
            this.buttonPesquisar.TabIndex = 2;
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // textBoxCurso
            // 
            this.textBoxCurso.Location = new System.Drawing.Point(72, 27);
            this.textBoxCurso.Name = "textBoxCurso";
            this.textBoxCurso.Size = new System.Drawing.Size(315, 20);
            this.textBoxCurso.TabIndex = 1;
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Location = new System.Drawing.Point(20, 30);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(37, 13);
            this.labelCurso.TabIndex = 0;
            this.labelCurso.Text = "Curso:";
            // 
            // FrmCursoSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvCursoSelecionar);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCursoSelecionar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cursos";
            this.Load += new System.EventHandler(this.FrmCursoSelecionar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursoSelecionar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCursoSelecionar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.TextBox textBoxCurso;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurso;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}