using Microsoft.EntityFrameworkCore;
using RDRegister.API.Models;

namespace RDRegister.API.Data
{
    public class RDRegisterContext : DbContext
    {
        public RDRegisterContext(DbContextOptions<RDRegisterContext> opt) : base(opt)
        {

        }

        public DbSet<RDTrained> RDTraineds { get; set; }
        public DbSet<ECommerce> ECommerces { get; set; }
        public DbSet<SiteName> SiteNames { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<BookBank> BookBanks { get; set; }
        public DbSet<PromptPay> PromptPays { get; set; }
        public DbSet<Provinces> Provinces { get; set; }
        public DbSet<Districts> Districts { get; set; }
        public DbSet<Subdistricts> Subdistricts { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<RDTrained>()
        //        .HasIndex(r => r.OfficerId)
        //        .IsUnique();
        //}
    }
}
