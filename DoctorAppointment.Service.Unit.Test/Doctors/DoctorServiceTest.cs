using DoctorAppointment.Persistence.Ef;
using DoctorAppointment.Services.Doctors.Contracts;
using DoctorAppointment.Test.Tools.Doctors;
using DoctorAppointment.Test.Tools.Infrastructure.DatabaseConfig.Unit;
using Xunit;

namespace DoctorAppointment.Service.Unit.Test.Doctors;

public class DoctorServiceTest
{
    private readonly EfDataContext context;
    private readonly EfDataContext readContext;
    private readonly DoctorService sut;

    public DoctorServiceTest()
    {
        var db = new EfInMemoryDatabase();
        context = db.CreateDataContext<EfDataContext>();
        readContext = db.CreateDataContext<EfDataContext>();
        sut = DoctorServiceFactory.Create(context);
    }

    [Fact]
    public async Task Add_add_new_doctor_properly()
    {
        var dto = AddDoctorDtoFactory.Create("123456789");

        sut.Add(dto);

        var actual = readContext.Doctors.Single();
        Assert.Equal(dto.FirstName, actual.FirstName);
        Assert.Equal(dto.LastName, actual.LastName);
        Assert.Equal(dto.Field, actual.Field);
        Assert.Equal(dto.NationalId, actual.NationalId);
    }
}