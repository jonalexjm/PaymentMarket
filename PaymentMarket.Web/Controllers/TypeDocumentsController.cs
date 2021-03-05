using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using PaymentMarket.Core.Entities;
using PaymentMarket.Core.Interfaces;

namespace PaymentMarket.Web.Controllers
{
    public class TypeDocumentsController : Controller
    {
        private readonly ITypeDocumentService _typeDocumentService;
        
        public TypeDocumentsController(ITypeDocumentService typeDocumentService)
        {
            _typeDocumentService = typeDocumentService;
        }

        public IActionResult Index()
        {
            return View( _typeDocumentService.GetTypeDocumentAll() );
        }
        
        public async  Task<IActionResult> Create(TypeDocument typeDocument)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Console.WriteLine(typeDocument.Description);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
