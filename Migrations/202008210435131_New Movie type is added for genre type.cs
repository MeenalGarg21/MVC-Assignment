namespace MVCAppDemoWithAuthtentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMovietypeisaddedforgenretype : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "MovieType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "MovieType");
        }
    }
}
