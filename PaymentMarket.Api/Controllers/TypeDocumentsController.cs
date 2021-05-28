
using System.Collections.Generic;
using AutoMapper;
using PaymentMarket.Core.DTOs;
using PaymentMarket.Core.Models.Control;
using static PaymentMarket.Core.Models.Control.Enumerations;
using static PaymentMarket.Core.Models.Control.JsonResponse;


namespace PaymentMarket.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PaymentMarket.Core.Interfaces;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class TypeDocumentsController : ControllerBase
    {
        //private readonly ITypeDocumentRepository _typeDocumentRepository;
        private readonly ITypeDocumentService _typeDocumentService ;
        private readonly IMapper _mapper;
        public TypeDocumentsController(ITypeDocumentService typeDocumentService, IMapper mapper)
        {
            _typeDocumentService = typeDocumentService;
            _mapper = mapper;
        }

        public IActionResult GetTypeDocument()
        {
            JsonResponse jsonRespuesta = new JsonResponse();
            var typedocuments = _typeDocumentService.GetTypeDocumentAll();
            var typeDocumentDto = _mapper.Map<IEnumerable<TypeDocumentDto>>(typedocuments);

            if (typeDocumentDto != null )
            {
                jsonRespuesta.Result = true;
                jsonRespuesta.Data = typeDocumentDto;
                jsonRespuesta.Control.Code = EnumToString(Http_Code.Ok);
                jsonRespuesta.Control.Message = EnumToString(ResponseMessage.Ok);
            }
        
            return Ok(jsonRespuesta);
        }

       
    }
}
