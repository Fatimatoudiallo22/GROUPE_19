namespace GestionSysthemeEtudiant
{
    partial class FormProfesseur
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnlisteEtuPROF = new System.Windows.Forms.Button();
            this.btnnotePROF = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 599);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnlisteEtuPROF);
            this.panel2.Controls.Add(this.btnnotePROF);
            this.panel2.Location = new System.Drawing.Point(3, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 292);
            this.panel2.TabIndex = 0;
            // 
            // btnlisteEtuPROF
            // 
            this.btnlisteEtuPROF.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnlisteEtuPROF.Location = new System.Drawing.Point(0, 46);
            this.btnlisteEtuPROF.Name = "btnlisteEtuPROF";
            this.btnlisteEtuPROF.Size = new System.Drawing.Size(194, 51);
            this.btnlisteEtuPROF.TabIndex = 1;
            this.btnlisteEtuPROF.Text = "Liste des Etudiant";
            this.btnlisteEtuPROF.UseVisualStyleBackColor = true;
            this.btnlisteEtuPROF.Click += new System.EventHandler(this.btnlisteEtuPROF_Click);
            // 
            // btnnotePROF
            // 
            this.btnnotePROF.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnnotePROF.Location = new System.Drawing.Point(0, 0);
            this.btnnotePROF.Name = "btnnotePROF";
            this.btnnotePROF.Size = new System.Drawing.Size(194, 46);
            this.btnnotePROF.TabIndex = 0;
            this.btnnotePROF.Text = "Notes";
            this.btnnotePROF.UseVisualStyleBackColor = true;
            this.btnnotePROF.Click += new System.EventHandler(this.btnnotePROF_Click);
            // 
            // FormProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 599);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FormProfesseur";
            this.Text = "FormProfesseur";
            this.Load += new System.EventHandler(this.FormProfesseur_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnlisteEtuPROF;
        private System.Windows.Forms.Button btnnotePROF;
    }
}