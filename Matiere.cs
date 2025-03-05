using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSysthemeEtudiant
{
    internal class Matiere
    {
        
            public int Id { get; set; }
            public string NomMatiere { get; set; }

            // Relation N:N avec les cours
            public virtual ICollection<Cours> Cours { get; set; }

            // Relation N:N avec les professeurs
            public virtual ICollection<Professeur> Professeurs { get; set; }

            // Relation 1:N avec les notes
            public virtual ICollection<Note> Notes { get; set; }
        

    }
}
