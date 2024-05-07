using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobilePhoneStore.Interfaces;
using MobilePhoneStore.Models;
using MobilePhoneStore.Repository;
using System.Collections.Generic;
using System.Linq;

namespace MobilePhoneStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhonesController : ControllerBase
    {
        private readonly IPhoneRepository _phoneRepository;
        private readonly IMapper _mapper;

        public PhonesController(IPhoneRepository phoneRepository, IMapper mapper)
        {
            _phoneRepository = phoneRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetPhones()
        {
            return Ok(_phoneRepository.GetAll().ProjectTo<PhoneDTO>(_mapper.ConfigurationProvider).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetPhone(int id)
        {
            var phone = _phoneRepository.GetById(id);

            if (phone == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PhoneDTO>(phone));
        }

        [HttpPost]
        public IActionResult PostPhone(Phone phone)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _phoneRepository.Add(phone);
            return CreatedAtAction("GetPhone", new { id = phone.Id }, _mapper.Map<PhoneDTO>(phone));
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePhone(int id)
        {
            var phone = _phoneRepository.GetById(id);
            if (phone == null)
            {
                return NotFound();
            }

            _phoneRepository.Delete(phone);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult PutPhone(int id, Phone phone)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != phone.Id)
            {
                return BadRequest();
            }

            try
            {
                _phoneRepository.Update(phone);
            }
            catch
            {
                return BadRequest();
            }

            return Ok(phone);
        }

        [HttpGet("search")]
        public IActionResult GetByType([FromQuery] string value)
        {
            var phones = _phoneRepository.GetByName(value);

            if (phones == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IEnumerable<Phone>>(phones));
        }

        [HttpPost]
        [Route("/api/searchByPrice")]
        public IActionResult Search(SearchDTO dto)
        {
            if (dto.Minimum < 0 || dto.Maximum < 0 || dto.Minimum > dto.Maximum)
            {
                return BadRequest();
            }
            return Ok(_phoneRepository.GetAllByPrice(dto.Minimum, dto.Maximum).ProjectTo<PhoneDTO>(_mapper.ConfigurationProvider).ToList());
        }
    }
}
