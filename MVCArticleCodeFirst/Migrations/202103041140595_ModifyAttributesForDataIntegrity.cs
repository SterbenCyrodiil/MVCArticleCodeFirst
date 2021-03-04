namespace MVCArticleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyAttributesForDataIntegrity : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Location", "Article", c => c.String(nullable: false, maxLength: 450));
            CreateIndex("dbo.Location", "Article", unique: true);
            CreateIndex("dbo.Location", "ArticleId", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Location", new[] { "ArticleId" });
            DropIndex("dbo.Location", new[] { "Article" });
            AlterColumn("dbo.Location", "Article", c => c.String(nullable: false));
        }
    }
}
