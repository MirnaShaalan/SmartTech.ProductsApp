using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartTech.ProductsCatalogTask.Domain.Entities.Products
{
    public class Product : BaseEntity
    {
        [Required]
        public string Photo { get; set; }

        [Required]
        public double Price { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
