using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSysthemeEtudiant
{
    internal class ProfesseurClasse
    {
        public int IdProfesseur { get; set; }
        public int IdClasse { get; set; }

        // Propriétés de navigation
        public Professeur Professeur { get; set; }
        public Classe Classe { get; set; }
    }
}
