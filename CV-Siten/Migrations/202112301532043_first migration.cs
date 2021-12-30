namespace CV_Siten.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigration : DbMigration
    {
        public override void Up()
        {
           
            
 
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "ProjektManager", "dbo.UserAccounts");
            DropIndex("dbo.Projects", new[] { "ProjektManager" });
            DropTable("dbo.UserAccounts");
            DropTable("dbo.Projects");
            DropTable("dbo.Competences");
        }
    }
}
