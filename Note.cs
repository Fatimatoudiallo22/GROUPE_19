using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSysthemeEtudiant
{
    internal class Note
    {
       
            public int Id { get; set; }
            public int IdEtudiant { get; set; }
            public virtual Etudiant Etudiant { get; set; }

            public int IdMatiere { get; set; }
            public virtual Matiere Matiere { get; set; }

            public float ValeurNote { get; set; }
        

    }
}
