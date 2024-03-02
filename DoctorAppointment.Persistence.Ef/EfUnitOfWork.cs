using DoctorAppointment.Contracts;

namespace DoctorAppointment.Persistence.Ef;

public class EfUnitOfWork : UnitOfWork
{
    private readonly EfDataContext _db;

    public EfUnitOfWork(EfDataContext db)
    {
        _db = db;
    }

    public async Task Begin()
    {
        await _db.Database.BeginTransactionAsync();
    }

    public async Task Commit()
    {
        await _db.Database.CommitTransactionAsync();
    }

    public async Task Complete()
    {
        await _db.SaveChangesAsync();
    }

    public async Task RollBack()
    {
        await _db.Database.RollbackTransactionAsync();
    }
}