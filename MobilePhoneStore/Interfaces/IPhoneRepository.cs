using MobilePhoneStore.Models;
using System.Linq;

namespace MobilePhoneStore.Interfaces
{
    public interface IPhoneRepository
    {
        IQueryable<Phone> GetAll();
        Phone GetById(int id);
        void Add(Phone phone);
        void Update(Phone phone);
        void Delete(Phone phone);
        IQueryable<Phone> GetByName(string value);
        IQueryable<Phone> GetAllByPrice(int maxPrice, int minPrice);
    }
}
