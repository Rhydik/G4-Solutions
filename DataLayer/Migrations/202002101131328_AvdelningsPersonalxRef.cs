namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AvdelningsPersonalxRef : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AvdelningPersonal", "Avdelning_AvdelningID", "dbo.Avdelning");
            DropForeignKey("dbo.AvdelningPersonal", "Personal_PersonalID", "dbo.Personal");
            DropIndex("dbo.AvdelningPersonal", new[] { "Avdelning_AvdelningID" });
            DropIndex("dbo.AvdelningPersonal", new[] { "Personal_PersonalID" });
            CreateTable(
                "dbo.AvdelningPersonalxRef",
                c => new
                    {
                        Avdelning_AvdelningID = c.Int(nullable: false),
                        Personal_PersonalID = c.Int(nullable: false),
                        Placering = c.Int(nullable: false),
                        Avdelning_AvdelningID1 = c.Int(),
                        Personal_PersonalID1 = c.Int(),
                    })
                .PrimaryKey(t => new { t.Avdelning_AvdelningID, t.Personal_PersonalID })
                .ForeignKey("dbo.Avdelning", t => t.Avdelning_AvdelningID1)
                .ForeignKey("dbo.Personal", t => t.Personal_PersonalID1)
                .Index(t => t.Avdelning_AvdelningID1)
                .Index(t => t.Personal_PersonalID1);
            
            DropTable("dbo.AvdelningPersonal");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AvdelningPersonal",
                c => new
                    {
                        Avdelning_AvdelningID = c.Int(nullable: false),
                        Personal_PersonalID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Avdelning_AvdelningID, t.Personal_PersonalID });
            
            DropForeignKey("dbo.AvdelningPersonalxRef", "Personal_PersonalID1", "dbo.Personal");
            DropForeignKey("dbo.AvdelningPersonalxRef", "Avdelning_AvdelningID1", "dbo.Avdelning");
            DropIndex("dbo.AvdelningPersonalxRef", new[] { "Personal_PersonalID1" });
            DropIndex("dbo.AvdelningPersonalxRef", new[] { "Avdelning_AvdelningID1" });
            DropTable("dbo.AvdelningPersonalxRef");
            CreateIndex("dbo.AvdelningPersonal", "Personal_PersonalID");
            CreateIndex("dbo.AvdelningPersonal", "Avdelning_AvdelningID");
            AddForeignKey("dbo.AvdelningPersonal", "Personal_PersonalID", "dbo.Personal", "PersonalID", cascadeDelete: true);
            AddForeignKey("dbo.AvdelningPersonal", "Avdelning_AvdelningID", "dbo.Avdelning", "AvdelningID", cascadeDelete: true);
        }
    }
}
