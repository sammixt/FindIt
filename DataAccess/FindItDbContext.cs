using System;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class FindItDbContext : DbContext
    {
        public DbSet<Merchant> Mechants { get; set; }
        public DbSet<LocalGovt> LocalGovts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceSetup> ServiceSetups { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<VerifiedInfo> VerifiedInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:brainballerserver.database.windows.net,1433;
                                        Initial Catalog=Findit;
                                        Persist Security Info=False;
                                        User ID=brainballeradmin;
                                        Password=Br@inB@ller;
                                        MultipleActiveResultSets=False;
                                        Encrypt=True;TrustServerCertificate=False;
                                        Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<State>().HasData(SeedState.AddSeedState());
            modelBuilder.Entity<LocalGovt>().HasData(SeedLocalGovt.AddSeedLocalGovt());
        }
    }
}

