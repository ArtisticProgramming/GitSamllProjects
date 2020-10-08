namespace PayanTextNomalize.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_SVM_Tag_coulmn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberComment_W", "SVM_Tag", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberComment_W", "SVM_Tag");
        }
    }
}
