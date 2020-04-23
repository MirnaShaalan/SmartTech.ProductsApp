using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartTech.ProductsCatalogTask.Domain.Entities.Products;
using SmartTech.ProductsCatalogTask.Services.Interfaces;

namespace SmartTech.ProductsCatalogTask.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        [HttpGet]
        [Route("Get")]
        public IActionResult GetProducts()
        {
            var products = productService.GetProducts();
            return Ok(products);
        }

        [HttpGet]
        [Route("GetById")]
        public IActionResult GetProductById(int id)
        {
            var product = productService.GetProductById(id);
            return Ok(product);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddProduct([FromBody] Product product)
        {

            try
            {
                productService.Insert(product);
                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Route("Edit")]
        public IActionResult EditProduct(Product product)
        {
            try
            {
                productService.Update(product);
                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("Delete")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                productService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}