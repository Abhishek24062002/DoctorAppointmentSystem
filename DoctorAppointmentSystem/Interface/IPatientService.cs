using DoctorAppointmentSystem.Dtos;
using DoctorAppointmentSystem.Utils;

namespace DoctorAppointmentSystem.Interface
{
    public interface IPatientService
    {
        Task<Result<PatientDto>> RegisterPatientAsync(CreatePatientDto patient);
        Task<Result<IEnumerable<PatientDto>>> GetPatientsAsync();
        Task<Result<PatientDto>> GetPatientByIdAsync(int id);
    }
}
