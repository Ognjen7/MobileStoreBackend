using MobilePhoneStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace MobilePhoneStore.Interfaces
{
    public interface IManufacturerRepository
    {
        IQueryable<Manufacturer> GetAll();
        Manufacturer GetById(int id);
        void Add(Manufacturer manufacturer);
        void Update(Manufacturer manufacturer);
        void Delete(Manufacturer manufacturer);
        IEnumerable<ManufacturerStatisticsDTO> GetAllByAveragePrice(int threshold);
        IEnumerable<ManufacturerStatisticsCountDTO> GetAllWithTotalCount();
        IQueryable<Manufacturer> GetByName(string name);
    }
}
