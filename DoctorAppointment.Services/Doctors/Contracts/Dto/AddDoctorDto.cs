namespace DoctorAppointment.Services.Doctors.Contracts.Dto;

public class AddDoctorDto
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? NationalId { get; set; }
    public string? Field { get; set; }
}