namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migdeleteimage : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Profils", "ProfilImage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Profils", "ProfilImage", c => c.String(maxLength: 250));
        }
    }
}
