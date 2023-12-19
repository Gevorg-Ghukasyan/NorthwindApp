using AutoMapper;
using BL.IServices;
using BL.Models.VM;
using Core.Entities;
using Core.Interfaces.IRepository;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class ProductCompanyService : IProductCompanyService
    {

        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ProductCompanyService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public void AddProductCompany(ProductCompanyVM productComapny)
        {
            _repositoryManager.ShippingCompany.Add(_mapper.Map<ShippingCompany>(productComapny));
        }

        public async Task AddProductCompanyAsync(ProductCompanyVM productComapny)
        {
            await _repositoryManager.ShippingCompany.AddAsync(_mapper.Map<ShippingCompany>(productComapny));
        }
    }
}
