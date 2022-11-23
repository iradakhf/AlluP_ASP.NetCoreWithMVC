using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Allup.Models
{
    public class Brand : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
