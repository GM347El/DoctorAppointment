using DoctorAppointment.Contracts;
using DoctorAppointment.Entities;
using DoctorAppointment.Services.Doctors.Contracts;
using DoctorAppointment.Services.Doctors.Contracts.Dto;


namespace DoctorAppointment.Services.Doctors;

public class DoctorAppService : DoctorService
{
    private readonly UnitOfWork unitOfWork;
    private readonly DoctorRepository doctorRepository;

    public DoctorAppService(DoctorRepository efDoctorRepository, UnitOfWork efUnitOfWork)
    {
        unitOfWork = efUnitOfWork;
        doctorRepository = efDoctorRepository;
    }

    public async Task Add(AddDoctorDto dto)
    {
        var doctor = new Doctor()
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Field = dto.Field,
            NationalId = dto.NationalId
        };
        doctorRepository.Add(doctor);
        unitOfWork.Complete();
    }
}