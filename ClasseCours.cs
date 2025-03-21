using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSysthemeEtudiant
{
    internal class ClasseCours
    {
        public int IdClasse { get; set; }
        public int IdCours { get; set; }

        // Propriétés de navigation
        public Classe Classe { get; set; }
        public Cours Cours { get; set; }
    }
}
