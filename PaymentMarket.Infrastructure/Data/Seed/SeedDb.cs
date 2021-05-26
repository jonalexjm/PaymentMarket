using PaymentMarket.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMarket.Infrastructure.Data.Seed
{
    public class SeedDb
    {
        private readonly PaymentMarketContext context;
        private Random random;

        public SeedDb(PaymentMarketContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();
            
            if (!this.context.TypeDocuments.Any())
            {
                this.AddTypeUsers("Cedula");
                this.AddTypeUsers("Cedula de Extranjeria");
                this.AddTypeUsers("Tarjeta de identidad");
               

                await this.context.SaveChangesAsync();
            }
            
        }
        
        private void AddTypeUsers(
            string Description
        )
        {
            this.context.TypeDocuments.Add(new TypeDocument()
            {
                Description = Description
            });

        }

    }
}