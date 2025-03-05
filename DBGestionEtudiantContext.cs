using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSysthemeEtudiant
{
    internal class DBGestionEtudiantContext : DbContext
    {
        public DBGestionEtudiantContext() : base("etudiantgestion")
        {
        }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<Matiere> Matieres { get; set; }
        public DbSet<Cours> Courss { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<OTPCodes> OTPcode { get; set; }

    }
}
