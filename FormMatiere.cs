using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSysthemeEtudiant
{
    public partial class FormMatiere : Form
    {
        public FormMatiere()
        {
            InitializeComponent();
            ChargerMatieres();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatiere.Text) )
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }
            using(var context = new DBGestionEtudiantContext())
            {
                Matiere matiere = new Matiere
                {
                    NomMatiere = txtMatiere.Text
                };
                context.Matieres.Add(matiere);
                context.SaveChanges();
                MessageBox.Show("Matière ajoutée avec succès !");
                ChargerMatieres();
                txtMatiere.Clear();
            }
        }
        void ChargerMatieres()
        {
            using (var context = new DBGestionEtudiantContext())
            {
                tableMatiere.DataSource = context.Matieres.ToList();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans la DataGridView
            if (tableMatiere.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de la matière sélectionnée
                int idMatiere = Convert.ToInt32(tableMatiere.SelectedRows[0].Cells["Id"].Value);

                using (var context = new DBGestionEtudiantContext())
                {
                    // Trouver la matière correspondante dans la base de données
                    var matiere = context.Matieres.SingleOrDefault(m => m.Id == idMatiere);
                    if (matiere != null)
                    {
                        // Modifier les propriétés de la matière
                        matiere.NomMatiere = txtMatiere.Text;

                        // Sauvegarder les modifications
                        context.SaveChanges();
                        MessageBox.Show("Matière modifiée avec succès !");
                        ChargerMatieres(); // Recharger la liste des matières
                        txtMatiere.Clear(); // Effacer les champs après la modification
                    }
                    else
                    {
                        MessageBox.Show("Matière non trouvée !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une matière à modifier !");
            }
        }


        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans la DataGridView
            if (tableMatiere.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de la matière sélectionnée
                int idMatiere = Convert.ToInt32(tableMatiere.SelectedRows[0].Cells["Id"].Value);

                // Demander une confirmation avant de supprimer
                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette matière ?",
                                             "Confirmation de suppression",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (var context = new DBGestionEtudiantContext())
                    {
                        // Trouver la matière dans la base de données par son ID
                        var matiere = context.Matieres.SingleOrDefault(m => m.Id == idMatiere);
                        if (matiere != null)
                        {
                            // Supprimer la matière
                            context.Matieres.Remove(matiere);
                            context.SaveChanges();
                            MessageBox.Show("Matière supprimée avec succès !");
                            ChargerMatieres(); // Recharger la liste des matières
                            txtMatiere.Clear(); // Effacer les champs
                        }
                        else
                        {
                            MessageBox.Show("Matière non trouvée !");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une matière à supprimer !");
            }
        }

    }
}
