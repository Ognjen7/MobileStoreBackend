using AutoMapper;

namespace MobilePhoneStore.Models
{
    public class PhoneProfile : Profile
    {
        public PhoneProfile()
        {
            CreateMap<Phone, PhoneDTO>();
        }
    }
}
