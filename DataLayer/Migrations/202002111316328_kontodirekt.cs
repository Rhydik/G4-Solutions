namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kontodirekt : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DirektkostnadAktivitet", "Direktkostnad_DirektkostnadID1", "dbo.Direktkostnad");
            DropIndex("dbo.DirektkostnadAktivitet", new[] { "Direktkostnad_DirektkostnadID1" });
            DropPrimaryKey("dbo.DirektkostnadAktivitet");
            AddColumn("dbo.DirektkostnadAktivitet", "Konto_KontoID", c => c.Int(nullable: false));
            AddColumn("dbo.DirektkostnadAktivitet", "Konto_KontoID1", c => c.Int());
            AddPrimaryKey("dbo.DirektkostnadAktivitet", new[] { "Konto_KontoID", "Aktivitet_AktivitetID" });
            CreateIndex("dbo.DirektkostnadAktivitet", "Konto_KontoID1");
            AddForeignKey("dbo.DirektkostnadAktivitet", "Konto_KontoID1", "dbo.Konto", "KontoID");
            DropColumn("dbo.DirektkostnadAktivitet", "Direktkostnad_DirektkostnadID");
            DropColumn("dbo.DirektkostnadAktivitet", "Direktkostnad_DirektkostnadID1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DirektkostnadAktivitet", "Direktkostnad_DirektkostnadID1", c => c.Int());
            AddColumn("dbo.DirektkostnadAktivitet", "Direktkostnad_DirektkostnadID", c => c.Int(nullable: false));
            DropForeignKey("dbo.DirektkostnadAktivitet", "Konto_KontoID1", "dbo.Konto");
            DropIndex("dbo.DirektkostnadAktivitet", new[] { "Konto_KontoID1" });
            DropPrimaryKey("dbo.DirektkostnadAktivitet");
            DropColumn("dbo.DirektkostnadAktivitet", "Konto_KontoID1");
            DropColumn("dbo.DirektkostnadAktivitet", "Konto_KontoID");
            AddPrimaryKey("dbo.DirektkostnadAktivitet", new[] { "Direktkostnad_DirektkostnadID", "Aktivitet_AktivitetID" });
            CreateIndex("dbo.DirektkostnadAktivitet", "Direktkostnad_DirektkostnadID1");
            AddForeignKey("dbo.DirektkostnadAktivitet", "Direktkostnad_DirektkostnadID1", "dbo.Direktkostnad", "DirektkostnadID");
        }
    }
}
