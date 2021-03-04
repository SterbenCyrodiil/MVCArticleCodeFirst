namespace MVCArticleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Location", "Article");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Location", "Article", c => c.String(nullable: false));
        }
    }
}
