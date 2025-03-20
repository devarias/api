using api.Models;
using api.Data;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace api.Repositories
{
    public class CityRepository(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext db = context;

        public async Task<List<City>> GetAllCities()
        {
            return await db.City.ToListAsync();
        }
    }
}