using System;
using System.Linq;
using System.Windows.Forms;

namespace GestionSysthemeEtudiant
{
    public partial class FormNotes : Form
    {
        public FormNotes()
        {
            InitializeComponent();
            ChargerEtudiants();
            ChargerMatieres();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Validation des champs
            if (cmbEtudiant.SelectedValue == null || cmbMatiere.SelectedValue == null || string.IsNullOrEmpty(txtNote.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            // Validation de la note (assurez-vous que la note soit entre 0 et 20)
            if (float.TryParse(txtNote.Text, out float note))
            {
                if (note < 0 || note > 20)
                {
                    MessageBox.Show("La note doit être comprise entre 0 et 20.");
                    return;
                }

                // Enregistrement de la note dans la base de données
                using (var context = new DBGestionEtudiantContext())
                {
                    // Créer une nouvelle instance de la note
                    Note nouvelleNote = new Note()
                    {
                        IdEtudiant = (int)cmbEtudiant.SelectedValue,
                        IdMatiere = (int)cmbMatiere.SelectedValue,
                        ValeurNote = note  // Utilisation de la propriété ValeurNote en float
                    };

                    // Ajouter la note à la base de données
                    context.Notes.Add(nouvelleNote);
                    context.SaveChanges();

                    MessageBox.Show("Note ajoutée avec succès !");
                    ChargerNotes(); // Recharger les notes
                }

                // Afficher la moyenne après l'ajout de la note
                AfficherMoyenne();
            }
            else
            {
                MessageBox.Show("Veuillez entrer une note valide !");
            }
        }

        // Charger les étudiants dans le ComboBox
        private void ChargerEtudiants()
        {
            using (var context = new DBGestionEtudiantContext())
            {
                var etudiants = context.Etudiants.ToList();
                cmbEtudiant.DataSource = etudiants;
                cmbEtudiant.DisplayMember = "Nom";  // Affiche le nom de l'étudiant
                cmbEtudiant.ValueMember = "Id";    // L'ID de l'étudiant
            }
        }

        // Charger les matières dans le ComboBox
        private void ChargerMatieres()
        {
            using (var context = new DBGestionEtudiantContext())
            {
                var matieres = context.Matieres.ToList();
                cmbMatiere.DataSource = matieres;
                cmbMatiere.DisplayMember = "NomMatiere";  // Affiche le nom de la matière
                cmbMatiere.ValueMember = "Id";            // L'ID de la matière
            }
        }

        // ...

        private void ChargerNotes()
        {
            using (var context = new DBGestionEtudiantContext())
            {
                // Utilisation d'Include pour charger les entités liées
                var notes = context.Notes
                   // .Include(n => n.Etudiant)  
                    //.Include(n => n.Matiere)   
                    .Select(n => new
                    {
                        EtudiantNom = n.Etudiant.Nom,       
                        MatiereNom = n.Matiere.NomMatiere,  
                        Note = n.ValeurNote                 
                    })
                    .ToList();

                // Affectation des notes à la tablebulletin (DataGridView)
                tablebulletin.DataSource = notes;
            }
        }


        // Calculer la moyenne d'un étudiant (en fonction de ses notes)
        private float CalculerMoyenne(int etudiantId)
        {
            using (var context = new DBGestionEtudiantContext())
            {
                var notes = context.Notes.Where(n => n.IdEtudiant == etudiantId).ToList();

                // Calcul de la moyenne si l'étudiant a des notes
                if (notes.Any())
                {
                    return notes.Average(n => n.ValeurNote);  // Moyenne des notes
                }

                return 0f;  // Si l'étudiant n'a pas de notes, on retourne 0
            }
        }

        // Afficher la moyenne générale de l'étudiant
        private void AfficherMoyenne()
        {
            if (cmbEtudiant.SelectedValue != null)
            {
                int etudiantId = (int)cmbEtudiant.SelectedValue;
                float moyenne = CalculerMoyenne(etudiantId);
                txtMoyenne.Text = $"Moyenne générale: {moyenne:0.00}";
            }
        }
    }
}
