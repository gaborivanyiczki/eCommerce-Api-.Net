using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eCommerceFLANCO.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        [Display(Name = "Furnizor")]
        public string Name { get; set; }

        [Display(Name = "Descriere")]
        public string Description { get; set; }

        [Display(Name = "Adresa")]
        public string Adress { get; set; }

        [Display(Name = "Oras")]
        public string City { get; set; }

        [Display(Name = "Cod Postal")]
        public string PostCode { get; set; }

        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        public string Website { get; set; }

        public string CUI { get; set; }

        [Display(Name = "Tip Furnizor")]
        public string SupplierType { get; set; }
}
}