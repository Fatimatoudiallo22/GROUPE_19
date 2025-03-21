using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSysthemeEtudiant
{
    public partial class FormCoursMat : Form
    {
        private SqlConnection connection;
        public FormCoursMat(SqlConnection conn)
        {
            InitializeComponent();
            ChargerCours();
            ChargerMatieres();
        }

        public FormCoursMat()
        {
        }

        // Charger les cours dans la ComboBox
        private void ChargerCours()
        {
            string query = "SELECT Id, NomCours FROM Cours";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(new ComboboxItem
                {
                    Text = reader["NomCours"].ToString(),
                    Value = reader["Id"].ToString()
                });
            }
            reader.Close();
        }

        // Charger les matières dans la ComboBox
        private void ChargerMatieres()
        {
            string query = "SELECT Id, NomMatière FROM Matières";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(new ComboboxItem
                {
                    Text = reader["NomMatière"].ToString(),
                    Value = reader["Id"].ToString()
                });
            }
            reader.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;

            int idCours = int.Parse((comboBox1.SelectedItem as ComboboxItem).Value);
            string query = @"
                SELECT M.Id, M.NomMatière
                FROM CoursMatières CM
                INNER JOIN Matières M ON CM.IdMatière = M.Id
                WHERE CM.IdCours = @IdCours";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@IdCours", idCours);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Afficher les matières associées dans le DataGridView
            dataGridView1.DataSource = dt;
        }

        // Associer une matière à un cours
        private void btnAssocierMatiere_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un cours et une matière.");
                return;
            }

            int idCours = int.Parse((comboBox1.SelectedItem as ComboboxItem).Value);
            int idMatiere = int.Parse((comboBox1.SelectedItem as ComboboxItem).Value);

            string query = "INSERT INTO CoursMatières (IdCours, IdMatière) VALUES (@IdCours, @IdMatière)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@IdCours", idCours);
            cmd.Parameters.AddWithValue("@IdMatière", idMatiere);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Matière associée avec succès !");
            comboBox1_SelectedIndexChanged(null, null); // Recharger les matières associées
        }

        // Ajouter un nouveau cours
        private void btnAjouterCours_Click(object sender, EventArgs e)
        {
            string nomCours = textBox2.Text;
            string description = richTextBox1.Text;

            if (string.IsNullOrEmpty(nomCours))
            {
                MessageBox.Show("Veuillez entrer un nom de cours.");
                return;
            }

            string query = "INSERT INTO Cours (NomCours, Description) VALUES (@NomCours, @Description)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@NomCours", nomCours);
            cmd.Parameters.AddWithValue("@Description", description);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Cours ajouté avec succès !");
            ChargerCours(); // Recharger la liste des cours
        }

        // Supprimer un cours
        private void btnSupprimerCours_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un cours.");
                return;
            }

            int idCours = int.Parse((comboBox1.SelectedItem as ComboboxItem).Value);

            string query = "DELETE FROM Cours WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Id", idCours);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Cours supprimé avec succès !");
            ChargerCours(); // Recharger la liste des cours
        }
        // Classe utilitaire pour les ComboBox et ListBox
        public class ComboboxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString() => Text;


        }
    }
}

