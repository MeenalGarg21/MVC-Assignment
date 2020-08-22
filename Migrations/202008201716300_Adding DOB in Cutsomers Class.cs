namespace MVCAppDemoWithAuthtentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDOBinCutsomersClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DOB", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DOB");
        }
    }
}
