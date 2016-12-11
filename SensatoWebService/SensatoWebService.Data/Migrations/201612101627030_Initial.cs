namespace SensatoWebService.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Frames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Position = c.Int(nullable: false),
                        HiveId = c.Int(),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hives", t => t.HiveId)
                .Index(t => t.HiveId);
            
            CreateTable(
                "dbo.Hives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        IsRemoved = c.Boolean(nullable: false),
                        UserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => new { t.Name, t.UserId }, unique: true, name: "HiveNameUserIdUnq");
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false),
                        IsLogged = c.Boolean(nullable: false),
                        IsDisabled = c.Boolean(nullable: false),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Username, unique: true);
            
            CreateTable(
                "dbo.Measurments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstSensorTemp = c.Single(nullable: false),
                        SecondSensorTemp = c.Single(nullable: false),
                        ThirdSensorTemp = c.Single(nullable: false),
                        DateTimeOfMeasurment = c.DateTime(nullable: false),
                        FrameId = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Frames", t => t.FrameId)
                .Index(t => t.FrameId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Measurments", "FrameId", "dbo.Frames");
            DropForeignKey("dbo.Hives", "UserId", "dbo.Users");
            DropForeignKey("dbo.Frames", "HiveId", "dbo.Hives");
            DropIndex("dbo.Measurments", new[] { "FrameId" });
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Hives", "HiveNameUserIdUnq");
            DropIndex("dbo.Frames", new[] { "HiveId" });
            DropTable("dbo.Measurments");
            DropTable("dbo.Users");
            DropTable("dbo.Hives");
            DropTable("dbo.Frames");
        }
    }
}
