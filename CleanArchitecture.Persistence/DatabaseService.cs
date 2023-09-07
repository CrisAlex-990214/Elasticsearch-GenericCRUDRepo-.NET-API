using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Persistence
{
    public class DatabaseService : IDatabaseService
    {
        public List<User> GetUsers() => new() { new() { Id = 1, Name = "User name" } };
    }
}