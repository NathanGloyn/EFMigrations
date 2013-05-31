namespace MigrationsDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPublishDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "DatePublished", c => c.DateTime(nullable: false, defaultValue: DateTime.Now));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "DatePublished");
        }
    }
}
