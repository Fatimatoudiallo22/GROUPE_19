using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSysthemeEtudiant
{
    internal class Classe
    {
       
            public int Id { get; set; }
            public string NomClasse { get; set; }

            // Relation avec les étudiants
            public virtual ICollection<Etudiant> Etudiants { get; set; }

            // Relation N:N avec les cours
            public virtual ICollection<Cours> Cours { get; set; }

            // Relation N:N avec les professeurs
            public virtual ICollection<Professeur> Professeurs { get; set; }
        

    }
}
