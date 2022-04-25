namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserRoles", "WRITER_CODE", "dbo.Writers");
            DropIndex("dbo.UserRoles", new[] { "WRITER_CODE" });
            AddColumn("dbo.Users", "WRITER_CODE", c => c.Int());
            AlterColumn("dbo.UserRoles", "WRITER_CODE", c => c.Int());
            CreateIndex("dbo.UserRoles", "WRITER_CODE");
            CreateIndex("dbo.Users", "WRITER_CODE");
            AddForeignKey("dbo.Users", "WRITER_CODE", "dbo.Writers", "WRITER_CODE");
            AddForeignKey("dbo.UserRoles", "WRITER_CODE", "dbo.Writers", "WRITER_CODE");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "WRITER_CODE", "dbo.Writers");
            DropForeignKey("dbo.Users", "WRITER_CODE", "dbo.Writers");
            DropIndex("dbo.Users", new[] { "WRITER_CODE" });
            DropIndex("dbo.UserRoles", new[] { "WRITER_CODE" });
            AlterColumn("dbo.UserRoles", "WRITER_CODE", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "WRITER_CODE");
            CreateIndex("dbo.UserRoles", "WRITER_CODE");
            AddForeignKey("dbo.UserRoles", "WRITER_CODE", "dbo.Writers", "WRITER_CODE", cascadeDelete: true);
        }
    }
}
