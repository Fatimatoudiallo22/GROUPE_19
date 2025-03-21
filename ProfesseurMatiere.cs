using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSysthemeEtudiant
{
    internal class ProfesseurMatiere
    {
        public int IdProfesseur { get; set; }
        public int IdMatiere { get; set; }

        // Propriétés de navigation
        public Professeur Professeur { get; set; }
        public Matiere Matiere { get; set; }
    }
}
