namespace MVCArticleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyWayRelationsAreHeld : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Location", "Article_Id", "dbo.Article");
            DropIndex("dbo.Location", new[] { "Article_Id" });
            CreateTable(
                "dbo.LocationArticle",
                c => new
                    {
                        Location_Id = c.Int(nullable: false),
                        Article_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Location_Id, t.Article_Id })
                .ForeignKey("dbo.Location", t => t.Location_Id, cascadeDelete: true)
                .ForeignKey("dbo.Article", t => t.Article_Id, cascadeDelete: true)
                .Index(t => t.Location_Id)
                .Index(t => t.Article_Id);
            
            AddColumn("dbo.Location", "ArticleId", c => c.Int(nullable: false));
            DropColumn("dbo.Location", "Article_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Location", "Article_Id", c => c.Int());
            DropForeignKey("dbo.LocationArticle", "Article_Id", "dbo.Article");
            DropForeignKey("dbo.LocationArticle", "Location_Id", "dbo.Location");
            DropIndex("dbo.LocationArticle", new[] { "Article_Id" });
            DropIndex("dbo.LocationArticle", new[] { "Location_Id" });
            DropColumn("dbo.Location", "ArticleId");
            DropTable("dbo.LocationArticle");
            CreateIndex("dbo.Location", "Article_Id");
            AddForeignKey("dbo.Location", "Article_Id", "dbo.Article", "Id");
        }
    }
}
