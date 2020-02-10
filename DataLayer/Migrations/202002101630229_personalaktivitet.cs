namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class personalaktivitet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PersonalAktivitet",
                c => new
                    {
                        Personal_PersonalID = c.Int(nullable: false),
                        Aktivitet_AktivitetID = c.String(nullable: false, maxLength: 128),
                        Placeringsandel = c.Int(nullable: false),
                        Personal_PersonalID1 = c.Int(),
                    })
                .PrimaryKey(t => new { t.Personal_PersonalID, t.Aktivitet_AktivitetID })
                .ForeignKey("dbo.Personal", t => t.Personal_PersonalID1)
                .Index(t => t.Personal_PersonalID1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonalAktivitet", "Personal_PersonalID1", "dbo.Personal");
            DropIndex("dbo.PersonalAktivitet", new[] { "Personal_PersonalID1" });
            DropTable("dbo.PersonalAktivitet");
        }
    }
}
