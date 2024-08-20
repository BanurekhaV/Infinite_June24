using Caching.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Caching.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CacheController : ControllerBase
    {
       private readonly LocationRepository _locationRepository;

        public CacheController(LocationRepository repo)
        {
            _locationRepository = repo;
        }

        [HttpGet("countries")]
        public async Task<IActionResult>GetCountries()
        {
            var countries = await _locationRepository.GetCountries();
            return Ok(countries);
        }

        [HttpGet("states/{countryid}")]

        public  async Task<IActionResult>GetStates(int countryid)
        {
            var states = await _locationRepository.GetStates(countryid);    
            return Ok(states);
        }

        [HttpGet("cities/{stateid}")]
        public async Task<IActionResult> GetCities(int stateid)
        {
            var cities = await  _locationRepository.GetCities(stateid);
            return Ok(cities);
        }
    }

}
