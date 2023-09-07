using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IDatabaseService
    {
        List<User> GetUsers();
    }
}
