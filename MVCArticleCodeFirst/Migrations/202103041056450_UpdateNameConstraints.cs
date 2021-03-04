namespace MVCArticleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNameConstraints : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Article", "Name", c => c.String(nullable: false, maxLength: 450));
            CreateIndex("dbo.Article", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Article", new[] { "Name" });
            AlterColumn("dbo.Article", "Name", c => c.String(nullable: false));
        }
    }
}
