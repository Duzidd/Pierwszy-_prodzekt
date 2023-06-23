using System.ComponentModel.DataAnnotations;

namespace Pierwszy__prodzekt.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Pole nazwa jest wymagane!")]
        [MaxLength(24)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }

    }
}
