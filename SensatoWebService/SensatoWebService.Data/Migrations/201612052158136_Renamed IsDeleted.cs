namespace SensatoWebService.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamedIsDeleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Frames", "IsRemoved", c => c.Boolean(nullable: false));
            DropColumn("dbo.Frames", "IsDeleted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Frames", "IsDeleted", c => c.Boolean(nullable: false));
            DropColumn("dbo.Frames", "IsRemoved");
        }
    }
}
