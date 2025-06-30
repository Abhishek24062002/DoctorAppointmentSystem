using DoctorAppointmentSystem.Dtos;
using DoctorAppointmentSystem.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentsController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpPost("book")]
        public IActionResult BookAppointment([FromBody] CreateAppointmentDto appointmentDto)
        {
            var result = _appointmentService.BookAppointmentAsync(appointmentDto).GetAwaiter().GetResult();
            return result.IsSuccess ? Ok(result.Value) : BadRequest(result.Error);
        }

        [HttpGet("all")]
        public IActionResult GetAppointments()
        {
            var result = _appointmentService.GetAppointmentsAsync().GetAwaiter().GetResult();
            return result.IsSuccess ? Ok(result.Value) : BadRequest(result.Error);
        }

        [HttpGet("{id}")]
        public IActionResult GetAppointment(int id)
        {
            var result = _appointmentService.GetAppointmentByIdAsync(id).GetAwaiter().GetResult();
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

        [HttpGet("doctor/{doctorId}")]
        public IActionResult GetAppointmentsByDoctor(int doctorId)
        {
            var result = _appointmentService.GetAppointmentsByDoctorIdAsync(doctorId).GetAwaiter().GetResult();
            return result.IsSuccess ? Ok(result.Value) : BadRequest(result.Error);
        }

        [HttpGet("patient/{patientId}")]
        public IActionResult GetAppointmentsByPatient(int patientId)
        {
            var result = _appointmentService.GetAppointmentsByPatientIdAsync(patientId).GetAwaiter().GetResult();
            return result.IsSuccess ? Ok(result.Value) : BadRequest(result.Error);
        }
    }
}
