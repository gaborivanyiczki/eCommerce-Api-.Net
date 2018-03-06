using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace eCommerceFLANCO.Models
{
    public class Category
    {

        public int Id { get; set; }
        [Display(Name = "Categorie")]
        public string Name { get; set; }
        public string Slug { get; set; }
        [Display(Name = "Descriere")]
        public string Description { get; set; }
        [Display(Name = "Vizibil")]
        public bool IsVisible { get; set; }
        public int? ParentId { get; set; }
        public Category Parent { get; set; }

        public ICollection<Category> Children { get; set; }
        public ICollection<Product> Products { get; set; }

        
    }
}