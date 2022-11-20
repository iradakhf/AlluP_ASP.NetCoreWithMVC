using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Allup.Models
{
    public class Slider : BaseEntity
    {
        [StringLength(800)]
        [Required]
        public string MainTitle { get; set; }
        [StringLength(800)]
        public string Subtitle { get; set; }
        [StringLength(2000)]
        public string Description { get; set; }
        [StringLength(800)]
        public string Image { get; set; }
        [StringLength(800)]
        public string PageLink { get; set; }


    }
}
