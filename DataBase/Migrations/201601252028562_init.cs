namespace DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Digimons",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NameEng = c.String(maxLength: 4000),
                        NameRus = c.String(maxLength: 4000),
                        Rank = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Speciality = c.Int(nullable: false),
                        Picture = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Digivolves",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DP = c.Int(nullable: false),
                        DigimonFrom_Id = c.Guid(),
                        DigimonTo_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Digimons", t => t.DigimonFrom_Id)
                .ForeignKey("dbo.Digimons", t => t.DigimonTo_Id)
                .Index(t => t.DigimonFrom_Id)
                .Index(t => t.DigimonTo_Id);
            
            CreateTable(
                "dbo.DigivolveDNAs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Result_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Digimons", t => t.Result_Id)
                .Index(t => t.Result_Id);
            
            CreateTable(
                "dbo.DigivolveDNAParents",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DigivolveDna_Id = c.Guid(),
                        Parent_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DigivolveDNAs", t => t.DigivolveDna_Id)
                .ForeignKey("dbo.Digimons", t => t.Parent_Id)
                .Index(t => t.DigivolveDna_Id)
                .Index(t => t.Parent_Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DescriptionEng = c.String(maxLength: 4000),
                        DescriptionRus = c.String(maxLength: 4000),
                        Domain_Id = c.Guid(),
                        Digimon_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Domains", t => t.Domain_Id)
                .ForeignKey("dbo.Digimons", t => t.Digimon_Id, cascadeDelete: true)
                .Index(t => t.Domain_Id)
                .Index(t => t.Digimon_Id);
            
            CreateTable(
                "dbo.Domains",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NameRus = c.String(maxLength: 4000),
                        NameEng = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Floors",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Num = c.Int(nullable: false),
                        Location_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.Location_Id)
                .Index(t => t.Location_Id);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Type = c.Int(nullable: false),
                        NameRus = c.String(maxLength: 4000),
                        NameEng = c.String(maxLength: 4000),
                        DescriptionRus = c.String(maxLength: 4000),
                        DescriptionEng = c.String(maxLength: 4000),
                        MP = c.Int(nullable: false),
                        AP = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Digimon_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Digimons", t => t.Digimon_Id, cascadeDelete: true)
                .Index(t => t.Digimon_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Skills", "Digimon_Id", "dbo.Digimons");
            DropForeignKey("dbo.Locations", "Digimon_Id", "dbo.Digimons");
            DropForeignKey("dbo.Floors", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.Locations", "Domain_Id", "dbo.Domains");
            DropForeignKey("dbo.DigivolveDNAs", "Result_Id", "dbo.Digimons");
            DropForeignKey("dbo.DigivolveDNAParents", "Parent_Id", "dbo.Digimons");
            DropForeignKey("dbo.DigivolveDNAParents", "DigivolveDna_Id", "dbo.DigivolveDNAs");
            DropForeignKey("dbo.Digivolves", "DigimonTo_Id", "dbo.Digimons");
            DropForeignKey("dbo.Digivolves", "DigimonFrom_Id", "dbo.Digimons");
            DropIndex("dbo.Skills", new[] { "Digimon_Id" });
            DropIndex("dbo.Floors", new[] { "Location_Id" });
            DropIndex("dbo.Locations", new[] { "Digimon_Id" });
            DropIndex("dbo.Locations", new[] { "Domain_Id" });
            DropIndex("dbo.DigivolveDNAParents", new[] { "Parent_Id" });
            DropIndex("dbo.DigivolveDNAParents", new[] { "DigivolveDna_Id" });
            DropIndex("dbo.DigivolveDNAs", new[] { "Result_Id" });
            DropIndex("dbo.Digivolves", new[] { "DigimonTo_Id" });
            DropIndex("dbo.Digivolves", new[] { "DigimonFrom_Id" });
            DropTable("dbo.Skills");
            DropTable("dbo.Floors");
            DropTable("dbo.Domains");
            DropTable("dbo.Locations");
            DropTable("dbo.DigivolveDNAParents");
            DropTable("dbo.DigivolveDNAs");
            DropTable("dbo.Digivolves");
            DropTable("dbo.Digimons");
        }
    }
}