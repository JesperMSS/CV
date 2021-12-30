namespace CV_Siten.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Competences",
                c => new
                    {
                        CompetenceID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CompetenceID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Competences");
        }
    }
}
