namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WRITER_IMAGE", c => c.String(maxLength: 100));
            AddColumn("dbo.Writers", "WRITER_ABOUT", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WRITER_ABOUT");
            DropColumn("dbo.Writers", "WRITER_IMAGE");
        }
    }
}
