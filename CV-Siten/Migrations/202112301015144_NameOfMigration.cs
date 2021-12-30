namespace CV_Siten.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameOfMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projekts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        ProjektManager = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserAccounts", t => t.ProjektManager, cascadeDelete: true)
                .Index(t => t.ProjektManager);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projekts", "ProjektManager", "dbo.UserAccounts");
            DropIndex("dbo.Projekts", new[] { "ProjektManager" });
            DropTable("dbo.Projekts");
        }
    }
}
