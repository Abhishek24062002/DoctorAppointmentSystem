using DoctorAppointmentSystem.Dtos;
using DoctorAppointmentSystem.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorsController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpPost("add")]
        public IActionResult AddDoctor([FromBody] CreateDoctorDto doctorDto)
        {
            var result = _doctorService.AddDoctorAsync(doctorDto).GetAwaiter().GetResult();
            return result.IsSuccess ? Ok(result.Value) : BadRequest(result.Error);
        }

        [HttpGet("all")]
        public IActionResult GetDoctors()
        {
            var result = _doctorService.GetDoctorsAsync().GetAwaiter().GetResult();
            return result.IsSuccess ? Ok(result.Value) : BadRequest(result.Error);
        }

        [HttpGet("{id}")]
        public IActionResult GetDoctor(int id)
        {
            var result = _doctorService.GetDoctorByIdAsync(id).GetAwaiter().GetResult();
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
    }
}
