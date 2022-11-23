using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;    

namespace Allup.Models
{
    public class Tag : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }

        public IEnumerable<ProductTag> ProductTags { get; set; }

    }
}
