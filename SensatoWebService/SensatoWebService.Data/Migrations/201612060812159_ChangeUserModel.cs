namespace SensatoWebService.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeUserModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "IsDisabled", c => c.Boolean(nullable: false));
            DropColumn("dbo.Users", "IsDeleted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "IsDeleted", c => c.Boolean(nullable: false));
            DropColumn("dbo.Users", "IsDisabled");
        }
    }
}
