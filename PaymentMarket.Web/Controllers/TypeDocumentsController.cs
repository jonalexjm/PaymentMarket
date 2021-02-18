using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using PaymentMarket.Core.Interfaces;

namespace PaymentMarket.Web.Controllers
{
    public class TypeDocumentsController : Controller
    {
        private readonly ITypeDocumentRepository _typeDocumentRepository;
        public TypeDocumentsController(ITypeDocumentRepository typeDocumentRepository)
        {
            _typeDocumentRepository = typeDocumentRepository;
        }

        public async  Task<IActionResult> Index()
        {
           
            return View(await _typeDocumentRepository.GetTypeDocuments());
        }
    }
}
