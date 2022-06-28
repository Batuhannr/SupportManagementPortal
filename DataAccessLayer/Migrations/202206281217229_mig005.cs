namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig005 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AccountLevels", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Companies", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Representatives", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Groups", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Titles", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sectors", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Persons", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Situations", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tags", "Deleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tags", "Deleted");
            DropColumn("dbo.Situations", "Deleted");
            DropColumn("dbo.Persons", "Deleted");
            DropColumn("dbo.Customers", "Deleted");
            DropColumn("dbo.Sectors", "Deleted");
            DropColumn("dbo.Titles", "Deleted");
            DropColumn("dbo.Groups", "Deleted");
            DropColumn("dbo.Representatives", "Deleted");
            DropColumn("dbo.Companies", "Deleted");
            DropColumn("dbo.AccountLevels", "Deleted");
        }
    }
}
