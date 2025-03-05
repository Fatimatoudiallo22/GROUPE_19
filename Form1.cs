using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestionSysthemeEtudiant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Méthode pour changer la couleur de fond des boutons en fonction du bouton sélectionné
        private void SetButtonBackgroundColor(string section)
        {
            // Réinitialiser la couleur de fond de tous les boutons
            ResetButtonBackgroundColors();

            // Appliquer la couleur de fond en fonction de la section sélectionnée
            if (section == "Gestion des Étudiants")
            {
                btnEtudiant.BackColor = Color.FromArgb(52, 211, 153);  // Mint
            }
            else if (section == "Gestion des Classes")
            {
                btnClasse.BackColor = Color.FromArgb(59, 130, 246);  // Bleu
            }
            else if (section == "Gestion des Cours et Matières")
            {
                btnCoursMat.BackColor = Color.FromArgb(251, 191, 36);  // Jaune doré
            }
            else if (section == "Gestion des Professeurs")
            {
                btnProf.BackColor = Color.FromArgb(244, 114, 182);  // Rose vif
            }
            else if (section == "Gestion des Notes")
            {
                btnNotes.BackColor = Color.FromArgb(99, 102, 241);  // Bleu violet
            }
            else if (section == "Gestion des Utilisateurs")
            {
                btnUser.BackColor = Color.FromArgb(239, 68, 68);  // Rouge
            }
            else if (section == "Rapports")
            {
                btnRapport.BackColor = Color.FromArgb(16, 185, 129);  // Vert clair
            }
            else if (section == "Paramètres / Configuration")
            {
                btnListeEtudiant.BackColor = Color.FromArgb(107, 114, 128);  // Gris foncé
            }
        }

        // Réinitialiser la couleur de fond de tous les boutons
        private void ResetButtonBackgroundColors()
        {
            // Remettre la couleur de fond par défaut (par exemple, gris clair) pour tous les boutons
            btnEtudiant.BackColor = Color.LightGray;
            btnClasse.BackColor = Color.LightGray;
            btnCoursMat.BackColor = Color.LightGray;
            btnProf.BackColor = Color.LightGray;
            btnNotes.BackColor = Color.LightGray;
            btnUser.BackColor = Color.LightGray;
            btnRapport.BackColor = Color.LightGray;
            btnListeEtudiant.BackColor = Color.LightGray;
        }

        // Événements de clic des boutons pour appliquer la couleur de fond
        private void btnEtudiants_Click(object sender, EventArgs e)
        {
            SetButtonBackgroundColor("Gestion des Étudiants");
          
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            SetButtonBackgroundColor("Gestion des Classes");
        }

        private void btnCoursMat_Click(object sender, EventArgs e)
        {
            SetButtonBackgroundColor("Gestion des Cours et Matières");
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            SetButtonBackgroundColor("Gestion des Professeurs");
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            SetButtonBackgroundColor("Gestion des Notes");
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            SetButtonBackgroundColor("Gestion des Utilisateurs");
        }

        private void btnRapports_Click(object sender, EventArgs e)
        {
            SetButtonBackgroundColor("Rapports");
        }

        private void btnConfiPara_Click(object sender, EventArgs e)
        {
            SetButtonBackgroundColor("Paramètres / Configuration");
        }

        // Événement de clic pour ouvrir le formulaire des étudiants

        private void btnEtudiant_Click(object sender, EventArgs e)
        {
            FormEtudiants formEtudiants = new FormEtudiants();

            // Définir le formulaire parent comme MdiParent
            formEtudiants.MdiParent = this;

            // Afficher le formulaire enfant
            formEtudiants.Show();
           
        }

        private void btnClasse_Click(object sender, EventArgs e)
        {
            FormClasses formClasses = new FormClasses();
            formClasses.MdiParent = this;
            formClasses.Show();
        }

        private void btnProf_Click_1(object sender, EventArgs e)
        {
            FormProf formProf = new FormProf();
            formProf.MdiParent = this;
            formProf.Show();
        }

        private void btnCours_Click(object sender, EventArgs e)
        {
            FormCours formCours = new FormCours();
            formCours.MdiParent = this;
            formCours.Show();
        }

        private void btnMatiere_Click(object sender, EventArgs e)
        {
            FormMatiere formMatiere = new FormMatiere();
            formMatiere.MdiParent = this;
            formMatiere.Show();
        }

        private void btnNotes_Click_1(object sender, EventArgs e)
        {
            FormNotes formNotes = new FormNotes();
            formNotes.MdiParent = this;
            formNotes.Show();
        }

        private void btnListeEtudiant_Click(object sender, EventArgs e)
        {
            FormListeEtudiant formListeEtudiant = new FormListeEtudiant();
            formListeEtudiant.MdiParent = this;
            formListeEtudiant.Show();
        }
    }
}
