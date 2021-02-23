namespace Kafe21.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Kafe21.Data.KafeVeri>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Kafe21.Data.KafeVeri context)
        {
            if (!context.Urunler.Any())
            {
                context.Urunler.Add(new Urun() { UrunAd = "fanta", BirimFiyat = 5.99m });
                context.Urunler.Add(new Urun() { UrunAd = "tonik", BirimFiyat = 8.99m });
            }
        }
    }
}
