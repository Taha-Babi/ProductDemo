using System.ComponentModel.DataAnnotations;

namespace ProductDemo.Models
{
    public class Product
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? EnName { get; set; }
        [Required]
        [MaxLength(100)]
        public string? ArName { get; set; }
        [Required]
        [MaxLength(100)]
        public string? FrName { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "the length must not exceed 100 character")]
        public string VariantNameEn { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "يجب ألا يتجاوز الطول 100 حرف")]
        public string VariantNameAr { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "la longueur ne doit pas dépasser 100 caractères")]
        public string VariantNameFr { get; set; }
        public List<ProductVariants> productVariants { get; set; }

    }
}
