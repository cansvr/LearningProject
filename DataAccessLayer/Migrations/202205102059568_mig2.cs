namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "ROLE_CODE", "dbo.UserRoles");
            DropIndex("dbo.Users", new[] { "ROLE_CODE" });
            AlterColumn("dbo.Users", "ROLE_CODE", c => c.Int());
            CreateIndex("dbo.Users", "ROLE_CODE");
            AddForeignKey("dbo.Users", "ROLE_CODE", "dbo.UserRoles", "ROLE_CODE");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "ROLE_CODE", "dbo.UserRoles");
            DropIndex("dbo.Users", new[] { "ROLE_CODE" });
            AlterColumn("dbo.Users", "ROLE_CODE", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "ROLE_CODE");
            AddForeignKey("dbo.Users", "ROLE_CODE", "dbo.UserRoles", "ROLE_CODE", cascadeDelete: true);
        }
    }
}
