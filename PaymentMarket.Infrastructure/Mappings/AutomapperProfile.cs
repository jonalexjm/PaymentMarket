using AutoMapper;
using PaymentMarket.Core.DTOs;
using PaymentMarket.Core.Entities;

namespace PaymentMarket.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<TypeDocument, TypeDocumentDto>();
            CreateMap<TypeDocumentDto, TypeDocument>();
        }
        
    }
}