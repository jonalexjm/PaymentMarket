namespace PaymentMarket.Core.Interfaces
{
    using PaymentMarket.Core.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ITypeDocumentRepository
    {
        Task<IEnumerable<TypeDocument>> GetTypeDocuments();

    }
}
