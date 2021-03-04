namespace MVCArticleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AttemptNewDB : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.LocationArticle1", newName: "LocationArticle");
            DropTable("dbo.LocationArticle");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.LocationArticle",
                c => new
                    {
                        Location_Id = c.Int(nullable: false),
                        Article_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Location_Id, t.Article_Id });
            
            RenameTable(name: "dbo.LocationArticle", newName: "LocationArticle1");
        }
    }
}
