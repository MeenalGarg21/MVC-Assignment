namespace MVCAppDemoWithAuthtentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Namemebershipttypeisrequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MemberShipTypes", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MemberShipTypes", "Name", c => c.String());
        }
    }
}
