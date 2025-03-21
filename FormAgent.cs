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
    public partial class FormAgent : Form
    {
        public FormAgent()
        {
            InitializeComponent();
        }

        private void btnEtudiantAgent_Click(object sender, EventArgs e)
        {
            FormEtudiants formEtudiants = new FormEtudiants();
          
            formEtudiants.MdiParent = this;
            formEtudiants.StartPosition = FormStartPosition.CenterParent;
            formEtudiants.Size = new Size(1150, 638);
            formEtudiants.Show();

        }

        private void btnNotesAgent_Click(object sender, EventArgs e)
        {
            FormNotes formNotes = new FormNotes();
            formNotes.MdiParent = this;  
            formNotes.StartPosition = FormStartPosition.CenterParent;  
            formNotes.Size = new Size(1150 , 638);  
            formNotes.Show();  
        }
    }
}
