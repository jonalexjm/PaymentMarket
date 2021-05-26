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
        public TypeDocumentsController(ITypeDocumentService typeDocumentService)
        {
            _typeDocumentService = typeDocumentService;
        }
        
        public IActionResult GetTypeDocument()
        {
            var typedocuments = _typeDocumentService.GetTypeDocumentAll();
            

            return Ok(typedocuments);
        }

       
    }
}
