using System.ComponentModel.DataAnnotations;

namespace MobilePhoneStore.Models
{
    public class Phone
    {
        public int Id { get; set; }

        [Required]
        [StringLength(120, MinimumLength = 3, ErrorMessage = "Value must be between 3-120 characters long")]
        public string Model { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Value must be between 2-30 characters long")]
        public string OperatingSystem { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "Value must be between 0 - 1000")]
        public int AvailableQuantity { get; set; }

        [Required]
        [Range(1.0, 250000.0, ErrorMessage = "Value must be between 1 - 250000")]
        public double Price { get; set; }
        public string Photo { get; set; }
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
