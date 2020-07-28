namespace PayanTextNomalize.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MemberUser", "Email2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberUser", "Email2", c => c.String());
        }
    }
}
