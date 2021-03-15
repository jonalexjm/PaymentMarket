using System.Collections.Generic;
using PaymentMarket.Core.Entities;

namespace PaymentMarket.Core.Interfaces
{
    using System.Threading.Tasks;

    public interface ITypeDocumentService
    {
        IEnumerable<TypeDocument> GetTypeDocumentAll();
        Task<TypeDocument> GetTypeDocument(int id);
        Task InsertTypeDocument(TypeDocument typeDocument);
        Task<bool> UpdateTypeDocument(TypeDocument typeDocument);
        Task<bool> DeleteTypeDocument(int id);
    }
}