namespace eUniverzitet.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicijalna : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "KorisnikId", "dbo.Korisniks");
            DropForeignKey("dbo.Zaposleniks", "KorisnikId", "dbo.Korisniks");
            DropIndex("dbo.Zaposleniks", "Index2");
            DropIndex("dbo.Students", "Index2");
            RenameIndex(table: "dbo.Zaposleniks", name: "Index1", newName: "IX_KorisnikId");
            RenameIndex(table: "dbo.Students", name: "Index1", newName: "IX_KorisnikId");
            AddColumn("dbo.Zaposleniks", "Korisnik_Id", c => c.Int());
            AddColumn("dbo.Students", "Korisnik_Id", c => c.Int());
            CreateIndex("dbo.Zaposleniks", "Korisnik_Id");
            CreateIndex("dbo.Students", "Korisnik_Id");
            AddForeignKey("dbo.Students", "Korisnik_Id", "dbo.Korisniks", "Id");
            AddForeignKey("dbo.Zaposleniks", "Korisnik_Id", "dbo.Korisniks", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Zaposleniks", "Korisnik_Id", "dbo.Korisniks");
            DropForeignKey("dbo.Students", "Korisnik_Id", "dbo.Korisniks");
            DropIndex("dbo.Students", new[] { "Korisnik_Id" });
            DropIndex("dbo.Zaposleniks", new[] { "Korisnik_Id" });
            DropColumn("dbo.Students", "Korisnik_Id");
            DropColumn("dbo.Zaposleniks", "Korisnik_Id");
            RenameIndex(table: "dbo.Students", name: "IX_KorisnikId", newName: "Index1");
            RenameIndex(table: "dbo.Zaposleniks", name: "IX_KorisnikId", newName: "Index1");
            CreateIndex("dbo.Students", "KorisnikId", unique: true, name: "Index2");
            CreateIndex("dbo.Zaposleniks", "KorisnikId", unique: true, name: "Index2");
            AddForeignKey("dbo.Zaposleniks", "KorisnikId", "dbo.Korisniks", "Id");
            AddForeignKey("dbo.Students", "KorisnikId", "dbo.Korisniks", "Id");
        }
    }
}
