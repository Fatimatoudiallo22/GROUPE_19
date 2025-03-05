using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestionSysthemeEtudiant
{
    public partial class FormListeEtudiant : Form
    {
        private List<Etudiant> etudiantsList;  // Liste des étudiants pour effectuer la recherche

        public FormListeEtudiant()
        {
            InitializeComponent();
            ChargerEtudiants();  // Charger les étudiants au démarrage
        }

        // Charger la liste des étudiants dans le DataGridView
        private void ChargerEtudiants()
        {
            using (var context = new DBGestionEtudiantContext())
            {
                // Charger les étudiants à partir de la base de données
                etudiantsList = context.Etudiants.ToList();

                // Afficher les étudiants dans le DataGridView
                tableListeEtudiant.DataSource = etudiantsList;
            }
        }

        // Recherche en temps réel à chaque fois que le texte change dans le champ de recherche
        private void txtRechercheListeEtu_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtRechercheListeEtu.Text.ToLower();  // Récupérer la chaîne de recherche

            // Filtrer les étudiants en fonction du texte saisi (par exemple, par nom ou matricule)
            var filteredList = etudiantsList.Where(ep => ep.Nom.ToLower().Contains(searchQuery) ||
                                                       ep.Matricule.ToLower().Contains(searchQuery)).ToList();

            // Mettre à jour le DataGridView avec la liste filtrée
            tableListeEtudiant.DataSource = filteredList;
        }
    }
}
