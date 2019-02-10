namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_cat_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CatId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CatId);
            
            AddColumn("dbo.Products", "CatId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "CatId");
            AddForeignKey("dbo.Products", "CatId", "dbo.Categories", "CatId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CatId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CatId" });
            DropColumn("dbo.Products", "CatId");
            DropTable("dbo.Categories");
        }
    }
}
