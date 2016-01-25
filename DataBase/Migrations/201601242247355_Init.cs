namespace DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Digivolves",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DP = c.Int(nullable: false),
                        Digimon_Id = c.Guid(),
                        Digimon_Id1 = c.Guid(),
                        Digimon_Id2 = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Digimons", t => t.Digimon_Id)
                .ForeignKey("dbo.Digimons", t => t.Digimon_Id1)
                .ForeignKey("dbo.Digimons", t => t.Digimon_Id2)
                .Index(t => t.Digimon_Id)
                .Index(t => t.Digimon_Id1)
                .Index(t => t.Digimon_Id2);
            
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
            DropForeignKey("dbo.Digivolves", "Digimon_Id2", "dbo.Digimons");
            DropForeignKey("dbo.Digivolves", "Digimon_Id1", "dbo.Digimons");
            DropForeignKey("dbo.Digivolves", "Digimon_Id", "dbo.Digimons");
            DropIndex("dbo.Skills", new[] { "Digimon_Id" });
            DropIndex("dbo.Floors", new[] { "Location_Id" });
            DropIndex("dbo.Locations", new[] { "Digimon_Id" });
            DropIndex("dbo.Locations", new[] { "Domain_Id" });
            DropIndex("dbo.Digivolves", new[] { "Digimon_Id2" });
            DropIndex("dbo.Digivolves", new[] { "Digimon_Id1" });
            DropIndex("dbo.Digivolves", new[] { "Digimon_Id" });
            DropTable("dbo.Skills");
            DropTable("dbo.Floors");
            DropTable("dbo.Domains");
            DropTable("dbo.Locations");
            DropTable("dbo.Digivolves");
            DropTable("dbo.Digimons");
        }
    }
}
