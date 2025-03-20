using api.Data;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class CityController(ApplicationDbContext context) : ControllerBase
{
    private readonly CityService cityService = new(context);

    [HttpGet]
    public async Task<IActionResult> GetAllCities()
    {
        var cities = await cityService.GetAllCities();

        return Ok(cities);
    }
}