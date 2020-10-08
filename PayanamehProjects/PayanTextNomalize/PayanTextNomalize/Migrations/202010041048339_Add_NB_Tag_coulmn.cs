namespace PayanTextNomalize.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_NB_Tag_coulmn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberComment_W", "NB_Tag", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberComment_W", "NB_Tag");
        }
    }
}
