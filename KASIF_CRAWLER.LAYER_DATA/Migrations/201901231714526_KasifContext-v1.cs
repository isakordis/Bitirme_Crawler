namespace KASIF_CRAWLER.LAYER_DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KasifContextv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kasif_Arama_Analiz_TB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SiteId = c.Int(nullable: false),
                        Arama_Tarihi = c.DateTime(nullable: false),
                        Arayan_Id = c.Guid(nullable: false),
                        Tiklama_Tarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kasif_Kullanicilar_TB", t => t.Arayan_Id, cascadeDelete: true)
                .ForeignKey("dbo.Kasif_Kayitli_Siteler_TB", t => t.SiteId, cascadeDelete: true)
                .Index(t => t.SiteId)
                .Index(t => t.Arayan_Id);
            
            CreateTable(
                "dbo.Kasif_Kullanicilar_TB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Kullanici_Adi = c.String(),
                        Sifre = c.String(),
                        AdSoyad = c.String(),
                        Kayit_Tarihi = c.DateTime(nullable: false),
                        Email = c.String(),
                        Cinsiyet = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kasif_Kayitli_Siteler_TB",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Site_Host = c.String(),
                        Kayit_Tarihi = c.DateTime(nullable: false),
                        Son_Indexlenme_Tarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kasif_Alinan_Indexler_TB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SiteId = c.Int(nullable: false),
                        Index_Tarih = c.DateTime(nullable: false),
                        Index_Baslik = c.String(),
                        Index_Aciklama = c.String(),
                        Index_Tip = c.String(),
                        Index_Resim = c.String(),
                        Index_Data_Tipi = c.String(),
                        Index_Guncelleme_Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kasif_Kayitli_Siteler_TB", t => t.SiteId, cascadeDelete: true)
                .Index(t => t.SiteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kasif_Alinan_Indexler_TB", "SiteId", "dbo.Kasif_Kayitli_Siteler_TB");
            DropForeignKey("dbo.Kasif_Arama_Analiz_TB", "SiteId", "dbo.Kasif_Kayitli_Siteler_TB");
            DropForeignKey("dbo.Kasif_Arama_Analiz_TB", "Arayan_Id", "dbo.Kasif_Kullanicilar_TB");
            DropIndex("dbo.Kasif_Alinan_Indexler_TB", new[] { "SiteId" });
            DropIndex("dbo.Kasif_Arama_Analiz_TB", new[] { "Arayan_Id" });
            DropIndex("dbo.Kasif_Arama_Analiz_TB", new[] { "SiteId" });
            DropTable("dbo.Kasif_Alinan_Indexler_TB");
            DropTable("dbo.Kasif_Kayitli_Siteler_TB");
            DropTable("dbo.Kasif_Kullanicilar_TB");
            DropTable("dbo.Kasif_Arama_Analiz_TB");
        }
    }
}
