namespace BT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_Employee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persons", "Conpany", c => c.String());
            AddColumn("dbo.Persons", "Adđress", c => c.String());
            AddColumn("dbo.Persons", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Persons", "Discriminator");
            DropColumn("dbo.Persons", "Adđress");
            DropColumn("dbo.Persons", "Conpany");
        }
    }
}
