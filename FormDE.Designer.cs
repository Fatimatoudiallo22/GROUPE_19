namespace GestionSysthemeEtudiant
{
    partial class FormDE
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncoursDE = new System.Windows.Forms.Button();
            this.btnmatiereDE = new System.Windows.Forms.Button();
            this.btnprofDE = new System.Windows.Forms.Button();
            this.btnclasseDE = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 599);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnclasseDE);
            this.panel2.Controls.Add(this.btnprofDE);
            this.panel2.Controls.Add(this.btnmatiereDE);
            this.panel2.Controls.Add(this.btncoursDE);
            this.panel2.Location = new System.Drawing.Point(3, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 371);
            this.panel2.TabIndex = 0;
            // 
            // btncoursDE
            // 
            this.btncoursDE.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncoursDE.Location = new System.Drawing.Point(0, 0);
            this.btncoursDE.Name = "btncoursDE";
            this.btncoursDE.Size = new System.Drawing.Size(194, 50);
            this.btncoursDE.TabIndex = 0;
            this.btncoursDE.Text = "Cours";
            this.btncoursDE.UseVisualStyleBackColor = true;
            this.btncoursDE.Click += new System.EventHandler(this.btncoursDE_Click);
            // 
            // btnmatiereDE
            // 
            this.btnmatiereDE.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmatiereDE.Location = new System.Drawing.Point(0, 50);
            this.btnmatiereDE.Name = "btnmatiereDE";
            this.btnmatiereDE.Size = new System.Drawing.Size(194, 47);
            this.btnmatiereDE.TabIndex = 1;
            this.btnmatiereDE.Text = "Matiere";
            this.btnmatiereDE.UseVisualStyleBackColor = true;
            this.btnmatiereDE.Click += new System.EventHandler(this.btnmatiereDE_Click);
            // 
            // btnprofDE
            // 
            this.btnprofDE.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnprofDE.Location = new System.Drawing.Point(0, 97);
            this.btnprofDE.Name = "btnprofDE";
            this.btnprofDE.Size = new System.Drawing.Size(194, 47);
            this.btnprofDE.TabIndex = 2;
            this.btnprofDE.Text = "Professeur";
            this.btnprofDE.UseVisualStyleBackColor = true;
            this.btnprofDE.Click += new System.EventHandler(this.btnprofDE_Click);
            // 
            // btnclasseDE
            // 
            this.btnclasseDE.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnclasseDE.Location = new System.Drawing.Point(0, 144);
            this.btnclasseDE.Name = "btnclasseDE";
            this.btnclasseDE.Size = new System.Drawing.Size(194, 43);
            this.btnclasseDE.TabIndex = 3;
            this.btnclasseDE.Text = "Classe";
            this.btnclasseDE.UseVisualStyleBackColor = true;
            this.btnclasseDE.Click += new System.EventHandler(this.btnclasseDE_Click);
            // 
            // FormDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 599);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FormDE";
            this.Text = "FormDE";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnclasseDE;
        private System.Windows.Forms.Button btnprofDE;
        private System.Windows.Forms.Button btnmatiereDE;
        private System.Windows.Forms.Button btncoursDE;
    }
}