using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Persistence
{
    public class QLTVContext : DbContext
    {
        public QLTVContext(DbContextOptions<QLTVContext> options) : base(options)
        {
        }

        public DbSet<Sach> Sachs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}