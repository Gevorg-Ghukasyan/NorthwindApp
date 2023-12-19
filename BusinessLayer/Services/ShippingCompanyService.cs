using AutoMapper;
using BL.IServices;
using BL.Models.VM;
using Core.Entities;
using Core.Interfaces.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class ShippingCompanyService : IShippingCompanyService
    {

        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ShippingCompanyService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public void AddShippingCompany(ShippingCompanyVM shippingComapny)
        {
            _repositoryManager.ShippingCompany.Add(_mapper.Map<ShippingCompany>(shippingComapny));
        }

        public async Task AddShippingCompanyAsync(ShippingCompanyVM shippingComapny)
        {
            await _repositoryManager.ShippingCompany.AddAsync(_mapper.Map<ShippingCompany>(shippingComapny));
        }
    }
}
