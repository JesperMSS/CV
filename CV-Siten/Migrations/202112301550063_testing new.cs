namespace CV_Siten.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testingnew : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Workplaces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorkplaceUserAccounts",
                c => new
                    {
                        Workplace_Id = c.Int(nullable: false),
                        UserAccount_UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Workplace_Id, t.UserAccount_UserID })
                .ForeignKey("dbo.Workplaces", t => t.Workplace_Id, cascadeDelete: true)
                .ForeignKey("dbo.UserAccounts", t => t.UserAccount_UserID, cascadeDelete: true)
                .Index(t => t.Workplace_Id)
                .Index(t => t.UserAccount_UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkplaceUserAccounts", "UserAccount_UserID", "dbo.UserAccounts");
            DropForeignKey("dbo.WorkplaceUserAccounts", "Workplace_Id", "dbo.Workplaces");
            DropIndex("dbo.WorkplaceUserAccounts", new[] { "UserAccount_UserID" });
            DropIndex("dbo.WorkplaceUserAccounts", new[] { "Workplace_Id" });
            DropTable("dbo.WorkplaceUserAccounts");
            DropTable("dbo.Workplaces");
        }
    }
}
