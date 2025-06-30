using DoctorAppointmentSystem.Modules;

namespace DoctorAppointmentSystem.Dtos
{
    public static class Extensions
    {

        public static DoctorDto ToDto(this Doctor doctor)
        {
            return new DoctorDto
            {
                Id = doctor.Id,
                Name = doctor.Name,
                Speciality = doctor.Speciality
            };
        }

        public static Doctor ToEntity(this CreateDoctorDto doctorDto)
        {
            return new Doctor
            {
                Name = doctorDto.Name,
                Speciality = doctorDto.Speciality
            };
        }

        public static PatientDto ToDto(this Patient patient)
        {
            return new PatientDto
            {
                Id = patient.Id,
                Name = patient.Name
            };
        }

        public static Patient ToEntity(this CreatePatientDto patientDto)
        {
            return new Patient
            {
                Name = patientDto.Name
            };
        }

        public static AppointmentDto ToDto(this Appointment appointment)
        {
            return new AppointmentDto
            {
                Id = appointment.Id,
                DoctorId = (int)appointment.DoctorId,
                PatientId = (int)appointment.PatientId,
                Date = (DateTime)appointment.Date,
                Slot = appointment.Slot
            };
        }

        public static Appointment ToEntity(this CreateAppointmentDto appointmentDto)
        {
            return new Appointment
            {
                DoctorId = appointmentDto.DoctorId,
                PatientId = appointmentDto.PatientId,
                Date = appointmentDto.Date,
                Slot = appointmentDto.Slot
            };
        }

    }
}
