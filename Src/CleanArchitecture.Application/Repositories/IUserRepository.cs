using CleanArchitecture.Domain.Entites;

namespace CleanArchitecture.Application.Repositories;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User> GetByEmail(string email, CancellationToken cancellationToken);
}