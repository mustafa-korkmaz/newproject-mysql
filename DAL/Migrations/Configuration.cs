using System.Data.Entity.Migrations;
using DAL.Models;

namespace DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SporComplexDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());
        }

        protected override void Seed(SporComplexDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //to avoid creating duplicate seed data. E.g.

            //context.Markets.AddOrUpdate(
            //  p => p.Name,
            //  new Market { Name = "N11.com" },
            //  new Market { Name = "GittiGidiyor.com" },
            //  new Market { Name = "Hepsiburada.com" }
            //);

            //context.MarketUsers.AddOrUpdate(
            // p => new { p.Name, p.MarketId, p.LoginName, p.Token },
            // new MarketUser { Name = "N11-testUser", MarketId = 1, LoginName = "N11-testUser-loginName", Token = "N11-testUser-token" },
            // new MarketUser { Name = "N11-testUser-1", MarketId = 1, LoginName = "N11-testUser-1-loginName", Token = "N11-testUser-1-token" },
            // new MarketUser { Name = "GG-testUser", MarketId = 2, LoginName = "GG-testUser-loginName", Token = "GG-testUser-token" }
            //);

            //context.Integrations.AddOrUpdate(
            //  p => new { p.Name, p.Type },
            //  new Integration { Name = "harun-kirkikoglu", Type = IntegrationType.Opencart },
            //  new Integration { Name = "local", Type = IntegrationType.Opencart }
            //);

            //context.MarketUserIntegrations.AddOrUpdate(
            // p => new { p.Desc, p.IntegrationId, p.MarketUserId },
            // new MarketUserIntegration { Desc = "harunk.com sitesine ait n11 entegrasyonu", IntegrationId = 1, MarketUserId = 1 },
            // new MarketUserIntegration { Desc = "harunk.com sitesine ait gg entegrasyonu", IntegrationId = 1, MarketUserId = 3 }
            //);

            //context.IntegrationDetails.AddOrUpdate(
            //  p => new { p.IntegrationId, p.Url, p.ExportType },
            //  new IntegrationDetail { IntegrationId = 1, Url = "http://localhost:8080/opencart/index.php?route=export/product", ExportType = ExportType.Product },
            //  new IntegrationDetail { IntegrationId = 1, Url = "http://localhost:8080/opencart/index.php?route=export/category", ExportType = ExportType.Category }
            //  );

        }
    }
}
