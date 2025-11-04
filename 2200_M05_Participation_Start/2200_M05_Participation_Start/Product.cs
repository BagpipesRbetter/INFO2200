namespace _2200_M05_Participation_Start
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [StringLength(5)]
        public string Product_Number { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public int Units_On_Hand { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        public string Category { get; set; }
    }
}
