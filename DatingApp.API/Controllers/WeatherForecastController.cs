using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {        
        private readonly DataContext _context;
        private readonly ILogger<WeatherForecastController> _logger;
        public WeatherForecastController(DataContext context,ILogger<WeatherForecastController> logger)
        {
            _context = context;
            _logger = logger;        
        }
        // private static readonly string[] Summaries = new[]
        // {
        //     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        // };        

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Get()
        {       
            var Summaries= await _context.Values.ToListAsync(); 
            // var rng = new Random();
            // var data=  Enumerable.Range(1, 5).Select(index => new WeatherForecast
            // {
            //     Date = DateTime.Now.AddDays(index),
            //     TemperatureC = rng.Next(-20, 55),
            //     Summary = Summaries[rng.Next(Summaries.Count)].Name
            // })
            // .ToArray();
            return Ok(Summaries);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id){
            var value=await _context.Values.SingleOrDefaultAsync(e=>e.Id==id);
            return Ok(value);
        }
    }
}
