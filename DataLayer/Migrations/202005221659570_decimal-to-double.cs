namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class decimaltodouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AvdelningPersonalxRef", "Placering", c => c.Double(nullable: false));
            AlterColumn("dbo.Personal", "Sysselsättningsgrad", c => c.Double(nullable: false));
            AlterColumn("dbo.Personal", "Vakansavdrag", c => c.Double(nullable: false));
            AlterColumn("dbo.Personal", "Årsarbete", c => c.Double(nullable: false));
            AlterColumn("dbo.KostnadsbudgetSet", "Summering", c => c.Double(nullable: false));
            AlterColumn("dbo.PersonalAktivitet", "Placeringsandel", c => c.Double(nullable: false));
            AlterColumn("dbo.PersonalProdukt", "Placeringsandel", c => c.Double(nullable: false));
            AlterColumn("dbo.DirektkostnadAktivitet", "Belopp", c => c.Double(nullable: false));
            AlterColumn("dbo.DirektkostnadProdukt", "Belopp", c => c.Double(nullable: false));
            AlterColumn("dbo.schablonkostnad", "Belopp", c => c.Double(nullable: false));
            AlterColumn("dbo.Intäktsbudget", "Avtal", c => c.Double(nullable: false));
            AlterColumn("dbo.Intäktsbudget", "Tillägg", c => c.Double(nullable: false));
            AlterColumn("dbo.Intäktsbudget", "Budget", c => c.Double(nullable: false));
            AlterColumn("dbo.Prognos", "Belopp", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Prognos", "Belopp", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            AlterColumn("dbo.Intäktsbudget", "Budget", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            AlterColumn("dbo.Intäktsbudget", "Tillägg", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            AlterColumn("dbo.Intäktsbudget", "Avtal", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            AlterColumn("dbo.schablonkostnad", "Belopp", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            AlterColumn("dbo.DirektkostnadProdukt", "Belopp", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.DirektkostnadAktivitet", "Belopp", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PersonalProdukt", "Placeringsandel", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PersonalAktivitet", "Placeringsandel", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.KostnadsbudgetSet", "Summering", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            AlterColumn("dbo.Personal", "Årsarbete", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Personal", "Vakansavdrag", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            AlterColumn("dbo.Personal", "Sysselsättningsgrad", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            AlterColumn("dbo.AvdelningPersonalxRef", "Placering", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
