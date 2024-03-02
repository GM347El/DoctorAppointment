namespace DoctorAppointment.Contracts;

public interface UnitOfWork
{
    Task Begin();
    Task Commit();
    Task Complete();
    Task RollBack();
}