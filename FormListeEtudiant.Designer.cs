namespace GestionSysthemeEtudiant
{
    partial class FormListeEtudiant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableListeEtudiant = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRechercheListeEtu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableListeEtudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // tableListeEtudiant
            // 
            this.tableListeEtudiant.AllowUserToAddRows = false;
            this.tableListeEtudiant.AllowUserToDeleteRows = false;
            this.tableListeEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableListeEtudiant.Location = new System.Drawing.Point(63, 66);
            this.tableListeEtudiant.Name = "tableListeEtudiant";
            this.tableListeEtudiant.ReadOnly = true;
            this.tableListeEtudiant.Size = new System.Drawing.Size(575, 287);
            this.tableListeEtudiant.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recherche";
            // 
            // txtRechercheListeEtu
            // 
            this.txtRechercheListeEtu.Location = new System.Drawing.Point(229, 33);
            this.txtRechercheListeEtu.Name = "txtRechercheListeEtu";
            this.txtRechercheListeEtu.Size = new System.Drawing.Size(244, 20);
            this.txtRechercheListeEtu.TabIndex = 2;
            this.txtRechercheListeEtu.TextChanged += new System.EventHandler(this.txtRechercheListeEtu_TextChanged);
            // 
            // FormListeEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 599);
            this.Controls.Add(this.txtRechercheListeEtu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableListeEtudiant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormListeEtudiant";
            this.Text = "FormListeEtudiant";
            ((System.ComponentModel.ISupportInitialize)(this.tableListeEtudiant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableListeEtudiant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRechercheListeEtu;
    }
}