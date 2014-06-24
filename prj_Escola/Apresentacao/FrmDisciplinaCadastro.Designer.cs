namespace Apresentacao
{
    partial class FrmDisciplinaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisciplinaCadastro));
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxDisciplina = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelDisciplina = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
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
            this.buttonCancelar.Location = new System.Drawing.Point(483, 220);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.White;
            this.buttonConfirmar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonConfirmar.Location = new System.Drawing.Point(397, 220);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmar.TabIndex = 6;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBoxDisciplina);
            this.panel2.Controls.Add(this.textBoxCodigo);
            this.panel2.Controls.Add(this.labelDisciplina);
            this.panel2.Controls.Add(this.labelCodigo);
            this.panel2.Location = new System.Drawing.Point(23, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 115);
            this.panel2.TabIndex = 5;
            // 
            // textBoxDisciplina
            // 
            this.textBoxDisciplina.BackColor = System.Drawing.Color.White;
            this.textBoxDisciplina.Location = new System.Drawing.Point(82, 65);
            this.textBoxDisciplina.Name = "textBoxDisciplina";
            this.textBoxDisciplina.Size = new System.Drawing.Size(313, 20);
            this.textBoxDisciplina.TabIndex = 3;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.BackColor = System.Drawing.Color.White;
            this.textBoxCodigo.Location = new System.Drawing.Point(82, 27);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(80, 20);
            this.textBoxCodigo.TabIndex = 2;
            this.textBoxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelDisciplina
            // 
            this.labelDisciplina.AutoSize = true;
            this.labelDisciplina.ForeColor = System.Drawing.Color.Black;
            this.labelDisciplina.Location = new System.Drawing.Point(25, 69);
            this.labelDisciplina.Name = "labelDisciplina";
            this.labelDisciplina.Size = new System.Drawing.Size(55, 13);
            this.labelDisciplina.TabIndex = 1;
            this.labelDisciplina.Text = "Disciplina:";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.ForeColor = System.Drawing.Color.Black;
            this.labelCodigo.Location = new System.Drawing.Point(25, 31);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Código:";
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
            this.panel1.TabIndex = 8;
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
            // FrmDisciplinaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 251);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDisciplinaCadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDisciplinaCadastro";
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
        private System.Windows.Forms.TextBox textBoxDisciplina;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelDisciplina;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}