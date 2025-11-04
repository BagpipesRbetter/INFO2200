using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_M05_Assignment_Start
{
    [Table("JellyBellyTable")]
    public class JellyBelly
    {
        [Key]
        public int JellyBellyId { get; set; }

        [StringLength(50)]
        public string jellyBellyFlavor { get; set; }

        [StringLength(50)]
        public string category { get; set; }
    }
}
