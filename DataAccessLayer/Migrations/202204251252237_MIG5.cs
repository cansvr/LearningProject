namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MIG5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WRITER_TITLE", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WRITER_TITLE");
        }
    }
}
