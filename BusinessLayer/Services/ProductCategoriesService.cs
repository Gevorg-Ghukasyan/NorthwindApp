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
    public class ProductCategoriesService : IProductCategoriesService
    {

        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ProductCategoriesService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public void AddProductCategories(ProductCategoriesVM productCategory)
        {
            _repositoryManager.ProductCategories.Add(_mapper.Map<ProductCategories>(productCategory));
        }

        public async Task AddProductCategoriesAsync(ProductCategoriesVM productCategory)
        {
            await _repositoryManager.ProductCategories.AddAsync(_mapper.Map<ProductCategories>(productCategory));
        }

        public async Task<ProductCategoriesVM> GetProductCategory(int id)
        {
            var result = await _repositoryManager.Products.GetAsync(id);
            return _mapper.Map<ProductCategoriesVM>(result);
        }
    }
}
