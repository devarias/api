using api.Data;
using api.Models;
using api.Repositories;


namespace api.Services
{
    public class CityService(ApplicationDbContext context)
    {
        private readonly CityRepository cityRepository = new(context);

        public async Task<List<City>> GetAllCities()
        {
            return await cityRepository.GetAllCities();
        }
    }
}