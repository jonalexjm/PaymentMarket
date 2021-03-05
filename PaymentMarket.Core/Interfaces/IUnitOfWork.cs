using System;
using System.Threading.Tasks;
using PaymentMarket.Core.Entities;

namespace PaymentMarket.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TypeDocument> typeDocumentRepository { get; }
        
        void SaveChanges();

        Task SaveChangesAsync();
    }
}