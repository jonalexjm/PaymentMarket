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
        private readonly ITypeDocumentRepository _typeDocumentRepository;
        public TypeDocumentsController(ITypeDocumentRepository typeDocumentRepository)
        {
            _typeDocumentRepository = typeDocumentRepository;
        }

        [HttpGet]
        //[MapToApiVersion("1.0")]
        public async Task<IActionResult> GetTypeDocuments()
        {
            var result = await _typeDocumentRepository.GetTypeDocuments();

            return Ok(result);
        }
    }
}
