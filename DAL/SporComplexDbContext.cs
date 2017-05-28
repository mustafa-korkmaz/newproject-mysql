using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.IO;
using System.Linq;
using System.Reflection;
using DAL.Configuration;
using DAL.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL
{
    public class SporComplexDbContext : IdentityDbContext<ApplicationUser>
    {
        static SporComplexDbContext()
        {
            Database.SetInitializer(new MySqlInitializer());
        }

        public SporComplexDbContext()
            : base("DefaultConnection")
        {
#if DEBUG
            this.Database.Log = LogQuery; // print sql in debug mode
#endif
        }

        public DbSet<RequestLog> RequestLogs { get; set; }
        public DbSet<SporComplexException> Exceptions { get; set; }
        public DbSet<UserRequest> UserRequests { get; set; }
        public DbSet<UserSetting> UserSettings { get; set; }

        public static SporComplexDbContext Create()
        {
            return new SporComplexDbContext();
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : EntityBase
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
           .Where(type => !string.IsNullOrEmpty(type.Namespace))
           .Where(type => type.BaseType != null && type.BaseType.IsGenericType
                && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            base.OnModelCreating(modelBuilder);

            ////one-to-many 
            //modelBuilder.Entity<MarketUser>()
            //            .HasRequired<Market>(m => m.Market)
            //            .WithMany(m => m.MarketUsers)
            //            .HasForeignKey(m => m.MarketId);

            //modelBuilder.Entity<MarketUserIntegration>()
            //         .HasRequired<MarketUser>(m => m.MarketUser)
            //         .WithMany(m => m.MarketUserIntegrations)
            //         .HasForeignKey(m => m.MarketUserId);

            //modelBuilder.Entity<MarketUserIntegration>()
            //      .HasRequired<Integration>(m => m.Integration)
            //      .WithMany(m => m.MarketUserIntegrations)
            //      .HasForeignKey(m => m.IntegrationId);

            //modelBuilder.Entity<IntegrationDetail>()
            //    .HasRequired<Integration>(m => m.Integration)
            //    .WithMany(m => m.IntegrationDetails)
            //    .HasForeignKey(m => m.IntegrationId);

        }

        private static void LogQuery(string sql)
        {
            // This text is always added, making the file longer over time  if it is not deleted.
            using (StreamWriter sw = File.AppendText(@"D:\\QueryLogs_SporComplex.sql"))
            {
                if (sql.Length > 5)
                    if (sql.Substring(4, 2).ToLower() == "ed") // opened or closed db string
                    {
                        sql = "-- " + sql;
                    }
                sw.WriteLine(sql);
            }
        }

    }
}
