namespace Simple.Core.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Password", c => c.String());
            AddColumn("dbo.UserAddresses", "IsActive", c => c.Boolean(nullable: false));
            DropColumn("dbo.UserAddresses", "MyPropeIsActive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserAddresses", "MyPropeIsActive", c => c.Boolean(nullable: false));
            DropColumn("dbo.UserAddresses", "IsActive");
            DropColumn("dbo.Users", "Password");
        }
    }
}
