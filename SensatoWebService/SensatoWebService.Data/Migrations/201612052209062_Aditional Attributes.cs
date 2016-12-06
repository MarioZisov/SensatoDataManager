namespace SensatoWebService.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AditionalAttributes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hives", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 30));
            CreateIndex("dbo.Hives", "Name", unique: true);
            CreateIndex("dbo.Users", "Username", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Hives", new[] { "Name" });
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.Hives", "Name", c => c.String(nullable: false));
        }
    }
}
