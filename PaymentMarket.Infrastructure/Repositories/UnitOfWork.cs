using System.Threading.Tasks;
using PaymentMarket.Core.Entities;
using PaymentMarket.Core.Interfaces;
using PaymentMarket.Infrastructure.Data;

namespace PaymentMarket.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PaymentMarketContext _context;
        private readonly IRepository<TypeDocument> _typeDocumentRepository;
        
        public UnitOfWork(PaymentMarketContext context)
        {
            _context = context;
                
        }
        
        
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public IRepository<TypeDocument> typeDocumentRepository =>
            _typeDocumentRepository ?? new BaseRepository<TypeDocument>(_context);

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}