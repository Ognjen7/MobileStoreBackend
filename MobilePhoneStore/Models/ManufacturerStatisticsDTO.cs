namespace MobilePhoneStore.Models
{
    public class ManufacturerStatisticsDTO
    {
        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        public int PhoneAveragePrice { get; set; }
        public int CheapestPhonePrice { get; set; }
    }
}
