using DoctorAppointment.Persistence.Ef;
using DoctorAppointment.Persistence.Ef.Doctors;
using DoctorAppointment.Services.Doctors;
using DoctorAppointment.Services.Doctors.Contracts;

namespace DoctorAppointment.Test.Tools.Doctors;

public class DoctorServiceFactory
{
    public static DoctorService Create(EfDataContext context)
    {
        var doctorRepository = new EfDoctorRepository(context);
        var unitOfWork = new EfUnitOfWork(context);
        return new DoctorAppService(doctorRepository, unitOfWork);
    }
}