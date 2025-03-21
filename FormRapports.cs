using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;

namespace GestionSysthemeEtudiant
{
    public partial class FormRapports : Form
    {
        private SqlConnection connection;

        public FormRapports(SqlConnection conn)
        {
            InitializeComponent();
            connection = conn;
            LoadClasses();
            LoadEtudiants();
        }

        public FormRapports()
        {
        }

        // Charger les classes dans la ComboBox
        private void LoadClasses()
        {
            string query = "SELECT Id, NomClasse FROM Classes";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(new ComboboxItem
                {
                    Text = reader["NomClasse"].ToString(),
                    Value = reader["Id"].ToString()
                });
            }
            reader.Close();
        }

        // Charger les étudiants dans la ComboBox
        private void LoadEtudiants()
        {
            string query = "SELECT Id, Nom, Prénom FROM Étudiants";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(new ComboboxItem
                {
                    Text = $"{reader["Nom"]} {reader["Prénom"]}",
                    Value = reader["Id"].ToString()
                });
            }
            reader.Close();
        }

        // Générer le rapport en fonction des critères sélectionnés
        private void btnGenerer_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null && comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une classe ou un étudiant.");
                return;
            }

            string query = "";
            if (comboBox1.SelectedItem != null)
            {
                int idClasse = int.Parse((comboBox1.SelectedItem as ComboboxItem).Value);
                query = @"
                    SELECT E.Nom, E.Prénom, M.NomMatière, N.Note
                    FROM Notes N
                    INNER JOIN Étudiants E ON N.IdÉtudiant = E.Id
                    INNER JOIN Matières M ON N.IdMatière = M.Id
                    WHERE E.IdClasse = @IdClasse";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@IdClasse", idClasse);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox2.SelectedItem != null)
            {
                int idEtudiant = int.Parse((comboBox2.SelectedItem as ComboboxItem).Value);
                query = @"
                    SELECT M.NomMatière, N.Note
                    FROM Notes N
                    INNER JOIN Matières M ON N.IdMatière = M.Id
                    WHERE N.IdÉtudiant = @IdÉtudiant";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@IdÉtudiant", idEtudiant);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        // Exporter le rapport en PDF
        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Aucune donnée à exporter.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Exporter en PDF"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                document.Open();

                PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    table.AddCell(dataGridView1.Columns[i].HeaderText);
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        table.AddCell(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    }
                }

                document.Add(table);
                document.Close();

                MessageBox.Show("Export réussi !");
            }
        }

        // Exporter le rapport en Excel
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Aucune donnée à exporter.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                Title = "Exporter en Excel"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Rapport");
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;
                    }

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                    excelPackage.SaveAs(excelFile);
                }

                MessageBox.Show("Export réussi !");
            }
        }
    }

    // Classe utilitaire pour les ComboBox
    public class ComboboxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public override string ToString() => Text;
    }
}