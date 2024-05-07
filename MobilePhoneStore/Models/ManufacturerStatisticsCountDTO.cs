namespace MobilePhoneStore.Models
{
    public class ManufacturerStatisticsCountDTO
    {
        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        public int TotalPhoneModelsCount { get; set; }
        public int TotalAvailableCount { get; set; }
    }
}
