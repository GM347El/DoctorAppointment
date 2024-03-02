using DoctorAppointment.Entities;
using DoctorAppointment.Services.Doctors.Contracts;

namespace DoctorAppointment.Persistence.Ef.Doctors;

public class EfDoctorRepository : DoctorRepository
{
    private readonly EfDataContext _db;

    public EfDoctorRepository(EfDataContext db)
    {
        _db = db;
    }

    public void Add(Doctor doctor)
    {
        _db.Add(doctor);
    }
}