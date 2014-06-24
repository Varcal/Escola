namespace Apresentacao
{
    partial class FrmProfessorCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfessorCadastro));
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.comboBoxProfessor = new System.Windows.Forms.ComboBox();
            this.textBoxProfessor = new System.Windows.Forms.TextBox();
            this.textBoxRegistro = new System.Windows.Forms.TextBox();
            this.labelProfessor = new System.Windows.Forms.Label();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(482, 227);
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
            this.buttonConfirmar.Location = new System.Drawing.Point(394, 227);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmar.TabIndex = 1;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBoxDisciplina);
            this.panel2.Controls.Add(this.comboBoxProfessor);
            this.panel2.Controls.Add(this.textBoxProfessor);
            this.panel2.Controls.Add(this.textBoxRegistro);
            this.panel2.Controls.Add(this.labelProfessor);
            this.panel2.Controls.Add(this.labelRegistro);
            this.panel2.Location = new System.Drawing.Point(23, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 115);
            this.panel2.TabIndex = 0;
            // 
            // comboBoxDisciplina
            // 
            this.comboBoxDisciplina.FormattingEnabled = true;
            this.comboBoxDisciplina.Location = new System.Drawing.Point(81, 64);
            this.comboBoxDisciplina.Name = "comboBoxDisciplina";
            this.comboBoxDisciplina.Size = new System.Drawing.Size(330, 21);
            this.comboBoxDisciplina.TabIndex = 6;
            // 
            // comboBoxProfessor
            // 
            this.comboBoxProfessor.FormattingEnabled = true;
            this.comboBoxProfessor.Location = new System.Drawing.Point(81, 26);
            this.comboBoxProfessor.Name = "comboBoxProfessor";
            this.comboBoxProfessor.Size = new System.Drawing.Size(330, 21);
            this.comboBoxProfessor.TabIndex = 5;
            // 
            // textBoxProfessor
            // 
            this.textBoxProfessor.BackColor = System.Drawing.Color.White;
            this.textBoxProfessor.Location = new System.Drawing.Point(83, 65);
            this.textBoxProfessor.Name = "textBoxProfessor";
            this.textBoxProfessor.Size = new System.Drawing.Size(328, 20);
            this.textBoxProfessor.TabIndex = 4;
            // 
            // textBoxRegistro
            // 
            this.textBoxRegistro.BackColor = System.Drawing.Color.White;
            this.textBoxRegistro.Location = new System.Drawing.Point(83, 26);
            this.textBoxRegistro.Name = "textBoxRegistro";
            this.textBoxRegistro.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistro.TabIndex = 1;
            this.textBoxRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelProfessor
            // 
            this.labelProfessor.AutoSize = true;
            this.labelProfessor.ForeColor = System.Drawing.Color.Black;
            this.labelProfessor.Location = new System.Drawing.Point(26, 68);
            this.labelProfessor.Name = "labelProfessor";
            this.labelProfessor.Size = new System.Drawing.Size(54, 13);
            this.labelProfessor.TabIndex = 3;
            this.labelProfessor.Text = "Professor:";
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.ForeColor = System.Drawing.Color.Black;
            this.labelRegistro.Location = new System.Drawing.Point(25, 30);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(49, 13);
            this.labelRegistro.TabIndex = 0;
            this.labelRegistro.Text = "Registro:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonSair);
            this.panel1.Controls.Add(this.buttonSalvar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 76);
            this.panel1.TabIndex = 4;
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
            // FrmProfessorCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 258);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProfessorCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Professores";
            this.Load += new System.EventHandler(this.FrmProfessorCadastro_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxProfessor;
        private System.Windows.Forms.TextBox textBoxRegistro;
        private System.Windows.Forms.Label labelProfessor;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.ComboBox comboBoxDisciplina;
        private System.Windows.Forms.ComboBox comboBoxProfessor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}