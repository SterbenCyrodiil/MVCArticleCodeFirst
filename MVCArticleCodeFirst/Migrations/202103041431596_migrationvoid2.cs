namespace MVCArticleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationvoid2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Location", new[] { "Article_Id1" });
            DropColumn("dbo.Location", "Article_Id");
            RenameColumn(table: "dbo.Location", name: "Article_Id1", newName: "Article_Id");
            AlterColumn("dbo.Location", "Article_Id", c => c.Int());
            CreateIndex("dbo.Location", "Article_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Location", new[] { "Article_Id" });
            AlterColumn("dbo.Location", "Article_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Location", name: "Article_Id", newName: "Article_Id1");
            AddColumn("dbo.Location", "Article_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Location", "Article_Id1");
        }
    }
}
