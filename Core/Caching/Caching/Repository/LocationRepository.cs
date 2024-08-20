using Caching.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace Caching.Repository
{
    public class LocationRepository
    {
        private readonly IMemoryCache _memoryCache;
        private readonly ApplicationDbContext _context;
        private readonly TimeSpan _cacheexpiry = TimeSpan.FromMinutes(30);

        public LocationRepository(IMemoryCache memoryCache, ApplicationDbContext context)
        {
            _memoryCache = memoryCache;
            _context = context;
        }

        public async Task<List<Country>> GetCountries()
        {
            var cachekey = "Countries";
            if (!_memoryCache.TryGetValue(cachekey, out List<Country>? countries))
            {
                countries = await _context.Countries.ToListAsync();
                _memoryCache.Set(cachekey, countries, _cacheexpiry);
            }
            return countries ?? new List<Country>();
        }

        public async Task<List<State>> GetStates(int countryid)
        {
            string cachekey = $"States_{countryid}";

            if (!_memoryCache.TryGetValue(cachekey, out List<State>? states))
            {
                states = await _context.States.Where(s => s.CountryId == countryid).ToListAsync();
                _memoryCache.Set(cachekey, states, _cacheexpiry);
            }
            return states ?? new List<State>();
        }

        public async Task<List<City>>GetCities(int stateid)
        {
            string cachekey= $"Cities_{stateid}";

            if(!_memoryCache.TryGetValue(cachekey, out List<City>?cities))
            {
                cities = await _context.Cities.Where(c => c.StateId == stateid).ToListAsync();
                _memoryCache.Set(cachekey, cities, _cacheexpiry);
            }
            return cities ?? new List<City>();  
        }
    }
}
