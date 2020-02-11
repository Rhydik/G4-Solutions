namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class direktprodukt : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Direktkostnad", "Konto_KontoID", "dbo.Konto");
            DropForeignKey("dbo.KostnadsbudgetDirektkostnad", "Direktkostnad_DirektkostnadID", "dbo.Direktkostnad");
            DropForeignKey("dbo.KostnadsbudgetDirektkostnad", "Kostnadsbudget_KostnadsbudgetID", "dbo.KostnadsbudgetSet");
            DropIndex("dbo.Direktkostnad", new[] { "Konto_KontoID" });
            DropIndex("dbo.KostnadsbudgetDirektkostnad", new[] { "Direktkostnad_DirektkostnadID" });
            DropIndex("dbo.KostnadsbudgetDirektkostnad", new[] { "Kostnadsbudget_KostnadsbudgetID" });
            CreateTable(
                "dbo.DirektkostnadProdukt",
                c => new
                    {
                        Konto_KontoID = c.Int(nullable: false),
                        Produkt_ProduktID = c.String(nullable: false, maxLength: 128, unicode: false),
                        Belopp = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Produkt_ProduktID1 = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => new { t.Konto_KontoID, t.Produkt_ProduktID })
                .ForeignKey("dbo.Produkt", t => t.Produkt_ProduktID1)
                .ForeignKey("dbo.Konto", t => t.Konto_KontoID)
                .Index(t => t.Konto_KontoID)
                .Index(t => t.Produkt_ProduktID1);
            
            AlterColumn("dbo.Produkt", "ProduktID", c => c.String(nullable: false, maxLength: 128, unicode: false));
            AlterColumn("dbo.Produkt", "Namn", c => c.String());
            AddPrimaryKey("dbo.Produkt", "ProduktID");
            CreateIndex("dbo.Produkt", "ProduktID", unique: true);
            DropTable("dbo.KostnadsbudgetDirektkostnad");
            DropTable("dbo.Direktkostnad");
        }

        public override void Down()
        {
            CreateTable(
                "dbo.KostnadsbudgetDirektkostnad",
                c => new
                    {
                        Direktkostnad_DirektkostnadID = c.Int(nullable: false),
                        Kostnadsbudget_KostnadsbudgetID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Direktkostnad_DirektkostnadID, t.Kostnadsbudget_KostnadsbudgetID });
            
            CreateTable(
                "dbo.Direktkostnad",
                c => new
                    {
                        DirektkostnadID = c.Int(nullable: false, identity: true),
                        Namn = c.String(nullable: false),
                        Belopp = c.Decimal(nullable: false, precision: 18, scale: 0),
                        Konto_KontoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DirektkostnadID);
            
            DropForeignKey("dbo.DirektkostnadProdukt", "Konto_KontoID", "dbo.Konto");
            DropForeignKey("dbo.DirektkostnadProdukt", "Produkt_ProduktID1", "dbo.Produkt");
            DropIndex("dbo.Produkt", new[] { "ProduktID" });
            DropIndex("dbo.DirektkostnadProdukt", new[] { "Produkt_ProduktID1" });
            DropIndex("dbo.DirektkostnadProdukt", new[] { "Konto_KontoID" });
            AlterColumn("dbo.Produkt", "Namn", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Produkt", "ProduktID", c => c.String(nullable: false, maxLength: 128));
            DropTable("dbo.DirektkostnadProdukt");
            AddPrimaryKey("dbo.Produkt", new[] { "ProduktID", "Namn", "Produktkategori_ProduktkategoriID", "Produktgrupp_ProduktgruppID", "Avdelning_AvdelningID" });
            CreateIndex("dbo.KostnadsbudgetDirektkostnad", "Kostnadsbudget_KostnadsbudgetID");
            CreateIndex("dbo.KostnadsbudgetDirektkostnad", "Direktkostnad_DirektkostnadID");
            CreateIndex("dbo.Direktkostnad", "Konto_KontoID");
            AddForeignKey("dbo.KostnadsbudgetDirektkostnad", "Kostnadsbudget_KostnadsbudgetID", "dbo.KostnadsbudgetSet", "KostnadsbudgetID", cascadeDelete: true);
            AddForeignKey("dbo.KostnadsbudgetDirektkostnad", "Direktkostnad_DirektkostnadID", "dbo.Direktkostnad", "DirektkostnadID", cascadeDelete: true);
            AddForeignKey("dbo.Direktkostnad", "Konto_KontoID", "dbo.Konto", "KontoID");
        }
    }
}
