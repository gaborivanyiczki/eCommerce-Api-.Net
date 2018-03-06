using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eCommerceFLANCO.Models;

namespace eCommerceFLANCO.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public int UnitsInStock { get; set; }
        public decimal Price { get; set; }
        public decimal ActualPrice { get; set; }
        public bool IsVisible { get; set; }
        public DateTime AddedTime { get; set; }

        public int SupplierId { get; set; }
        public SupplierDto Supplier { get; set; }
        public int CategoryId { get; set; }
        public CategoryDto Category { get; set; }
        public int BrandId { get; set; }
        public BrandDto Brand { get; set; }

        public ICollection<AttributesProduct> Attributes { get; set; }
    }
}