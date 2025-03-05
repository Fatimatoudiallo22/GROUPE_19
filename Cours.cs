using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSysthemeEtudiant
{
    internal class Cours
    {
       
            public int Id { get; set; }
            public string NomCours { get; set; }
            public string Description { get; set; }

            // Relation N:N avec les classes
            public virtual ICollection<Classe> Classes { get; set; }

            // Relation N:N avec les matières
            public virtual ICollection<Matiere> Matieres { get; set; }
        

    }
}
