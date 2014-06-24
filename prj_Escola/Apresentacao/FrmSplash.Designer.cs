namespace Apresentacao
{
    partial class FrmSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pictureFZL = new System.Windows.Forms.PictureBox();
            this.pictureBoxCP = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFZL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.pictureFZL);
            this.panel1.Controls.Add(this.pictureBoxCP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 344);
            this.panel1.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Red;
            this.progressBar.Location = new System.Drawing.Point(486, 300);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(120, 20);
            this.progressBar.TabIndex = 2;
            // 
            // pictureFZL
            // 
            this.pictureFZL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureFZL.Image = ((System.Drawing.Image)(resources.GetObject("pictureFZL.Image")));
            this.pictureFZL.Location = new System.Drawing.Point(12, 105);
            this.pictureFZL.Name = "pictureFZL";
            this.pictureFZL.Size = new System.Drawing.Size(612, 220);
            this.pictureFZL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFZL.TabIndex = 1;
            this.pictureFZL.TabStop = false;
            // 
            // pictureBoxCP
            // 
            this.pictureBoxCP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxCP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCP.Image")));
            this.pictureBoxCP.Location = new System.Drawing.Point(9, 16);
            this.pictureBoxCP.Name = "pictureBoxCP";
            this.pictureBoxCP.Size = new System.Drawing.Size(612, 70);
            this.pictureBoxCP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCP.TabIndex = 0;
            this.pictureBoxCP.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 344);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSplash";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFZL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox pictureFZL;
        private System.Windows.Forms.PictureBox pictureBoxCP;
        private System.Windows.Forms.Timer timer1;
    }
}