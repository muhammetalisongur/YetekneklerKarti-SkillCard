namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_profilImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profils", "ProfilImage", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profils", "ProfilImage");
        }
    }
}
