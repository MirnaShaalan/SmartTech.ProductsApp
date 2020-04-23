using SmartTech.ProductsCatalogTask.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartTech.ProductsCatalogTask.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();

        Product GetProductById(int productId);

        void Insert(Product product);

        void Update(Product product);

        void Delete(int productId);

    }
}
