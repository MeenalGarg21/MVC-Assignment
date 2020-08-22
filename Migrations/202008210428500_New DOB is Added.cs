namespace MVCAppDemoWithAuthtentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDOBisAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DateOfBirth", c => c.DateTime(nullable: false));
            DropColumn("dbo.Customers", "DOB");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "DOB", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "DateOfBirth");
        }
    }
}
