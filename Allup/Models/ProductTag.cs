using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Allup.Models
{
    public class ProductTag : BaseEntity
    {
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
