
using System;
using System.Collections.Generic;
using AutoMapper;
using PaymentMarket.Core.DTOs;
using PaymentMarket.Core.Entities;
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
            try
            {
                var typedocuments =  _typeDocumentService.GetTypeDocumentAll();
                var typeDocumentDto = _mapper.Map<IEnumerable<TypeDocumentDto>>(typedocuments);
                jsonRespuesta.Result = true;
                jsonRespuesta.Control.Code = EnumToString(Http_Code.Ok);
                
                if (typeDocumentDto != null )
                {
                    jsonRespuesta.Data = typeDocumentDto; 
                    jsonRespuesta.Control.Message = EnumToString(ResponseMessage.Ok);
                    return Ok(jsonRespuesta);
                }
                return Ok(jsonRespuesta);
            }
            catch (Exception e)
            {
                jsonRespuesta.Control.Message = e.Message;
                return BadRequest(jsonRespuesta);
            }
        }
        
        [HttpPost]
        public async Task<IActionResult> PostTypeDocument(TypeDocumentDto typeDocumentDto)
        {
            JsonResponse jsonRespuesta = new JsonResponse();
            try
            {
                var typeDocument = _mapper.Map<TypeDocument>(typeDocumentDto);
                await _typeDocumentService.InsertTypeDocument(typeDocument);
                typeDocumentDto = _mapper.Map<TypeDocumentDto>(typeDocument);
                jsonRespuesta.Result = true;
                jsonRespuesta.Data = typeDocumentDto;
                jsonRespuesta.Control.Code = EnumToString(Http_Code.Created);
                jsonRespuesta.Control.Message = EnumToString(ResponseMessage.Created);
                
                return Ok(jsonRespuesta);
            }
            catch (Exception e)
            {
                jsonRespuesta.Control.Message = e.Message;
                return BadRequest(jsonRespuesta);
            }
        }

       
    }
}
