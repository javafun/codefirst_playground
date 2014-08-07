namespace CodeFirst_VS2014.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLastModified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "LastModified", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "LastModified");
        }
    }
}
