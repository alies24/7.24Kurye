using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourierController : ControllerBase
    {
        ICourierService _courierService;
        public CourierController(ICourierService courierService)
        {
            _courierService = courierService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _courierService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            
            return BadRequest(result.Message);
        }
        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _courierService.GetByCourierId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(Courier courier)
        {
            var result = _courierService.Add(courier);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPut("update")]
        public IActionResult Update(Courier courier)
        {
            var result = _courierService.Update(courier);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Courier courier)
        {
            var result = _courierService.Delete(courier);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }
        [HttpGet("getByIdentityNumber")]
        public IActionResult GetByIdentityNumber(string identityNumber)
        {
            var result = _courierService.GetByIdentityNumber(identityNumber);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }


    }
}
