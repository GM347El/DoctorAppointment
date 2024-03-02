namespace DoctorAppointment.Entities;

public class Doctor
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string?  LastName { get; set; }
    public string?  NationalId { get; set; }
    public string?  Field { get; set; }
}