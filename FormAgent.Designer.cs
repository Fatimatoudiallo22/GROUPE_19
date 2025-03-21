namespace GestionSysthemeEtudiant
{
    partial class FormAgent
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
            this.btnEtudiantAgent = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNotesAgent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 580);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNotesAgent);
            this.panel2.Controls.Add(this.btnEtudiantAgent);
            this.panel2.Location = new System.Drawing.Point(3, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 378);
            this.panel2.TabIndex = 0;
            // 
            // btnEtudiantAgent
            // 
            this.btnEtudiantAgent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEtudiantAgent.Location = new System.Drawing.Point(0, 0);
            this.btnEtudiantAgent.Name = "btnEtudiantAgent";
            this.btnEtudiantAgent.Size = new System.Drawing.Size(194, 46);
            this.btnEtudiantAgent.TabIndex = 0;
            this.btnEtudiantAgent.Text = "Etudiant";
            this.btnEtudiantAgent.UseVisualStyleBackColor = true;
            this.btnEtudiantAgent.Click += new System.EventHandler(this.btnEtudiantAgent_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FloralWhite;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 91);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FloralWhite;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 100);
            this.panel4.TabIndex = 2;
            // 
            // btnNotesAgent
            // 
            this.btnNotesAgent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotesAgent.Location = new System.Drawing.Point(0, 46);
            this.btnNotesAgent.Name = "btnNotesAgent";
            this.btnNotesAgent.Size = new System.Drawing.Size(194, 47);
            this.btnNotesAgent.TabIndex = 1;
            this.btnNotesAgent.Text = "Notes";
            this.btnNotesAgent.UseVisualStyleBackColor = true;
            this.btnNotesAgent.Click += new System.EventHandler(this.btnNotesAgent_Click);
            // 
            // FormAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FormAgent";
            this.Text = "FormAgent";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEtudiantAgent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNotesAgent;
    }
}