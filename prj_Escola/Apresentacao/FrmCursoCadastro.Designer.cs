namespace Apresentacao
{
    partial class FrmCursoCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursoCadastro));
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.comboBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.textBoxCurso = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCurso = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBoxCurso);
            this.panel2.Controls.Add(this.comboBoxDisciplina);
            this.panel2.Controls.Add(this.textBoxCurso);
            this.panel2.Controls.Add(this.textBoxCodigo);
            this.panel2.Controls.Add(this.labelCurso);
            this.panel2.Controls.Add(this.labelCodigo);
            this.panel2.Location = new System.Drawing.Point(23, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 115);
            this.panel2.TabIndex = 1;
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.BackColor = System.Drawing.Color.White;
            this.comboBoxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Location = new System.Drawing.Point(88, 24);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(330, 21);
            this.comboBoxCurso.TabIndex = 7;
            // 
            // comboBoxDisciplina
            // 
            this.comboBoxDisciplina.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisciplina.FormattingEnabled = true;
            this.comboBoxDisciplina.Location = new System.Drawing.Point(88, 59);
            this.comboBoxDisciplina.Name = "comboBoxDisciplina";
            this.comboBoxDisciplina.Size = new System.Drawing.Size(330, 21);
            this.comboBoxDisciplina.TabIndex = 8;
            // 
            // textBoxCurso
            // 
            this.textBoxCurso.BackColor = System.Drawing.Color.White;
            this.textBoxCurso.Location = new System.Drawing.Point(88, 59);
            this.textBoxCurso.Name = "textBoxCurso";
            this.textBoxCurso.Size = new System.Drawing.Size(330, 20);
            this.textBoxCurso.TabIndex = 3;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.BackColor = System.Drawing.Color.White;
            this.textBoxCodigo.Location = new System.Drawing.Point(88, 25);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 2;
            this.textBoxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.ForeColor = System.Drawing.Color.Black;
            this.labelCurso.Location = new System.Drawing.Point(31, 63);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(37, 13);
            this.labelCurso.TabIndex = 1;
            this.labelCurso.Text = "Curso:";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.ForeColor = System.Drawing.Color.Black;
            this.labelCodigo.Location = new System.Drawing.Point(31, 28);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Código:";
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.White;
            this.buttonConfirmar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonConfirmar.Location = new System.Drawing.Point(408, 220);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmar.TabIndex = 2;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(489, 220);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonSair);
            this.panel1.Controls.Add(this.buttonSalvar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(23, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 76);
            this.panel1.TabIndex = 5;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.White;
            this.buttonSair.Image = ((System.Drawing.Image)(resources.GetObject("buttonSair.Image")));
            this.buttonSair.Location = new System.Drawing.Point(70, 13);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(50, 45);
            this.buttonSair.TabIndex = 1;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.White;
            this.buttonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.Image")));
            this.buttonSalvar.Location = new System.Drawing.Point(14, 13);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(50, 45);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Apresentacao.Properties.Resources.CentroPaulaSouza;
            this.pictureBox1.Location = new System.Drawing.Point(157, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCursoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 254);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCursoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cursos";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.FrmCursoCadastro_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxCurso;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.ComboBox comboBoxCurso;
        private System.Windows.Forms.ComboBox comboBoxDisciplina;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}