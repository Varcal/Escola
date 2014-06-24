namespace Apresentacao
{
    partial class FrmSelecionaProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionaProfessor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSelecionaProfessor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvSelecionaProfessor = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSelecionaProfessor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelecionaProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSelecionaProfessor
            // 
            this.panelSelecionaProfessor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSelecionaProfessor.Controls.Add(this.panel1);
            this.panelSelecionaProfessor.Controls.Add(this.dgvSelecionaProfessor);
            this.panelSelecionaProfessor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelecionaProfessor.Location = new System.Drawing.Point(0, 0);
            this.panelSelecionaProfessor.Name = "panelSelecionaProfessor";
            this.panelSelecionaProfessor.Size = new System.Drawing.Size(566, 424);
            this.panelSelecionaProfessor.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonSair);
            this.panel1.Controls.Add(this.buttonSalvar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 76);
            this.panel1.TabIndex = 1;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.White;
            this.buttonSair.Image = ((System.Drawing.Image)(resources.GetObject("buttonSair.Image")));
            this.buttonSair.Location = new System.Drawing.Point(75, 13);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(50, 45);
            this.buttonSair.TabIndex = 2;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.White;
            this.buttonSalvar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.Image")));
            this.buttonSalvar.Location = new System.Drawing.Point(19, 13);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(50, 45);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.UseVisualStyleBackColor = false;
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
            // dgvSelecionaProfessor
            // 
            this.dgvSelecionaProfessor.BackgroundColor = System.Drawing.Color.White;
            this.dgvSelecionaProfessor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSelecionaProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelecionaProfessor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnProfessor});
            this.dgvSelecionaProfessor.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvSelecionaProfessor.Location = new System.Drawing.Point(10, 100);
            this.dgvSelecionaProfessor.MultiSelect = false;
            this.dgvSelecionaProfessor.Name = "dgvSelecionaProfessor";
            this.dgvSelecionaProfessor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSelecionaProfessor.RowHeadersVisible = false;
            this.dgvSelecionaProfessor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelecionaProfessor.Size = new System.Drawing.Size(542, 308);
            this.dgvSelecionaProfessor.TabIndex = 0;
            this.dgvSelecionaProfessor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelecionaProfessor_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "IdProfessor";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnId.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnId.HeaderText = "Registro";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnId.Width = 91;
            // 
            // ColumnProfessor
            // 
            this.ColumnProfessor.DataPropertyName = "NomeProfessor";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.ColumnProfessor.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnProfessor.HeaderText = "Professor";
            this.ColumnProfessor.Name = "ColumnProfessor";
            this.ColumnProfessor.ReadOnly = true;
            this.ColumnProfessor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnProfessor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnProfessor.Width = 448;
            // 
            // FrmSelecionaProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 424);
            this.ControlBox = false;
            this.Controls.Add(this.panelSelecionaProfessor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelecionaProfessor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleciona Professor";
            this.panelSelecionaProfessor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelecionaProfessor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSelecionaProfessor;
        private System.Windows.Forms.DataGridView dgvSelecionaProfessor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProfessor;
    }
}