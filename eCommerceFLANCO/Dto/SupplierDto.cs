using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerceFLANCO.Dto
{
    public class SupplierDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string CUI { get; set; }
        public string SupplierType { get; set; }
    }
}