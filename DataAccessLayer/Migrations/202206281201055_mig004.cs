namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig004 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AccountLevels", "_UpdateDate");
            DropColumn("dbo.Companies", "_UpdateDate");
            DropColumn("dbo.Representatives", "_UpdateDate");
            DropColumn("dbo.Groups", "_UpdateDate");
            DropColumn("dbo.Titles", "_UpdateDate");
            DropColumn("dbo.Sectors", "_UpdateDate");
            DropColumn("dbo.Customers", "_UpdateDate");
            DropColumn("dbo.Persons", "_UpdateDate");
            DropColumn("dbo.Situations", "_UpdateDate");
            DropColumn("dbo.Tags", "_UpdateDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tags", "_UpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Situations", "_UpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Persons", "_UpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "_UpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Sectors", "_UpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Titles", "_UpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Groups", "_UpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Representatives", "_UpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Companies", "_UpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AccountLevels", "_UpdateDate", c => c.DateTime(nullable: false));
        }
    }
}
