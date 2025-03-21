using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSysthemeEtudiant
{
    internal class CoursMatiere
    {
        public int IdCours { get; set; }
        public int IdMatiere { get; set; }

        // Propriétés de navigation
        public Cours Cours { get; set; }
        public Matiere Matiere { get; set; }
    }
}
