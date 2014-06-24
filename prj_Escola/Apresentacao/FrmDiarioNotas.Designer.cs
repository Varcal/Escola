namespace Apresentacao
{
    partial class FrmDiarioNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiarioNotas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_DiarioNotas = new System.Windows.Forms.DataGridView();
            this.IdAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrabalho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDisciplina = new System.Windows.Forms.Label();
            this.textBoxDisciplina = new System.Windows.Forms.TextBox();
            this.labelProfessor = new System.Windows.Forms.Label();
            this.textBoxProfessor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DiarioNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonInserir);
            this.panel1.Controls.Add(this.buttonSair);
            this.panel1.Controls.Add(this.buttonSalvar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 87);
            this.panel1.TabIndex = 4;
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.Color.White;
            this.buttonInserir.Image = global::Apresentacao.Properties.Resources.Add_1_;
            this.buttonInserir.Location = new System.Drawing.Point(15, 10);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(66, 67);
            this.buttonInserir.TabIndex = 5;
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.White;
            this.buttonSair.Image = ((System.Drawing.Image)(resources.GetObject("buttonSair.Image")));
            this.buttonSair.Location = new System.Drawing.Point(179, 10);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(66, 67);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.White;
            this.buttonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.Image")));
            this.buttonSalvar.Location = new System.Drawing.Point(97, 10);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(66, 67);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Apresentacao.Properties.Resources.CentroPaulaSouza;
            this.pictureBox1.Location = new System.Drawing.Point(294, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgv_DiarioNotas);
            this.panel2.Location = new System.Drawing.Point(27, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 406);
            this.panel2.TabIndex = 5;
            // 
            // dgv_DiarioNotas
            // 
            this.dgv_DiarioNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DiarioNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAluno,
            this.colRA,
            this.colNomeAluno,
            this.colP1,
            this.colTrabalho,
            this.colP2,
            this.colMedia});
            this.dgv_DiarioNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DiarioNotas.Location = new System.Drawing.Point(0, 0);
            this.dgv_DiarioNotas.MultiSelect = false;
            this.dgv_DiarioNotas.Name = "dgv_DiarioNotas";
            this.dgv_DiarioNotas.RowHeadersVisible = false;
            this.dgv_DiarioNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DiarioNotas.Size = new System.Drawing.Size(728, 402);
            this.dgv_DiarioNotas.TabIndex = 0;
            // 
            // IdAluno
            // 
            this.IdAluno.DataPropertyName = "IdCurso";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdAluno.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdAluno.HeaderText = "Numero";
            this.IdAluno.Name = "IdAluno";
            this.IdAluno.ReadOnly = true;
            this.IdAluno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdAluno.Width = 55;
            // 
            // colRA
            // 
            this.colRA.DataPropertyName = "IdAluno";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colRA.DefaultCellStyle = dataGridViewCellStyle2;
            this.colRA.HeaderText = "RA";
            this.colRA.Name = "colRA";
            this.colRA.ReadOnly = true;
            this.colRA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colNomeAluno
            // 
            this.colNomeAluno.DataPropertyName = "NomeAluno";
            this.colNomeAluno.HeaderText = "Nome";
            this.colNomeAluno.Name = "colNomeAluno";
            this.colNomeAluno.ReadOnly = true;
            this.colNomeAluno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNomeAluno.Width = 350;
            // 
            // colP1
            // 
            this.colP1.DataPropertyName = "P1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "##.##";
            this.colP1.DefaultCellStyle = dataGridViewCellStyle3;
            this.colP1.HeaderText = "P1";
            this.colP1.Name = "colP1";
            this.colP1.ReadOnly = true;
            this.colP1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colP1.Width = 55;
            // 
            // colTrabalho
            // 
            this.colTrabalho.DataPropertyName = "Trabalho";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "##.##";
            this.colTrabalho.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTrabalho.HeaderText = "Trabalho";
            this.colTrabalho.Name = "colTrabalho";
            this.colTrabalho.ReadOnly = true;
            this.colTrabalho.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTrabalho.Width = 55;
            // 
            // colP2
            // 
            this.colP2.DataPropertyName = "P2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "##.##";
            this.colP2.DefaultCellStyle = dataGridViewCellStyle5;
            this.colP2.HeaderText = "P2";
            this.colP2.Name = "colP2";
            this.colP2.ReadOnly = true;
            this.colP2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colP2.Width = 55;
            // 
            // colMedia
            // 
            this.colMedia.DataPropertyName = "Media";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "##.##";
            this.colMedia.DefaultCellStyle = dataGridViewCellStyle6;
            this.colMedia.HeaderText = "Média";
            this.colMedia.Name = "colMedia";
            this.colMedia.ReadOnly = true;
            this.colMedia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMedia.Width = 55;
            // 
            // labelDisciplina
            // 
            this.labelDisciplina.AutoSize = true;
            this.labelDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisciplina.Location = new System.Drawing.Point(30, 109);
            this.labelDisciplina.Name = "labelDisciplina";
            this.labelDisciplina.Size = new System.Drawing.Size(80, 13);
            this.labelDisciplina.TabIndex = 6;
            this.labelDisciplina.Text = "DISCIPLINA:";
            // 
            // textBoxDisciplina
            // 
            this.textBoxDisciplina.Location = new System.Drawing.Point(116, 105);
            this.textBoxDisciplina.Name = "textBoxDisciplina";
            this.textBoxDisciplina.ReadOnly = true;
            this.textBoxDisciplina.Size = new System.Drawing.Size(252, 20);
            this.textBoxDisciplina.TabIndex = 7;
            // 
            // labelProfessor
            // 
            this.labelProfessor.AutoSize = true;
            this.labelProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfessor.Location = new System.Drawing.Point(390, 109);
            this.labelProfessor.Name = "labelProfessor";
            this.labelProfessor.Size = new System.Drawing.Size(86, 13);
            this.labelProfessor.TabIndex = 8;
            this.labelProfessor.Text = "PROFESSOR:";
            // 
            // textBoxProfessor
            // 
            this.textBoxProfessor.Location = new System.Drawing.Point(492, 105);
            this.textBoxProfessor.Name = "textBoxProfessor";
            this.textBoxProfessor.ReadOnly = true;
            this.textBoxProfessor.Size = new System.Drawing.Size(265, 20);
            this.textBoxProfessor.TabIndex = 9;
            // 
            // FrmDiarioNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.textBoxProfessor);
            this.Controls.Add(this.labelProfessor);
            this.Controls.Add(this.textBoxDisciplina);
            this.Controls.Add(this.labelDisciplina);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDiarioNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIÁRIO DE NOTAS";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DiarioNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_DiarioNotas;
        private System.Windows.Forms.Label labelDisciplina;
        private System.Windows.Forms.TextBox textBoxDisciplina;
        private System.Windows.Forms.Label labelProfessor;
        private System.Windows.Forms.TextBox textBoxProfessor;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrabalho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colP2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedia;
    }
}