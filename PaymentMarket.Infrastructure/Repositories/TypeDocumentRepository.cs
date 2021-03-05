using PaymentMarket.Core.Entities;
using PaymentMarket.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PaymentMarket.Infrastructure.Data;

namespace PaymentMarket.Infrastructure.Repositories
{
    using System.Threading.Tasks;
    public class TypeDocumentRepository : BaseRepository<TypeDocument>, ITypeDocumentRepository
    { 
        public TypeDocumentRepository(PaymentMarketContext context) : base(context){}
     

        
    }
}
