using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestionSysthemeEtudiant
{
    public partial class FormUtilisateur : Form
    {
        public FormUtilisateur()
        {
            InitializeComponent();
        }

        // Charger les rôles dans le ComboBox lors du chargement du formulaire
        private void FormUtilisateur_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Add("Administrateur");
            cmbRole.Items.Add("Directeur d'Études");
            cmbRole.Items.Add("Agent");
            cmbRole.Items.Add("Professeur");

            // Charger la liste des utilisateurs
            ApremiersVU();
        }

        // Ajouter un utilisateur à la base de données
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (var context = new DBGestionEtudiantContext())
            {
                // Vérifier que le rôle est sélectionné
                if (cmbRole.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez sélectionner un rôle.");
                    return;
                }

                // Créer un nouvel utilisateur avec les informations saisies
                var user = new Utilisateur
                {
                    NomUtilisateur = txtNomUser.Text,
                    MotDePasse = txtMotsdePasse.Text,
                    Telephone = txtTelUser.Text,
                    Role = cmbRole.SelectedItem.ToString()
                };

                // Ajouter l'utilisateur à la base de données
                context.Utilisateurs.Add(user);
                context.SaveChanges();

                // Mettre à jour le DataGridView
                ApremiersVU();

                MessageBox.Show("Utilisateur ajouté avec succès.");
            }
        }

        // Charger et afficher tous les utilisateurs dans le DataGridView
        private void ApremiersVU()
        {
            using (var context = new DBGestionEtudiantContext())
            {
                var users = context.Utilisateurs.ToList();
                tableUser.DataSource = users;

                // Renommer les colonnes si nécessaire
                tableUser.Columns["Role"].HeaderText = "Rôle Utilisateur";
            }
        }

        // Modifier un utilisateur sélectionné
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (tableUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à modifier.");
                return;
            }

            // Récupérer l'ID de l'utilisateur sélectionné
            int userId = Convert.ToInt32(tableUser.SelectedRows[0].Cells["Id"].Value);

            using (var context = new DBGestionEtudiantContext())
            {
                var user = context.Utilisateurs.FirstOrDefault(u => u.Id == userId);
                if (user != null)
                {
                    // Mettre à jour les informations de l'utilisateur
                    user.NomUtilisateur = txtNomUser.Text;
                    user.MotDePasse = txtMotsdePasse.Text;
                    user.Telephone = txtTelUser.Text;
                    user.Role = cmbRole.SelectedItem.ToString();

                    // Sauvegarder les changements
                    context.SaveChanges();

                    // Mettre à jour le DataGridView
                    ApremiersVU();

                    MessageBox.Show("Utilisateur modifié avec succès.");
                }
                else
                {
                    MessageBox.Show("Utilisateur introuvable.");
                }
            }
        }

        // Supprimer un utilisateur sélectionné
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (tableUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer.");
                return;
            }

            // Récupérer l'ID de l'utilisateur sélectionné
            int userId = Convert.ToInt32(tableUser.SelectedRows[0].Cells["Id"].Value);

            using (var context = new DBGestionEtudiantContext())
            {
                var user = context.Utilisateurs.FirstOrDefault(u => u.Id == userId);
                if (user != null)
                {
                    // Supprimer l'utilisateur
                    context.Utilisateurs.Remove(user);
                    context.SaveChanges();

                    // Mettre à jour le DataGridView
                    ApremiersVU();

                    MessageBox.Show("Utilisateur supprimé avec succès.");
                }
                else
                {
                    MessageBox.Show("Utilisateur introuvable.");
                }
            }
        }

        // Rechercher un utilisateur dans le DataGridView
        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtRecherche.Text.ToLower();

            using (var context = new DBGestionEtudiantContext())
            {
                var filteredUsers = context.Utilisateurs
                    .Where(u => u.NomUtilisateur.ToLower().Contains(searchTerm) || u.Telephone.Contains(searchTerm))
                    .ToList();

                tableUser.DataSource = filteredUsers;
            }
        }
    }
}
