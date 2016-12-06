namespace SensatoWebService.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hives", "IsRemoved", c => c.Boolean(nullable: false));
            DropColumn("dbo.Hives", "IsDeleted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hives", "IsDeleted", c => c.Boolean(nullable: false));
            DropColumn("dbo.Hives", "IsRemoved");
        }
    }
}
