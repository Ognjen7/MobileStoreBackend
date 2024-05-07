using Microsoft.EntityFrameworkCore;
using MobilePhoneStore.Interfaces;
using MobilePhoneStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace MobilePhoneStore.Repository
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        private readonly AppDbContext _context;

        public ManufacturerRepository(AppDbContext context)
        {
            this._context = context;
        }

        public void Add(Manufacturer manufacturer)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Manufacturer> GetAll()
        {
            return _context.Manufacturers.OrderBy(p => p.Name);
        }

        public Manufacturer GetById(int id)
        {
            return _context.Manufacturers.FirstOrDefault(p => p.Id == id);
        }

        public void Update(Manufacturer manufacturer)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ManufacturerStatisticsDTO> GetAllByAveragePrice(int treshold)
        {
            return _context.Phones.Include(p => p.Manufacturer).GroupBy(p => p.ManufacturerId).Select(group =>
               new ManufacturerStatisticsDTO
               {
                   ManufacturerId = group.Key,
                   ManufacturerName = _context.Manufacturers.Where(manufacturer => manufacturer.Id == group.Key).Select(manufacturer => manufacturer.Name).Single(),
                   PhoneAveragePrice = (int)group.Average(t => t.Price),
                   CheapestPhonePrice = (int)group.Min(t => t.Price)
               })
               .Where(stats => stats.PhoneAveragePrice < treshold)
               .OrderBy(stats => stats.ManufacturerName)
               .ToList();
        }

        public IEnumerable<ManufacturerStatisticsCountDTO> GetAllWithTotalCount()
        {
            return _context.Phones.Include(p => p.Manufacturer).GroupBy(p => p.ManufacturerId).Select(group =>
               new ManufacturerStatisticsCountDTO
               {
                   ManufacturerId = group.Key,
                   ManufacturerName = _context.Manufacturers.Where(manufacturer => manufacturer.Id == group.Key).Select(manufacturer => manufacturer.Name).Single(),
                   TotalPhoneModelsCount = group.Count(),
                   TotalAvailableCount = group.Sum(t => t.AvailableQuantity)
               })
               .OrderByDescending(stats => stats.TotalAvailableCount)
               .ToList();
        }

        public IQueryable<Manufacturer> GetByName(string name)
        {
            return _context.Manufacturers.Where(p => p.Name == name).OrderBy(p => p.Country).ThenByDescending(p => p.Name);
        }

        public void Delete(Manufacturer manufacturer)
        {
            throw new System.NotImplementedException();
        }
    }
}
