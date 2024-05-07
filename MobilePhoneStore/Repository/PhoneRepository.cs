using Microsoft.EntityFrameworkCore;
using MobilePhoneStore.Interfaces;
using MobilePhoneStore.Models;
using System.Linq;

namespace MobilePhoneStore.Repository
{
    public class PhoneRepository : IPhoneRepository
    {
        private readonly AppDbContext _context;

        public PhoneRepository(AppDbContext context)
        {
            this._context = context;
        }

        public void Add(Phone phone)
        {
            _context.Add(phone);
            _context.SaveChanges();
        }

        public void Delete(Phone phone)
        {
            _context.Remove(phone);
            _context.SaveChanges();
        }

        public IQueryable<Phone> GetAll()
        {
            return _context.Phones.Include(p => p.Manufacturer).OrderBy(s => s.Manufacturer.Name);
        }

        public Phone GetById(int id)
        {
            return _context.Phones.Include(p => p.Manufacturer).FirstOrDefault(t => t.Id == id);
        }

        public void Update(Phone phone)
        {
            _context.Entry(phone).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public IQueryable<Phone> GetByName(string value)
        {
            return _context.Phones.Include(p => p.Manufacturer).Where(t => t.Model.Contains(value) || t.Manufacturer.Name.Contains(value)).OrderByDescending(t => t.Price);
        }

        public IQueryable<Phone> GetAllByPrice(int minPrice, int maxPrice)
        {
            return _context.Phones.Where(t => t.Price >= minPrice && t.Price <= maxPrice).OrderByDescending(t => t.Price);
        }
    }
}
