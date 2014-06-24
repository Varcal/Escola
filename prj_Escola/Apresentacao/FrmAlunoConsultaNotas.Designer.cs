namespace Apresentacao
{
    partial class FrmAlunoConsultaNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlunoConsultaNotas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_AlunoNotas = new System.Windows.Forms.DataGridView();
            this.colRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrabalho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxCurso = new System.Windows.Forms.TextBox();
            this.labelCurso = new System.Windows.Forms.Label();
            this.textBoxAluno = new System.Windows.Forms.TextBox();
            this.labelAluno = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AlunoNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonSair);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 87);
            this.panel1.TabIndex = 5;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.White;
            this.buttonSair.Image = ((System.Drawing.Image)(resources.GetObject("buttonSair.Image")));
            this.buttonSair.Location = new System.Drawing.Point(24, 9);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(68, 67);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Apresentacao.Properties.Resources.CentroPaulaSouza;
            this.pictureBox1.Location = new System.Drawing.Point(181, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_AlunoNotas
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_AlunoNotas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_AlunoNotas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_AlunoNotas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_AlunoNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AlunoNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRA,
            this.colNomeAluno,
            this.colP1,
            this.colTrabalho,
            this.colP2,
            this.colMedia,
            this.colSituacao});
            this.dgv_AlunoNotas.Location = new System.Drawing.Point(25, 159);
            this.dgv_AlunoNotas.MultiSelect = false;
            this.dgv_AlunoNotas.Name = "dgv_AlunoNotas";
            this.dgv_AlunoNotas.RowHeadersVisible = false;
            this.dgv_AlunoNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AlunoNotas.Size = new System.Drawing.Size(729, 279);
            this.dgv_AlunoNotas.TabIndex = 6;
            // 
            // colRA
            // 
            this.colRA.DataPropertyName = "IdAluno";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colRA.DefaultCellStyle = dataGridViewCellStyle9;
            this.colRA.HeaderText = "RA";
            this.colRA.Name = "colRA";
            this.colRA.ReadOnly = true;
            this.colRA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colNomeAluno
            // 
            this.colNomeAluno.DataPropertyName = "NomeDisciplina";
            this.colNomeAluno.HeaderText = "Disciplina";
            this.colNomeAluno.Name = "colNomeAluno";
            this.colNomeAluno.ReadOnly = true;
            this.colNomeAluno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNomeAluno.Width = 305;
            // 
            // colP1
            // 
            this.colP1.DataPropertyName = "P1";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "##.##";
            this.colP1.DefaultCellStyle = dataGridViewCellStyle10;
            this.colP1.HeaderText = "P1";
            this.colP1.Name = "colP1";
            this.colP1.ReadOnly = true;
            this.colP1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colP1.Width = 55;
            // 
            // colTrabalho
            // 
            this.colTrabalho.DataPropertyName = "Trabalho";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "##.##";
            this.colTrabalho.DefaultCellStyle = dataGridViewCellStyle11;
            this.colTrabalho.HeaderText = "Trabalho";
            this.colTrabalho.Name = "colTrabalho";
            this.colTrabalho.ReadOnly = true;
            this.colTrabalho.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTrabalho.Width = 55;
            // 
            // colP2
            // 
            this.colP2.DataPropertyName = "P2";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Format = "##.##";
            this.colP2.DefaultCellStyle = dataGridViewCellStyle12;
            this.colP2.HeaderText = "P2";
            this.colP2.Name = "colP2";
            this.colP2.ReadOnly = true;
            this.colP2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colP2.Width = 55;
            // 
            // colMedia
            // 
            this.colMedia.DataPropertyName = "Media";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "##.##";
            this.colMedia.DefaultCellStyle = dataGridViewCellStyle13;
            this.colMedia.HeaderText = "Média";
            this.colMedia.Name = "colMedia";
            this.colMedia.ReadOnly = true;
            this.colMedia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMedia.Width = 55;
            // 
            // colSituacao
            // 
            this.colSituacao.DataPropertyName = "Situacao";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colSituacao.DefaultCellStyle = dataGridViewCellStyle14;
            this.colSituacao.HeaderText = "Situacao";
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.ReadOnly = true;
            // 
            // textBoxCurso
            // 
            this.textBoxCurso.BackColor = System.Drawing.Color.White;
            this.textBoxCurso.Location = new System.Drawing.Point(447, 118);
            this.textBoxCurso.Name = "textBoxCurso";
            this.textBoxCurso.ReadOnly = true;
            this.textBoxCurso.Size = new System.Drawing.Size(307, 20);
            this.textBoxCurso.TabIndex = 13;
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurso.Location = new System.Drawing.Point(387, 122);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(54, 13);
            this.labelCurso.TabIndex = 12;
            this.labelCurso.Text = "CURSO:";
            // 
            // textBoxAluno
            // 
            this.textBoxAluno.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxAluno.Location = new System.Drawing.Point(87, 118);
            this.textBoxAluno.Name = "textBoxAluno";
            this.textBoxAluno.ReadOnly = true;
            this.textBoxAluno.Size = new System.Drawing.Size(268, 20);
            this.textBoxAluno.TabIndex = 11;
            // 
            // labelAluno
            // 
            this.labelAluno.AutoSize = true;
            this.labelAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAluno.Location = new System.Drawing.Point(27, 122);
            this.labelAluno.Name = "labelAluno";
            this.labelAluno.Size = new System.Drawing.Size(53, 13);
            this.labelAluno.TabIndex = 10;
            this.labelAluno.Text = "ALUNO:";
            // 
            // FrmAlunoConsultaNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.textBoxCurso);
            this.Controls.Add(this.labelCurso);
            this.Controls.Add(this.textBoxAluno);
            this.Controls.Add(this.labelAluno);
            this.Controls.Add(this.dgv_AlunoNotas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmAlunoConsultaNotas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlunoConsultaNotas";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AlunoNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.DataGridView dgv_AlunoNotas;
        private System.Windows.Forms.TextBox textBoxCurso;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.TextBox textBoxAluno;
        private System.Windows.Forms.Label labelAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrabalho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colP2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacao;
    }
}