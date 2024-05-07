using System.ComponentModel.DataAnnotations;

namespace MobilePhoneStore.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(120, ErrorMessage = "Value must be a maximum of 120 characters long")]
        public string Name { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Value must be between 2-60 characters long")]
        public string Country { get; set; }
    }
}
