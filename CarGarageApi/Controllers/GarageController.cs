using Microsoft.AspNetCore.Mvc;
using CarGarageApi.Models;
using Newtonsoft.Json;
using CarGarageApi.Interfaces;

namespace CarGarageApi.Controllers
{
    [ApiController]
    [Route("api/Garage")]
    public class GarageController : ControllerBase
    {

        private readonly ILogger<GarageController> _logger;
        private readonly IGarageService _garageService;

        public GarageController(ILogger<GarageController> logger, IGarageService garageService)
        {
            _logger = logger;
            _garageService = garageService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Garage>>> GetGarages()
        {
            var garage = await _garageService.GetAllGarages();
        }

        [HttpGet("id")]
        public async Task<ActionResult<Garage>> GetGarageById(int id)
        {
            var garage = await _garageService.GetGarageById(id);

        }

        [HttpPost]
        public async Task<ActionResult> AddGarage(string json)
        {
            var garage = JsonConvert.DeserializeObject<Garage>(json);

        }

        [HttpDelete("id")]
        public async Task<ActionResult> DeleteGarage(int id)
        {
            if (_context.Garages.Find(id) is Garage garage)
            {
                _context.Garages.Remove(garage);

                await _context.SaveChangesAsync();
            }

            return NotFound();
        }
    }
}
