using SmartTech.ProductsCatalogTask.Domain.Entities.Products;
using SmartTech.ProductsCatalogTask.Repository.Interfaces;
using SmartTech.ProductsCatalogTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartTech.ProductsCatalogTask.Services.Services
{
    public class ProductService : IProductService
    {
        private IRepository<Product> productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<Product> GetProducts()
        {
            return productRepository.GetAll();
        }

        public Product GetProductById(int id)
        {
            return productRepository.Get(id);
        }

        public void Insert(Product product)
        {
            
            productRepository.Insert(product);
        }

        public void Update(Product product)
        {
            productRepository.Update(product);
        }

        public void Delete(int id)
        {
            Product product = GetProductById(id);
            productRepository.Remove(product);
            productRepository.SaveChanges();
        }


    }
}
