namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_skill_value : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Profils", newName: "Profiles");
            AddColumn("dbo.Skills", "SkillValue", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Skills", "SkillValue");
            RenameTable(name: "dbo.Profiles", newName: "Profils");
        }
    }
}
