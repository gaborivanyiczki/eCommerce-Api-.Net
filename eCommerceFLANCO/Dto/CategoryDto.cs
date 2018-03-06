using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eCommerceFLANCO.Models;
using Newtonsoft.Json;

namespace eCommerceFLANCO.Dto
{
    [JsonObject(IsReference = true)]
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public bool IsVisible { get; set; }

        public int? ParentId { get; set; }
        public CategoryDto Parent { get; set; }
      


        
    }
}