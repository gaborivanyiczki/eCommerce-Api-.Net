using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eCommerceFLANCO.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Nume Produs")]
        public string Name { get; set; }

        [Display(Name = "Descriere")]
        public string Description { get; set; }

        public string Slug { get; set; }

        [Display(Name = "Stoc Actual")]
        public int UnitsInStock { get; set; }

        [Display(Name = "Pret")]
        public decimal Price { get; set; }

        [Display(Name = "Pret actual")]
        public decimal ActualPrice { get; set; }

        [Display(Name = "Vizibil")]
        public bool IsVisible { get; set; }

        [Display(Name = "Adaugat in")]
        public DateTime AddedTime { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public ICollection<AttributesProduct> Attributes { get; set; }
    }
}