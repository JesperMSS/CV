namespace CV_Siten.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserAccounts", "Password", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.UserAccounts", "ConfirmPassword", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserAccounts", "ConfirmPassword", c => c.String(nullable: false));
            AlterColumn("dbo.UserAccounts", "Password", c => c.String(nullable: false));
        }
    }
}
