using System;
using System.Linq;
using System.Windows.Forms;

namespace GestionSysthemeEtudiant
{
    public partial class FormCours : Form
    {
        public FormCours()
        {
            InitializeComponent();
            ChargerCours();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Validation des champs
            if (string.IsNullOrEmpty(txtCours.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            using (var context = new DBGestionEtudiantContext())
            {
                // Création du cours
                Cours cours = new Cours
                {
                    NomCours = txtCours.Text,
                    Description = txtDescription.Text
                };

                // Ajout du cours dans la base de données
                context.Courss.Add(cours);
                context.SaveChanges();

                MessageBox.Show("Cours ajouté avec succès !");

                // Recharger la liste des cours
                ChargerCours();

                // Optionnel : Effacer les champs après l'ajout
                txtCours.Clear();
                txtDescription.Clear();
            }
        }

        void ChargerCours(string recherche = "")
        {
            using (var context = new DBGestionEtudiantContext())
            {
                // Si une recherche est spécifiée, filtrer les cours
                var coursList = string.IsNullOrEmpty(recherche)
                    ? context.Courss.ToList()  // Si pas de recherche, charger tous les cours
                    : context.Courss
                        .Where(c => c.NomCours.ToLower().Contains(recherche.ToLower()))  // Filtrer par nom de cours
                        .ToList();

                // Afficher les résultats dans la DataGridView
                tableCours.DataSource = coursList;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (tableCours.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du cours sélectionné
                int idCours = Convert.ToInt32(tableCours.SelectedRows[0].Cells["Id"].Value);

                using (var context = new DBGestionEtudiantContext())
                {
                    // Trouver le cours dans la base de données par son ID
                    var cours = context.Courss.SingleOrDefault(c => c.Id == idCours);

                    if (cours != null)
                    {
                        // Mettre à jour les informations du cours
                        cours.NomCours = txtCours.Text;
                        cours.Description = txtDescription.Text;

                        // Sauvegarder les modifications
                        context.SaveChanges();

                        MessageBox.Show("Cours modifié avec succès !");

                        // Recharger la liste des cours pour afficher les modifications
                        ChargerCours();

                        // Optionnel : Effacer les champs après la modification
                        txtCours.Clear();
                        txtDescription.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Cours non trouvé !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un cours à modifier !");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (tableCours.SelectedRows.Count > 0)
            {
                int idCours = Convert.ToInt32(tableCours.SelectedRows[0].Cells["Id"].Value);

                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce cours ?",
                                             "Confirmation de suppression",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (var context = new DBGestionEtudiantContext())
                    {
                        var cours = context.Courss.SingleOrDefault(c => c.Id == idCours);

                        if (cours != null)
                        {
                            context.Courss.Remove(cours);
                            context.SaveChanges();
                            MessageBox.Show("Cours supprimé avec succès !");

                            ChargerCours(); // Recharger la liste après suppression
                        }
                        else
                        {
                            MessageBox.Show("Cours non trouvé !");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un cours à supprimer !");
            }
        }

        // Fonction de recherche de cours
        private void txtRchercheCours_TextChanged(object sender, EventArgs e)
        {
            string recherche = txtRchercheCours.Text;  // Récupérer le texte saisi par l'utilisateur
            ChargerCours(recherche);  // Charger les cours filtrés
        }

        private void FormCours_Load(object sender, EventArgs e)
        {

        }
    }
}
