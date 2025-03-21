using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSysthemeEtudiant
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Form1());


            // Affichage du formulaire de connexion
            FormLogin loginForm = new FormLogin();
            if (loginForm.ShowDialog() == DialogResult.OK)  // Si l'utilisateur s'est connecté avec succès
            {
                string userRole = loginForm.UserRole;  // Récupération du rôle de l'utilisateur

                // Lancement du bon formulaire en fonction du rôle
                if (userRole == "Administrateur")
                {
                    Application.Run(new Form1());  // Formulaire pour Administrateur
                }
                else if (userRole == "Directeur d'Études")
                {
                    Application.Run(new FormDE());  // Formulaire pour Directeur d'Études
                }
                else if (userRole == "Agent")
                {
                    Application.Run(new FormAgent());  // Formulaire pour Agent
                }
                else if (userRole == "Professeur")
                {
                    Application.Run(new FormProfesseur());  // Formulaire pour Professeur
                }
            }


        }
    }
}
