namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteAdmin : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Admins");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        AdminMail = c.String(maxLength: 50),
                        AdminPassword = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.AdminID);
            
        }
    }
}
