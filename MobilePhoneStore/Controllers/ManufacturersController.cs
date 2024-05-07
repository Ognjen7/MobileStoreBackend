using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobilePhoneStore.Interfaces;
using System.Linq;

namespace MobilePhoneStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturersController : ControllerBase
    {
        private readonly IManufacturerRepository _manufacturerRepository;

        public ManufacturersController(IManufacturerRepository manufacturerRepository)
        {
            _manufacturerRepository = manufacturerRepository;
        }

        [HttpGet]
        public IActionResult GetManufacturers()
        {
            return Ok(_manufacturerRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetManufacturer(int id)
        {
            var manufacturer = _manufacturerRepository.GetById(id);

            if (manufacturer == null)
            {
                return NotFound();
            }

            return Ok(manufacturer);
        }

        [HttpGet]
        [Route("/api/info")]
        public IActionResult GetAllByAveragePrice([FromQuery] int treshold)
        {
            return Ok(_manufacturerRepository.GetAllByAveragePrice(treshold).ToList());
        }

        [HttpGet]
        [Route("/api/status")]
        public IActionResult GetAllWithTotalApsCount()
        {
            return Ok(_manufacturerRepository.GetAllWithTotalCount().ToList());
        }

        [HttpGet("search")]
        public IActionResult GetByAdress([FromQuery] string name)
        {
            var manufacturers = _manufacturerRepository.GetByName(name);

            if (manufacturers == null)
            {
                return NotFound();
            }

            return Ok(manufacturers);
        }
    }
}
