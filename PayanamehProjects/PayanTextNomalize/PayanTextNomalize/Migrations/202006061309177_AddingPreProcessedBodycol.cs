namespace PayanTextNomalize.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPreProcessedBodycol : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberComment_W", "PreProcessedBody", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberComment_W", "PreProcessedBody");
        }
    }
}
