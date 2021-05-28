using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PaymentMarket.Core.Entities;

namespace PaymentMarket.Infrastructure.Data
{
    public class PaymentMarketContext : DbContext
    {
        public PaymentMarketContext()
        {
            
        }

        public PaymentMarketContext(DbContextOptions<PaymentMarketContext> options) : base(options)
        {
            
        }
        
        public virtual DbSet<TypeDocument> TypeDocuments { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}