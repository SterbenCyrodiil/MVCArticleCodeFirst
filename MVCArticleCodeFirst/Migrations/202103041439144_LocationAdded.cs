namespace MVCArticleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LocationAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Article = c.String(nullable: false),
                        Article_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Article", t => t.Article_Id, cascadeDelete: true)
                .Index(t => t.Article_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Location", "Article_Id", "dbo.Article");
            DropIndex("dbo.Location", new[] { "Article_Id" });
            DropTable("dbo.Location");
        }
    }
}
