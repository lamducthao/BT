namespace BT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_Person : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        PassWord = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        PersonName = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Persons");
            DropTable("dbo.Account");
        }
    }
}
