using PaymentMarket.Core.Entities;
using PaymentMarket.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PaymentMarket.Infrastructure.Repositories
{
    using System.Threading.Tasks;
    public class TypeDocumentRepository : ITypeDocumentRepository
    {
        public async Task<IEnumerable<TypeDocument>> GetTypeDocuments()
        {
            var typeDocumentsTest = Enumerable.Range(1, 10).Select(x => new TypeDocument
            {
                Id = x,
                Description = $"Descripcion {x}"
            });
            await Task.Delay(10);

            return typeDocumentsTest;
        }
    }
}
