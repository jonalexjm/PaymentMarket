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
        
        [HttpGet]
        public IActionResult Create()
        {
            var typeDocument = new TypeDocument();
            return PartialView("_TypeDocumentModelPartial", typeDocument);
        }
        
        
        [HttpPost]
        public async  Task<IActionResult> Create(TypeDocument typeDocument)
        {
            if (ModelState.IsValid)
            {
                try
                {
                        await _typeDocumentService.InsertTypeDocument(typeDocument);
                        return PartialView("_TypeDocumentModelPartial", typeDocument);

                }
                catch (Exception e)
                {
                    ModelState.AddModelError(string.Empty, e.Message);
                }
            }
            return LocalRedirect("/TypeDocuments/Index");
        }
        
        
        public async  Task<IActionResult> Edit(int id)
        {
            try
            {
                var typeDocumentResult = await _typeDocumentService.GetTypeDocument(id);
                return PartialView("_EditTypeDocumentModelPartial", typeDocumentResult);

            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
            }
            return LocalRedirect("/TypeDocuments/Index");
        }
        
        [HttpPost]
        public async  Task<IActionResult> Edit(TypeDocument typeDocument)
        {
            try
            {
                var typeDocumentResult = await _typeDocumentService.UpdateTypeDocument(typeDocument);
                return PartialView("_EditTypeDocumentModelPartial", typeDocument);

            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
            }
            return LocalRedirect("/TypeDocuments/Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var typeDocumentResult = await _typeDocumentService.GetTypeDocument(id);
                return PartialView("_DeleteTypeDocumentModelPartial", typeDocumentResult);

            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
            }
            return LocalRedirect("/TypeDocuments/Index");
            
        }
        
        [HttpPost]
        public async  Task<IActionResult> Delete(TypeDocument typeDocument)
        {
            try
            {
                var typeDocumentResult = await _typeDocumentService.DeleteTypeDocument(typeDocument.Id);
                return PartialView("_DeleteTypeDocumentModelPartial", typeDocument);

            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
            }
            return LocalRedirect("/TypeDocuments/Index");
        }
        
    }
}
