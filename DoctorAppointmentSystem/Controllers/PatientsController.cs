using DoctorAppointmentSystem.Dtos;
using DoctorAppointmentSystem.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientsController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpPost("register")]
        public IActionResult RegisterPatient([FromBody] CreatePatientDto patientDto)
        {
            var result = _patientService.RegisterPatientAsync(patientDto).GetAwaiter().GetResult();
            return result.IsSuccess ? Ok(result.Value) : BadRequest(result.Error);
        }

        [HttpGet("all")]
        public IActionResult GetPatients()
        {
            var result = _patientService.GetPatientsAsync().GetAwaiter().GetResult();
            return result.IsSuccess ? Ok(result.Value) : BadRequest(result.Error);
        }

        [HttpGet("{id}")]
        public IActionResult GetPatient(int id)
        {
            var result = _patientService.GetPatientByIdAsync(id).GetAwaiter().GetResult();
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
    }
}
