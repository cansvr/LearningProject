namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig8 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserRoles", "WRITER_CODE", "dbo.Writers");
            DropForeignKey("dbo.Users", "WRITER_CODE", "dbo.Writers");
            DropIndex("dbo.UserRoles", new[] { "WRITER_CODE" });
            DropIndex("dbo.Users", new[] { "WRITER_CODE" });
            AddColumn("dbo.Users", "USER_IMAGE", c => c.String(maxLength: 100));
            AddColumn("dbo.Users", "USER_ABOUT", c => c.String(maxLength: 100));
            AddColumn("dbo.Users", "USER_PASSWORD", c => c.String(maxLength: 100));
            AddColumn("dbo.Users", "USER_TITLE", c => c.String(maxLength: 100));
            DropColumn("dbo.UserRoles", "WRITER_CODE");
            DropColumn("dbo.Users", "WRITER_CODE");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "WRITER_CODE", c => c.Int());
            AddColumn("dbo.UserRoles", "WRITER_CODE", c => c.Int());
            DropColumn("dbo.Users", "USER_TITLE");
            DropColumn("dbo.Users", "USER_PASSWORD");
            DropColumn("dbo.Users", "USER_ABOUT");
            DropColumn("dbo.Users", "USER_IMAGE");
            CreateIndex("dbo.Users", "WRITER_CODE");
            CreateIndex("dbo.UserRoles", "WRITER_CODE");
            AddForeignKey("dbo.Users", "WRITER_CODE", "dbo.Writers", "WRITER_CODE");
            AddForeignKey("dbo.UserRoles", "WRITER_CODE", "dbo.Writers", "WRITER_CODE");
        }
    }
}
