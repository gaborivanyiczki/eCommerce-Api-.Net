using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eCommerceFLANCO.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [Display(Name =  "Brand")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}