namespace GestionSysthemeEtudiant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomClasse = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomCours = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Matieres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomMatiere = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdEtudiant = c.Int(nullable: false),
                        IdMatiere = c.Int(nullable: false),
                        ValeurNote = c.Single(nullable: false),
                        Etudiant_Id = c.Int(),
                        Matiere_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Etudiants", t => t.Etudiant_Id)
                .ForeignKey("dbo.Matieres", t => t.Matiere_Id)
                .Index(t => t.Etudiant_Id)
                .Index(t => t.Matiere_Id);
            
            CreateTable(
                "dbo.Etudiants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Matricule = c.String(),
                        Nom = c.String(),
                        Prenom = c.String(),
                        DateNaissance = c.DateTime(nullable: false),
                        Sexe = c.String(),
                        Adresse = c.String(),
                        Telephone = c.String(),
                        Email = c.String(),
                        IdClasse = c.Int(nullable: false),
                        Classe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Classe_Id)
                .Index(t => t.Classe_Id);
            
            CreateTable(
                "dbo.Professeurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Email = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OTPCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUtilisateur = c.Int(nullable: false),
                        Code = c.String(),
                        DateExpiration = c.DateTime(nullable: false),
                        Utilisateur_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilisateurs", t => t.Utilisateur_Id)
                .Index(t => t.Utilisateur_Id);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomUtilisateur = c.String(),
                        MotDePasse = c.String(),
                        Role = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CoursClasses",
                c => new
                    {
                        Cours_Id = c.Int(nullable: false),
                        Classe_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Cours_Id, t.Classe_Id })
                .ForeignKey("dbo.Cours", t => t.Cours_Id, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.Classe_Id, cascadeDelete: true)
                .Index(t => t.Cours_Id)
                .Index(t => t.Classe_Id);
            
            CreateTable(
                "dbo.MatiereCours",
                c => new
                    {
                        Matiere_Id = c.Int(nullable: false),
                        Cours_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Matiere_Id, t.Cours_Id })
                .ForeignKey("dbo.Matieres", t => t.Matiere_Id, cascadeDelete: true)
                .ForeignKey("dbo.Cours", t => t.Cours_Id, cascadeDelete: true)
                .Index(t => t.Matiere_Id)
                .Index(t => t.Cours_Id);
            
            CreateTable(
                "dbo.ProfesseurClasses",
                c => new
                    {
                        Professeur_Id = c.Int(nullable: false),
                        Classe_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Professeur_Id, t.Classe_Id })
                .ForeignKey("dbo.Professeurs", t => t.Professeur_Id, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.Classe_Id, cascadeDelete: true)
                .Index(t => t.Professeur_Id)
                .Index(t => t.Classe_Id);
            
            CreateTable(
                "dbo.ProfesseurMatieres",
                c => new
                    {
                        Professeur_Id = c.Int(nullable: false),
                        Matiere_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Professeur_Id, t.Matiere_Id })
                .ForeignKey("dbo.Professeurs", t => t.Professeur_Id, cascadeDelete: true)
                .ForeignKey("dbo.Matieres", t => t.Matiere_Id, cascadeDelete: true)
                .Index(t => t.Professeur_Id)
                .Index(t => t.Matiere_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OTPCodes", "Utilisateur_Id", "dbo.Utilisateurs");
            DropForeignKey("dbo.ProfesseurMatieres", "Matiere_Id", "dbo.Matieres");
            DropForeignKey("dbo.ProfesseurMatieres", "Professeur_Id", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseurClasses", "Classe_Id", "dbo.Classes");
            DropForeignKey("dbo.ProfesseurClasses", "Professeur_Id", "dbo.Professeurs");
            DropForeignKey("dbo.Notes", "Matiere_Id", "dbo.Matieres");
            DropForeignKey("dbo.Notes", "Etudiant_Id", "dbo.Etudiants");
            DropForeignKey("dbo.Etudiants", "Classe_Id", "dbo.Classes");
            DropForeignKey("dbo.MatiereCours", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.MatiereCours", "Matiere_Id", "dbo.Matieres");
            DropForeignKey("dbo.CoursClasses", "Classe_Id", "dbo.Classes");
            DropForeignKey("dbo.CoursClasses", "Cours_Id", "dbo.Cours");
            DropIndex("dbo.ProfesseurMatieres", new[] { "Matiere_Id" });
            DropIndex("dbo.ProfesseurMatieres", new[] { "Professeur_Id" });
            DropIndex("dbo.ProfesseurClasses", new[] { "Classe_Id" });
            DropIndex("dbo.ProfesseurClasses", new[] { "Professeur_Id" });
            DropIndex("dbo.MatiereCours", new[] { "Cours_Id" });
            DropIndex("dbo.MatiereCours", new[] { "Matiere_Id" });
            DropIndex("dbo.CoursClasses", new[] { "Classe_Id" });
            DropIndex("dbo.CoursClasses", new[] { "Cours_Id" });
            DropIndex("dbo.OTPCodes", new[] { "Utilisateur_Id" });
            DropIndex("dbo.Etudiants", new[] { "Classe_Id" });
            DropIndex("dbo.Notes", new[] { "Matiere_Id" });
            DropIndex("dbo.Notes", new[] { "Etudiant_Id" });
            DropTable("dbo.ProfesseurMatieres");
            DropTable("dbo.ProfesseurClasses");
            DropTable("dbo.MatiereCours");
            DropTable("dbo.CoursClasses");
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.OTPCodes");
            DropTable("dbo.Professeurs");
            DropTable("dbo.Etudiants");
            DropTable("dbo.Notes");
            DropTable("dbo.Matieres");
            DropTable("dbo.Cours");
            DropTable("dbo.Classes");
        }
    }
}
