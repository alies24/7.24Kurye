using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        IVehicleService _vehicleService;
        public VehiclesController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet("get")]
        public IActionResult GetAll()
        {
            var result = _vehicleService.GetVehicles();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }
        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var result = _vehicleService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }

      
        [HttpPost]
        public IActionResult Add(Vehicle vehicle)
        {
            var result = _vehicleService.Add(vehicle);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

    }
}
