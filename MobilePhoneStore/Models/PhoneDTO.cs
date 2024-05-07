using System.ComponentModel.DataAnnotations;

namespace MobilePhoneStore.Models
{
    public class PhoneDTO
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string OperatingSystem { get; set; }
        public int AvailableQuantity { get; set; }
        public double Price { get; set; }
        public string Photo { get; set; }
        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
    }
}
