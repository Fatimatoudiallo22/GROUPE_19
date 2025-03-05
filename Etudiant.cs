using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSysthemeEtudiant
{
    internal class Etudiant
    {
       
            public int Id { get; set; }
            public string Matricule { get; set; }
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public DateTime DateNaissance { get; set; }
            public string Sexe { get; set; }
            public string Adresse { get; set; }
            public string Telephone { get; set; }
            public string Email { get; set; }

            // Relation avec la classe
            public int IdClasse { get; set; }
            public virtual Classe Classe { get; set; }

            // Relation avec les notes
            public virtual ICollection<Note> Notes { get; set; }
        

    }
}
