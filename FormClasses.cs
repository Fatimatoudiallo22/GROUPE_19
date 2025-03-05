using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSysthemeEtudiant
{
    public partial class FormClasses : Form
    {
        public FormClasses()
        {
            InitializeComponent();
            ChargerClasses();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new DBGestionEtudiantContext())
            {
                Classe classe = new Classe();
                {
                    classe.NomClasse = txtClasse.Text;
                };
                context.Classes.Add(classe);
                context.SaveChanges();
                MessageBox.Show("Classe ajoutée avec succès !");
                ChargerClasses();
            }

        }
         void ChargerClasses()
        {
            using (var context = new DBGestionEtudiantContext())
            {
                tableClasse.DataSource = context.Classes.ToList();
            }
        }


        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            if (tableClasse.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de la classe sélectionnée
                int idClasse = Convert.ToInt32(tableClasse.SelectedRows[0].Cells["Id"].Value); // Assurez-vous que vous avez une colonne "Id" dans le DataGridView.

                // Trouver la classe correspondante dans la base de données
                using (var context = new DBGestionEtudiantContext())
                {
                    var classe = context.Classes.SingleOrDefault(c => c.Id == idClasse);
                    if (classe != null)
                    {
                        // Mettre à jour les informations de la classe
                        classe.NomClasse = txtClasse.Text; // Assurez-vous que txtClasse contient la nouvelle valeur.

                        // Sauvegarder les changements
                        context.SaveChanges();
                        MessageBox.Show("Classe modifiée avec succès !");
                        ChargerClasses(); // Recharger les données dans le DataGridView.
                    }
                    else
                    {
                        MessageBox.Show("Classe non trouvée !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une classe à modifier !");
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (tableClasse.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de la classe sélectionnée
                int idClasse = Convert.ToInt32(tableClasse.SelectedRows[0].Cells["Id"].Value);  // Assurez-vous que la colonne "Id" est présente dans le DataGridView

                // Demander une confirmation avant la suppression
                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette classe ?", "Confirmation de suppression", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    using (var context = new DBGestionEtudiantContext())
                    {
                        // Trouver la classe à supprimer dans la base de données
                        var classe = context.Classes.SingleOrDefault(c => c.Id == idClasse);

                        if (classe != null)
                        {
                            // Supprimer la classe
                            context.Classes.Remove(classe);
                            context.SaveChanges(); // Sauvegarder les changements dans la base de données
                            MessageBox.Show("Classe supprimée avec succès !");
                            ChargerClasses(); // Recharger les données dans le DataGridView pour refléter la suppression
                        }
                        else
                        {
                            MessageBox.Show("Classe non trouvée !");
                        }
                    }
                }
            }
            else
            {
                // Avertir l'utilisateur si aucune ligne n'est sélectionnée
                MessageBox.Show("Veuillez sélectionner une classe à supprimer !");
            }
        }

        private void txtRechercheClasse_TextChanged(object sender, EventArgs e)
        {
            
            string searchQuery = txtRechercheClasse.Text.ToLower();  // Récupérer la chaîne de recherche

            using (var context = new DBGestionEtudiantContext())
            {
                var filteredClasses = context.Classes
                    .Where(c => c.NomClasse.ToLower().Contains(searchQuery))  // Filtrer les classes par nom
                    .ToList();

                // Mettre à jour le DataGridView avec les résultats filtrés
                tableClasse.DataSource = filteredClasses;
            }
        }
    }
    
}
