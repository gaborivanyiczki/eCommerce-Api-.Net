namespace eCommerceFLANCO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCategories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Slug = c.String(),
                        Description = c.String(),
                        IsVisible = c.Boolean(nullable: false),
                        ParentId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.ParentId)
                .Index(t => t.ParentId);
            
          
        }
        
        public override void Down()
        {
            
            DropIndex("dbo.Categories", new[] { "ParentId" });
           
            DropTable("dbo.Categories");
           
        }
    }
}
