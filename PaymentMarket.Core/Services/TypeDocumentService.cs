using System;
using System.Collections;
using System.Collections.Generic;
using PaymentMarket.Core.Interfaces;
using System.Threading.Tasks;
using PaymentMarket.Core.Entities;

namespace PaymentMarket.Core.Services
{
    public class TypeDocumentService : ITypeDocumentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TypeDocumentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public  IEnumerable<TypeDocument> GetTypeDocumentAll()
        {
            return _unitOfWork.typeDocumentRepository.GetAll();
        }

        public async  Task<TypeDocument> GetTypeDocument(int id)
        {
            return await _unitOfWork.typeDocumentRepository.GetById(id);
        }

        public async  Task InsertTypeDocument(TypeDocument typeDocument)
        {
            try
            {
                await _unitOfWork.typeDocumentRepository.Add(typeDocument);
                await _unitOfWork.SaveChangesAsync();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async  Task<bool> UpdateTypeDocument(TypeDocument typeDocument)
        {
            try
            {
                _unitOfWork.typeDocumentRepository.Update(typeDocument);
                await _unitOfWork.SaveChangesAsync();
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
        }

        public Task<bool> DeleteTypeDocument(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}