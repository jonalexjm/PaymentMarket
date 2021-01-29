namespace PaymentMarket.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PaymentMarket.Core.Interfaces;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class TypeDocumentsController : ControllerBase
    {
        private readonly ITypeDocumentRepository _typeDocumentRepository;
        public TypeDocumentsController(ITypeDocumentRepository typeDocumentRepository)
        {
            _typeDocumentRepository = typeDocumentRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetTypeDocuments()
        {
            var result = await _typeDocumentRepository.GetTypeDocuments();

            return Ok(result);
        }
    }
}
