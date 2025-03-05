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
    public partial class FormProf : Form
    {
        public FormProf()
        {
            InitializeComponent();
            ChargerProfs();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomprof.Text) || string.IsNullOrEmpty(txtPrenomprof.Text) || string.IsNullOrEmpty(txtEmailprof.Text) || string.IsNullOrEmpty(txtTelprof.Text))
            {
                MessageBox.Show("Tous les champs doivent être remplis !");
                return;
            }
            using (var context = new DBGestionEtudiantContext())
            {
                Professeur prof = new Professeur();
                {
                    prof.Nom = txtNomprof.Text;
                    prof.Prenom = txtPrenomprof.Text;
                    prof.Email = txtEmailprof.Text;
                    prof.Telephone = txtTelprof.Text;
                    foreach (var item in cklisteClasse.CheckedItems)
                    {
                        var classe = item as Classe;
                        if (classe != null)
                        {
                            prof.Classes.Add(classe);  // Associer la classe au professeur
                        }
                    }
                };
               
                context.Professeurs.Add(prof);
                context.SaveChanges();
                MessageBox.Show("Professeur ajouté avec succès !");
                ChargerProfs();
            }
        }
        void ChargerProfs()
        {
            using (var context = new DBGestionEtudiantContext())
            {
                tableprof.DataSource = context.Professeurs.ToList();
            }
        }
        public void ChargerClasses()
        {
            using (var context = new DBGestionEtudiantContext())
            {
               cklisteClasse.DataSource = context.Classes.ToList();
               cklisteClasse.DisplayMember = "NomClasse";  // Affiche le nom de la classe
               cklisteClasse.ValueMember = "Id";  // Associe l'ID à chaque élément
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (tableprof.SelectedRows.Count > 0)
            {
                int idProfesseur = Convert.ToInt32(tableprof.SelectedRows[0].Cells["Id"].Value);

                using (var context = new DBGestionEtudiantContext())
                {
                    var professeur = context.Professeurs.SingleOrDefault(p => p.Id == idProfesseur);

                    if (professeur != null)
                    {
                        txtNomprof.Text = professeur.Nom;
                        txtPrenomprof.Text = professeur.Prenom;
                        txtEmailprof.Text = professeur.Email;
                        txtTelprof.Text = professeur.Telephone;

                        // Cocher les classes associées au professeur
                        for (int i = 0; i < cklisteClasse.Items.Count; i++)
                        {
                            var classe = cklisteClasse.Items[i] as Classe;
                            if (classe != null && professeur.Classes.Contains(classe))
                            {
                                cklisteClasse.SetItemChecked(i, true);  // Cocher la classe
                            }
                            else
                            {
                                cklisteClasse.SetItemChecked(i, false);  // Décocher la classe si non associée
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Professeur non trouvé !");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un professeur à modifier !");
            }
        }


        private void btndelete_Click(object sender, EventArgs e)
        {
            if (tableprof.SelectedRows.Count > 0)
            {
                int idProfesseur = Convert.ToInt32(tableprof.SelectedRows[0].Cells["Id"].Value);
                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce professeur ?", "Confirmation de suppression", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    using (var context = new DBGestionEtudiantContext())
                    {
                        var professeur = context.Professeurs.SingleOrDefault(p => p.Id == idProfesseur);

                        if (professeur != null)
                        {
                            context.Professeurs.Remove(professeur);
                            context.SaveChanges();
                            MessageBox.Show("Professeur supprimé avec succès !");
                            ChargerProfs(); // Recharger la liste des professeurs
                        }
                        else
                        {
                            MessageBox.Show("Professeur non trouvé !");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un professeur à supprimer !");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // Réinitialiser les champs
            txtNomprof.Text = "";
            txtPrenomprof.Text = "";
            txtEmailprof.Text = "";
            txtTelprof.Text = "";

            // Décocher toutes les cases dans le CheckedListBox
            for (int i = 0; i < cklisteClasse.Items.Count; i++)
            {
                cklisteClasse.SetItemChecked(i, false);
            }
        }

    }
}
