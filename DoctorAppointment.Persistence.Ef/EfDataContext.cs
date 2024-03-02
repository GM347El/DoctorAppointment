using DoctorAppointment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Options;

namespace DoctorAppointment.Persistence.Ef;

public class EfDataContext : DbContext
{
    public EfDataContext(string connectionString) : this(new DbContextOptionsBuilder().UseSqlServer(connectionString)
        .Options)
    {
    }

    public EfDataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EfDataContext).Assembly);
    }
}