namespace PayanTextNomalize.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingSomeCoulmns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberComment_W", "Body_After_Standardization", c => c.String());
            AddColumn("dbo.MemberComment_W", "Body_After_Cleaning", c => c.String());
            AddColumn("dbo.MemberComment_W", "Body_After_Steaming", c => c.String());
            AddColumn("dbo.MemberComment_W", "Body_After_RemovingStopWords", c => c.String());
            DropColumn("dbo.MemberComment_W", "PreProcessBody");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberComment_W", "PreProcessBody", c => c.String());
            DropColumn("dbo.MemberComment_W", "Body_After_RemovingStopWords");
            DropColumn("dbo.MemberComment_W", "Body_After_Steaming");
            DropColumn("dbo.MemberComment_W", "Body_After_Cleaning");
            DropColumn("dbo.MemberComment_W", "Body_After_Standardization");
        }
    }
}
