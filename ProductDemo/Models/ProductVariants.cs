using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProductDemo.Models
{
    public class ProductVariants
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string VariantValue { get; set; }
        [Required]
        public int ProductID { get; set; }
        [JsonIgnore]
        public Product? Product{ get; set; }
    }
}
