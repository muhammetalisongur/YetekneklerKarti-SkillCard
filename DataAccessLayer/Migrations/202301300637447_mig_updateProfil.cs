namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_updateProfil : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Profiles", newName: "Profils");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Profils", newName: "Profiles");
        }
    }
}
