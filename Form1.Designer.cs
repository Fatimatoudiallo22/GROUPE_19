namespace GestionSysthemeEtudiant
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPrincipale = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListeEtudiant = new System.Windows.Forms.Button();
            this.btnRapport = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnProf = new System.Windows.Forms.Button();
            this.btnCoursMat = new System.Windows.Forms.Button();
            this.btnClasse = new System.Windows.Forms.Button();
            this.btnEtudiant = new System.Windows.Forms.Button();
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.btnCours = new System.Windows.Forms.Button();
            this.btnMatiere = new System.Windows.Forms.Button();
            this.panelPrincipale.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipale
            // 
            this.panelPrincipale.AutoScrollMargin = new System.Drawing.Size(0, 5);
            this.panelPrincipale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.panelPrincipale.Controls.Add(this.panelMenu);
            this.panelPrincipale.Controls.Add(this.panel1);
            this.panelPrincipale.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPrincipale.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipale.Margin = new System.Windows.Forms.Padding(4);
            this.panelPrincipale.Name = "panelPrincipale";
            this.panelPrincipale.Padding = new System.Windows.Forms.Padding(4);
            this.panelPrincipale.Size = new System.Drawing.Size(211, 580);
            this.panelPrincipale.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(155)))), ((int)(((byte)(126)))));
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(203, 69);
            this.panelMenu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "OUTILS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.btnMatiere);
            this.panel1.Controls.Add(this.btnCours);
            this.panel1.Controls.Add(this.btnListeEtudiant);
            this.panel1.Controls.Add(this.btnRapport);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnNotes);
            this.panel1.Controls.Add(this.btnProf);
            this.panel1.Controls.Add(this.btnCoursMat);
            this.panel1.Controls.Add(this.btnClasse);
            this.panel1.Controls.Add(this.btnEtudiant);
            this.panel1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 474);
            this.panel1.TabIndex = 0;
            // 
            // btnListeEtudiant
            // 
            this.btnListeEtudiant.AutoSize = true;
            this.btnListeEtudiant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListeEtudiant.FlatAppearance.BorderSize = 0;
            this.btnListeEtudiant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListeEtudiant.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeEtudiant.Location = new System.Drawing.Point(0, 255);
            this.btnListeEtudiant.Name = "btnListeEtudiant";
            this.btnListeEtudiant.Size = new System.Drawing.Size(208, 52);
            this.btnListeEtudiant.TabIndex = 7;
            this.btnListeEtudiant.Text = "Liste des Etudiant\r\n\r\n";
            this.btnListeEtudiant.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnListeEtudiant.UseVisualStyleBackColor = true;
            this.btnListeEtudiant.Click += new System.EventHandler(this.btnListeEtudiant_Click);
            // 
            // btnRapport
            // 
            this.btnRapport.AutoSize = true;
            this.btnRapport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRapport.FlatAppearance.BorderSize = 0;
            this.btnRapport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapport.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapport.Location = new System.Drawing.Point(0, 219);
            this.btnRapport.Name = "btnRapport";
            this.btnRapport.Size = new System.Drawing.Size(208, 36);
            this.btnRapport.TabIndex = 6;
            this.btnRapport.Text = "Rapports";
            this.btnRapport.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnRapport.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.AutoSize = true;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(0, 180);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(208, 39);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = " Utilisateurs";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnNotes
            // 
            this.btnNotes.AutoSize = true;
            this.btnNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotes.FlatAppearance.BorderSize = 0;
            this.btnNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotes.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotes.Location = new System.Drawing.Point(0, 144);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(208, 36);
            this.btnNotes.TabIndex = 4;
            this.btnNotes.Text = "Notes";
            this.btnNotes.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click_1);
            // 
            // btnProf
            // 
            this.btnProf.AutoSize = true;
            this.btnProf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProf.FlatAppearance.BorderSize = 0;
            this.btnProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf.Location = new System.Drawing.Point(0, 108);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(208, 36);
            this.btnProf.TabIndex = 3;
            this.btnProf.Text = " Professeurs";
            this.btnProf.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnProf.UseVisualStyleBackColor = true;
            this.btnProf.Click += new System.EventHandler(this.btnProf_Click_1);
            // 
            // btnCoursMat
            // 
            this.btnCoursMat.AutoSize = true;
            this.btnCoursMat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCoursMat.FlatAppearance.BorderSize = 0;
            this.btnCoursMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoursMat.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoursMat.Location = new System.Drawing.Point(0, 72);
            this.btnCoursMat.Name = "btnCoursMat";
            this.btnCoursMat.Size = new System.Drawing.Size(208, 36);
            this.btnCoursMat.TabIndex = 2;
            this.btnCoursMat.Text = "Cours et Matières";
            this.btnCoursMat.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCoursMat.UseVisualStyleBackColor = true;
            // 
            // btnClasse
            // 
            this.btnClasse.AutoSize = true;
            this.btnClasse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClasse.FlatAppearance.BorderSize = 0;
            this.btnClasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClasse.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasse.Location = new System.Drawing.Point(0, 36);
            this.btnClasse.Name = "btnClasse";
            this.btnClasse.Size = new System.Drawing.Size(208, 36);
            this.btnClasse.TabIndex = 1;
            this.btnClasse.Text = "Classes";
            this.btnClasse.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClasse.UseVisualStyleBackColor = true;
            this.btnClasse.Click += new System.EventHandler(this.btnClasse_Click);
            // 
            // btnEtudiant
            // 
            this.btnEtudiant.AutoSize = true;
            this.btnEtudiant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEtudiant.FlatAppearance.BorderSize = 0;
            this.btnEtudiant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtudiant.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtudiant.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnEtudiant.Location = new System.Drawing.Point(0, 0);
            this.btnEtudiant.Name = "btnEtudiant";
            this.btnEtudiant.Size = new System.Drawing.Size(208, 36);
            this.btnEtudiant.TabIndex = 0;
            this.btnEtudiant.Text = " Étudiants";
            this.btnEtudiant.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEtudiant.UseVisualStyleBackColor = true;
            this.btnEtudiant.Click += new System.EventHandler(this.btnEtudiant_Click);
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavbar.Location = new System.Drawing.Point(211, 0);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(589, 73);
            this.panelNavbar.TabIndex = 2;
            // 
            // btnCours
            // 
            this.btnCours.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCours.FlatAppearance.BorderSize = 0;
            this.btnCours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCours.ForeColor = System.Drawing.Color.Black;
            this.btnCours.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCours.Location = new System.Drawing.Point(0, 307);
            this.btnCours.Name = "btnCours";
            this.btnCours.Size = new System.Drawing.Size(208, 23);
            this.btnCours.TabIndex = 8;
            this.btnCours.Text = "Les Cours";
            this.btnCours.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCours.UseVisualStyleBackColor = true;
            this.btnCours.Click += new System.EventHandler(this.btnCours_Click);
            // 
            // btnMatiere
            // 
            this.btnMatiere.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMatiere.FlatAppearance.BorderSize = 0;
            this.btnMatiere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatiere.ForeColor = System.Drawing.Color.Black;
            this.btnMatiere.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMatiere.Location = new System.Drawing.Point(0, 330);
            this.btnMatiere.Name = "btnMatiere";
            this.btnMatiere.Size = new System.Drawing.Size(208, 34);
            this.btnMatiere.TabIndex = 9;
            this.btnMatiere.Text = "Les Matieres";
            this.btnMatiere.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMatiere.UseVisualStyleBackColor = true;
            this.btnMatiere.Click += new System.EventHandler(this.btnMatiere_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.panelNavbar);
            this.Controls.Add(this.panelPrincipale);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelPrincipale.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProf;
        private System.Windows.Forms.Button btnCoursMat;
        private System.Windows.Forms.Button btnClasse;
        private System.Windows.Forms.Button btnEtudiant;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnListeEtudiant;
        private System.Windows.Forms.Button btnRapport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Button btnMatiere;
        private System.Windows.Forms.Button btnCours;
    }
}

