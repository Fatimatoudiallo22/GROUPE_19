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
    public partial class FormProfesseur : Form
    {
        public FormProfesseur()
        {
            InitializeComponent();
        }

        private void btnnotePROF_Click(object sender, EventArgs e)
        {
            FormNotes formNotes = new FormNotes();
            formNotes.MdiParent = this;
            formNotes.StartPosition = FormStartPosition.CenterParent;
            formNotes.Size = new Size(1150, 638);
            formNotes.Show();
        }

        private void btnlisteEtuPROF_Click(object sender, EventArgs e)
        {
            FormListeEtudiant formListeEtudiant = new FormListeEtudiant();
            formListeEtudiant.MdiParent = this;
            formListeEtudiant.StartPosition = FormStartPosition.CenterParent;
            formListeEtudiant.Size = new Size(1150, 638);
            formListeEtudiant.Show();
        }

        private void FormProfesseur_Load(object sender, EventArgs e)
        {

        }
    }
}
