using System;
using System.Linq;
using System.Windows.Forms;

namespace GestionSysthemeEtudiant
{
    public partial class FormEtudiants : Form
    {
        public FormEtudiants()
        {
            InitializeComponent();
            ChargerClasses();
        }

        private void FormEtudiants_Load(object sender, EventArgs e)
        {
            // Charger les classes dans la combo box lors du chargement du formulaire
            ChargerClasses();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Validation des champs
            if (string.IsNullOrEmpty(txtPrenom.Text) || string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtAdresse.Text) || string.IsNullOrEmpty(txtTelephone.Text))
            {
                MessageBox.Show("Tous les champs doivent être remplis.");
                return;
            }

            // Validation de l'email
            string email = txtEmail.Text;
            if (!ValiderEmail(email))
            {
                MessageBox.Show("L'email doit être au format @gmail.com.");
                return;
            }

            // Génération du matricule
            string matricule = GenererMatricule(txtPrenom.Text, txtNom.Text, dateTimeEtudiant.Value);

            // Récupérer le sexe (Homme ou Femme)
            string sexe = rbtnhomme.Checked ? "Homme" : "Femme";

            try
            {
                // Créer l'étudiant
                using (var context = new DBGestionEtudiantContext())
                {
                    var etudiant = new Etudiant
                    {
                        Matricule = matricule,
                        Nom = txtNom.Text,
                        Prenom = txtPrenom.Text,
                        DateNaissance = dateTimeEtudiant.Value,
                        Sexe = sexe,
                        Adresse = txtAdresse.Text,
                        Telephone = txtTelephone.Text,
                        Email = email,
                        IdClasse = (int)cboClasse.SelectedValue
                    };

                    context.Etudiants.Add(etudiant);
                    context.SaveChanges(); // Sauvegarde dans la base de données
                    MessageBox.Show("Étudiant ajouté avec succès !");
                    ChargerEtudiants(); // Recharge la liste des étudiants
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de l'étudiant : " + ex.Message);
            }
        }

        public void ChargerClasses()
        {
            using (var context = new DBGestionEtudiantContext())
            {
                cboClasse.DataSource = context.Classes.ToList();
                cboClasse.DisplayMember = "NomClasse";
                cboClasse.ValueMember = "Id";
            }
        }

        private void txtMatricule_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMatricule.Text))
            {
                txtMatricule.Text = GenererMatricule(txtPrenom.Text, txtNom.Text, dateTimeEtudiant.Value);
                txtMatricule.SelectionStart = txtMatricule.Text.Length;  // Placer le curseur à la fin du texte
            }
        }

        private string GenererMatricule(string prenom, string nom, DateTime dateNaissance)
        {
            // Extraire les 2 premières lettres du prénom
            string prenomPart = prenom.Length >= 2 ? prenom.Substring(0, 2).ToUpper() : prenom.ToUpper();

            // Extraire l'année de naissance
            string anneeNaissance = dateNaissance.Year.ToString();

            // Concaténer le prénom, l'année de naissance et le nom pour générer le matricule
            string matricule = prenomPart + anneeNaissance + nom.ToUpper();

            return matricule;
        }

        private void MettreAJourMatricule()
        {
            // Récupérer les valeurs des champs nécessaires
            string prenom = txtPrenom.Text;
            string nom = txtNom.Text;
            DateTime dateNaissance = dateTimeEtudiant.Value;

            // Générer le matricule
            string matricule = GenererMatricule(prenom, nom, dateNaissance);

            // Mettre à jour la zone de texte du matricule
            txtMatricule.Text = matricule;
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            MettreAJourMatricule();
        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {
            MettreAJourMatricule();
        }

        private void dateTimeEtudiant_ValueChanged(object sender, EventArgs e)
        {
            MettreAJourMatricule();
        }

        private bool ValiderEmail(string email)
        {
            // Vérifie si l'email se termine par @gmail.com
            return email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase);
        }

        public void ChargerEtudiants(string recherche = "")
        {
            using (var context = new DBGestionEtudiantContext())
            {
                var etudiants = string.IsNullOrEmpty(recherche)
                    ? context.Etudiants.ToList()  // Si aucun critère de recherche, on récupère tous les étudiants
                    : context.Etudiants
                        .Where(e => e.Nom.Contains(recherche) || e.Prenom.Contains(recherche) || e.Matricule.Contains(recherche))
                        .ToList();  // On filtre par nom, prénom ou matricule

                tableEtudiant.DataSource = etudiants;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Vérifier si un étudiant est sélectionné dans le DataGridView
            if (tableEtudiant.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de l'étudiant sélectionné
                int idEtudiant = (int)tableEtudiant.SelectedRows[0].Cells["Id"].Value;

                // Validation des champs
                if (string.IsNullOrEmpty(txtPrenom.Text) || string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtAdresse.Text) || string.IsNullOrEmpty(txtTelephone.Text))
                {
                    MessageBox.Show("Tous les champs doivent être remplis.");
                    return;
                }

                // Validation de l'email
                string email = txtEmail.Text;
                if (!ValiderEmail(email))
                {
                    MessageBox.Show("L'email doit être au format @gmail.com.");
                    return;
                }

                // Génération du matricule
                string matricule = GenererMatricule(txtPrenom.Text, txtNom.Text, dateTimeEtudiant.Value);

                // Récupérer le sexe (Homme ou Femme)
                string sexe = rbtnhomme.Checked ? "Homme" : "Femme";

                try
                {
                    // Récupérer l'étudiant à modifier
                    using (var context = new DBGestionEtudiantContext())
                    {
                        // Chercher l'étudiant par son ID
                        var etudiant = context.Etudiants.FirstOrDefault(ep => ep.Id == idEtudiant);
                        if (etudiant != null)
                        {
                            // Mettre à jour les informations de l'étudiant
                            etudiant.Matricule = matricule;
                            etudiant.Nom = txtNom.Text;
                            etudiant.Prenom = txtPrenom.Text;
                            etudiant.DateNaissance = dateTimeEtudiant.Value;
                            etudiant.Sexe = sexe;
                            etudiant.Adresse = txtAdresse.Text;
                            etudiant.Telephone = txtTelephone.Text;
                            etudiant.Email = email;
                            etudiant.IdClasse = (int)cboClasse.SelectedValue;

                            // Sauvegarder les modifications dans la base de données
                            context.SaveChanges();
                            MessageBox.Show("Étudiant modifié avec succès !");
                            ChargerEtudiants(); // Recharge la liste des étudiants
                        }
                        else
                        {
                            MessageBox.Show("L'étudiant n'a pas été trouvé.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification de l'étudiant : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à modifier.");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (tableEtudiant.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de l'étudiant sélectionné
                int idEtudiant = (int)tableEtudiant.SelectedRows[0].Cells["Id"].Value;

                // Demander une confirmation avant de supprimer
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet étudiant ?", "Confirmer la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Supprimer l'étudiant de la base de données
                    using (var context = new DBGestionEtudiantContext())
                    {
                        var etudiant = context.Etudiants.FirstOrDefault(ep => ep.Id == idEtudiant);
                        if (etudiant != null)
                        {
                            // Supprimer l'étudiant
                            context.Etudiants.Remove(etudiant);
                            context.SaveChanges(); // Sauvegarder les modifications

                            // Mettre à jour la liste des étudiants affichée
                            MessageBox.Show("L'étudiant a été supprimé avec succès.");
                            ChargerEtudiants();
                        }
                        else
                        {
                            MessageBox.Show("Étudiant non trouvé.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à supprimer.");
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            // Effacer les champs de saisie
            txtNom.Clear();
            txtPrenom.Clear();
            txtMatricule.Clear();
            txtAdresse.Clear();
            txtTelephone.Clear();
            txtEmail.Clear();
            cboClasse.SelectedIndex = -1;  // Réinitialiser la sélection de la classe
            rbtnhomme.Checked = false;    // Réinitialiser le sexe
            rbtnFemme.Checked = false;    // Réinitialiser le sexe
            dateTimeEtudiant.Value = DateTime.Now;  // Réinitialiser la date de naissance à la date actuelle
        }

        // Nouvelle méthode de recherche
        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            // Appeler ChargerEtudiants avec le texte de la recherche
            ChargerEtudiants(txtRecherche.Text);
        }
    }
}
