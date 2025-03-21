using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSysthemeEtudiant
{
    public partial class FormDE : Form
    {
        public FormDE()
        {
            InitializeComponent();
        }

        private void btncoursDE_Click(object sender, EventArgs e)
        {
            FormCours formcours = new FormCours();
            formcours.MdiParent = this;
            formcours.StartPosition = FormStartPosition.CenterParent;
            formcours.Size = new Size(1150, 638);
            formcours.Show();
        }

        private void btnclasseDE_Click(object sender, EventArgs e)
        {
            FormClasses formclasse = new FormClasses();
            formclasse.MdiParent = this;
            formclasse.StartPosition = FormStartPosition.CenterParent;
            formclasse.Size = new Size(1150, 638);
            formclasse.Show();
        }

        private void btnprofDE_Click(object sender, EventArgs e)
        {
            FormProf formprof = new FormProf();
            formprof.MdiParent = this;
            formprof.StartPosition = FormStartPosition.CenterParent;
            formprof.Size = new Size(1150, 638);
            formprof.Show();
        }

        private void btnmatiereDE_Click(object sender, EventArgs e)
        {
            FormMatiere formmatiere = new FormMatiere();
            formmatiere.MdiParent = this;
            formmatiere.StartPosition = FormStartPosition.CenterParent;
            formmatiere.Size = new Size(1150, 638);
            formmatiere.Show();
        }
    }
}
