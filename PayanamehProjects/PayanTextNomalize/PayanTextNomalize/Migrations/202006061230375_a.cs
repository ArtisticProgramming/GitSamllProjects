namespace PayanTextNomalize.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberUser", "Email2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberUser", "Email2");
        }
    }
}
