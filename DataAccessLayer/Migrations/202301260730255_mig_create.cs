namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Profils",
                c => new
                    {
                        ProfilID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 50),
                        SurName = c.String(maxLength: 50),
                        Message = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ProfilID);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        SkillID = c.Int(nullable: false, identity: true),
                        SkillName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.SkillID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Skills");
            DropTable("dbo.Profils");
        }
    }
}
