using System;
using System.Linq;
using System.Windows.Forms;

namespace GestionSysthemeEtudiant
{
    public partial class FormLogin : Form
    {
        public string UserRole { get; private set; } // Propriété pour stocker le rôle de l'utilisateur

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;  // Nom d'utilisateur saisi
            string password = txtMotdepasse.Text;  // Mot de passe saisi

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                txtUser.Text = "Nom d'utilisateur ou mot de passe manquant.";
                return;
            }

            using (var context = new DBGestionEtudiantContext())  // Connexion à la base de données
            {
                // Recherche de l'utilisateur par son nom d'utilisateur
                var user = context.Utilisateurs.FirstOrDefault(u => u.NomUtilisateur == username);

                if (user == null)
                {
                    txtUser.Text = "Utilisateur non trouvé.";
                    return;
                }

                // Vérification du mot de passe (à ajuster selon la manière dont vous stockez les mots de passe)
                if (user.MotDePasse == password)
                {
                    // L'utilisateur est authentifié, on récupère son rôle
                    UserRole = user.Role;

                    // Ferme le formulaire de connexion et retourne un résultat OK
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    txtMotdepasse.Text = "Mot de passe incorrect.";
                }
            }
        }
    }
}
