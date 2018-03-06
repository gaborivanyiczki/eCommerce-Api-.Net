using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerceFLANCO.Models
{
    public class AttributesProduct
    {
        public int Id { get; set; }
        public int AttributeId { get; set; }
        public Attribute Attribute { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}