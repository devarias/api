using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();

// Controller API
[ApiController]
[Route("api/nodo")]
public class HolaController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new {message= "Hola, Nodo"});
    }
}
