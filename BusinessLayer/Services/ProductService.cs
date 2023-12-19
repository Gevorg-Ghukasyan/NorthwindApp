using AutoMapper;
using BL.IServices;
using BL.Models.VM;
using Core.Entities;
using Core.Exceptions;
using Core.Interfaces.IRepository;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ProductService(IRepositoryManager repositoryManager , IMapper mapper) 
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

/*        public ProductVM GetProduct(int id)
        {
            var result = _repositoryManager.Products.Get(id);

            if(result == null) 
            {
                var errorMessage = $"Product with ID {id} not found.";
                Console.WriteLine(errorMessage);

                throw new NotFoundException(errorMessage);
            }


            return _mapper.Map<ProductVM>(result);
        }*/

        public ProductVM GetProduct(int id)
        {
            var product =_repositoryManager.Products.Get(id);

            return new ProductVM
            {
                Id = product.Id,
                ProductCode = product.ProductCode,
                ProductName = product.ProductName,
                ProductDescription = product.ProductDescription,
                UnitPrice = product.UnitPrice,
                Discontinued = product.Discontinued,
                ProductCategoryImage = product.ProductCategory.ProductCategoryImage,
                ProductCategoryName = product.ProductCategory.ProductCategoryName,
                ProductCategoriesId = product.ProductCategory.Id


            };

        }

        public async Task<ProductVM> GetProductAsync(int id)
        {
            var result = await _repositoryManager.Products.GetAsync(id);
            if (result == null)
            {
                var errorMessage = $"Product with ID {id} not found.";
                Console.WriteLine(errorMessage);

                throw new NotFoundException(errorMessage);
            }
            
            return _mapper.Map<ProductVM>(result);
        }

        public IEnumerable<ProductVM> GetAll()
        {
            var result = _repositoryManager.Products.GetAll();
            if (result == null)
            {
                var errorMessage = $"Products not found.";
                Console.WriteLine(errorMessage);

                throw new NotFoundException(errorMessage);
            }
            return _mapper.Map<IEnumerable<ProductVM>>(result);
        }

        public async Task<IEnumerable<ProductVM>> GetAllAsync()
        {
            var result = await _repositoryManager.Products.GetAllAsync();
            if (result == null)
            {
                var errorMessage = $"Products not found.";
                Console.WriteLine(errorMessage);
                
                throw new NotFoundException(errorMessage);
            }
            return _mapper.Map<IEnumerable<ProductVM>>(result);
        }


        public int GetTotalStockQuantityOnHand()
        {
            var result = _repositoryManager.Products.GetTotalStockQuantityOnHand();
            return result;
        }

        public async Task<int> GetTotalStockQuantityOnHandAsync()
        {
            var result = await _repositoryManager.Products.GetTotalStockQuantityOnHandAsync();
            return result;
        }

        public void AddProduct(ProductVM product)
        {
            var productDTO = _mapper.Map<Product>(product);
            _repositoryManager.Products.Add(productDTO);
        }

        public async Task AddProductAsync(ProductVM product)
        {
            var productDTO = _mapper.Map<Product>(product);
            await _repositoryManager.Products.AddAsync(productDTO);
        }

        public void AddRangeProduct(IEnumerable<ProductVM> products)
        {
            var productDTOs = _mapper.Map<IEnumerable<Product>>(products);
            _repositoryManager.Products.AddRange(productDTOs);
        }

        public async Task AddRangeProductAsync(IEnumerable<ProductVM> products)
        {
            var productDTOs = _mapper.Map<Product>(products);
            await _repositoryManager.Products.AddAsync(productDTOs);
        }

        public void DeleteProductById(int productId)
        {
            _repositoryManager.Products.DeleteById(productId);
        }

        public async Task DeleteProductByIdAsync(int productId)
        {
            await _repositoryManager.Products.DeleteByIdAsync(productId);
        }

        public ProductVM FindDefaultProduct(params object?[]? keyValues)
        {
            var result = _repositoryManager.Products.FindDefault(keyValues);
            return _mapper.Map<ProductVM>(result);
        }

        public async Task<ProductVM> FindDefaultProductAsync(params object?[]? keyValues)
        {
            var result = await _repositoryManager.Products.FindDefaultAsync(keyValues);
            return _mapper.Map<ProductVM>(result);
        }

        public IEnumerable<ProductVM> FindProduct(Expression<Func<ProductVM, bool>> predicate)
        {

            var result =_repositoryManager.Products.Find(_mapper.Map<Expression<Func<Product, bool>>>(predicate));
            return _mapper.Map<IEnumerable<ProductVM>>(result);
        }

        public async Task<IEnumerable<ProductVM>> FindProductAsync(Expression<Func<ProductVM, bool>> predicate)
        {
            var result = await _repositoryManager.Products.FindAsync(_mapper.Map<Expression<Func<Product, bool>>>(predicate));
            return _mapper.Map<IEnumerable<ProductVM>>(result);
        }

        public async Task<IEnumerable<ProductVM>> FindProductsByVendorAsync(int vendorId)
        {
            var result = await _repositoryManager.Products.FindProductsByVendorAsync(vendorId);
            return _mapper.Map<IEnumerable<ProductVM>>(result);

        }

        public async Task<IEnumerable<ProductVM>> FindProductsInCompletedOrdersAsync()
        {
            var result = await _repositoryManager.Products.FindProductsInCompletedOrdersAsync();
            return _mapper.Map<IEnumerable<ProductVM>>(result);
        }

        public async Task<IEnumerable<ProductVM>> FindProductsInOrdersAsync()
        {
            var result = await _repositoryManager.Products.FindProductsInOrdersAsync();
            return _mapper.Map<IEnumerable<ProductVM>>(result);
        }

        public ProductVM FirstOrDefaultProduct()
        {
            var result = _repositoryManager.Products.FirstOrDefault();
            return _mapper.Map<ProductVM>(result);
        }



        public void RemoveProduct(ProductVM product)
        {
            var productDTO = _mapper.Map<Product>(product);
            _repositoryManager.Products.Remove(productDTO);
        }

        public async Task RemoveProductAsync(ProductVM product)
        {
            var productDTO =  _mapper.Map<Product>(product);
            await _repositoryManager.Products.RemoveAsync(productDTO);
        }

        public void RemoveRangeProduct(IEnumerable<ProductVM> products)
        {
            var productDTOs = _mapper.Map<IEnumerable<Product>>(products);
            _repositoryManager.Products.RemoveRange(productDTOs);
        }

        public async Task RemoveRangeProductAsync(IEnumerable<ProductVM> products)
        {
            var productDTOs = _mapper.Map<IEnumerable<Product>>(products);
            await _repositoryManager.Products.RemoveRangeAsync(productDTOs);
        }

        public ProductVM SingleOrDefaultProduct(Expression<Func<ProductVM, bool>> predicate)
        {
            var result = _repositoryManager.Products.SingleOrDefault(_mapper.Map<Expression<Func<Product, bool>>>(predicate));
            return _mapper.Map<ProductVM>(result);
        }

        public void UpdateProduct(ProductVM product)
        {
            _repositoryManager.Products.Update(_mapper.Map<Product>(product));
        }

        public async Task UpdateProductAsync(ProductVM product)
        {
           await _repositoryManager.Products.UpdateAsync(_mapper.Map<Product>(product));
        }

        public void UpdateProductRange(IEnumerable<ProductVM> products)
        {
            _repositoryManager.Products.UpdateRange(_mapper.Map<IEnumerable<Product>>(products));
        }

        public async Task UpdateProductRangeAsync(IEnumerable<ProductVM> products)
        {
           await _repositoryManager.Products.UpdateRangeAsync(_mapper.Map<IEnumerable<Product>>(products));
        }
    }
}
