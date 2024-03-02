using DoctorAppointment.Services.Doctors.Contracts.Dto;

namespace DoctorAppointment.Test.Tools.Doctors;

public class AddDoctorDtoFactory
{
    public static AddDoctorDto Create(string? nationalId = null)
    {
        return new AddDoctorDto()
        {
            FirstName = "dummy_FirstName",
            LastName = "dummy_LastName",
            Field = "Heart",
            NationalId = nationalId ?? "123456789"
        };
    }
}