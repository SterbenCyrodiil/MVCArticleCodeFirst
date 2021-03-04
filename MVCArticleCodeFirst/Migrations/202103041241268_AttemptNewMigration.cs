namespace MVCArticleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AttemptNewMigration : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Location", new[] { "Article" });
            DropIndex("dbo.Location", new[] { "ArticleId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Location", "ArticleId", unique: true);
            CreateIndex("dbo.Location", "Article", unique: true);
        }
    }
}
