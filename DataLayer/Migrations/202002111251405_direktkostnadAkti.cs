namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class direktkostnadAkti : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DirektkostnadAktivitet",
                c => new
                    {
                        Direktkostnad_DirektkostnadID = c.Int(nullable: false),
                        Aktivitet_AktivitetID = c.String(nullable: false, maxLength: 128, unicode: false),
                        Belopp = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aktivitet_AktivitetID1 = c.String(maxLength: 128, unicode: false),
                        Direktkostnad_DirektkostnadID1 = c.Int(),
                    })
                .PrimaryKey(t => new { t.Direktkostnad_DirektkostnadID, t.Aktivitet_AktivitetID })
                .ForeignKey("dbo.Aktivitet", t => t.Aktivitet_AktivitetID1)
                .ForeignKey("dbo.Direktkostnad", t => t.Direktkostnad_DirektkostnadID1)
                .Index(t => t.Aktivitet_AktivitetID1)
                .Index(t => t.Direktkostnad_DirektkostnadID1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DirektkostnadAktivitet", "Direktkostnad_DirektkostnadID1", "dbo.Direktkostnad");
            DropForeignKey("dbo.DirektkostnadAktivitet", "Aktivitet_AktivitetID1", "dbo.Aktivitet");
            DropIndex("dbo.DirektkostnadAktivitet", new[] { "Direktkostnad_DirektkostnadID1" });
            DropIndex("dbo.DirektkostnadAktivitet", new[] { "Aktivitet_AktivitetID1" });
            DropTable("dbo.DirektkostnadAktivitet");
        }
    }
}
