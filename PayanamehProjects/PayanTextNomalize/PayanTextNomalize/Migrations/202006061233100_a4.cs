namespace PayanTextNomalize.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberComment_W", "PreProcessBody", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberComment_W", "PreProcessBody");
        }
    }
}
