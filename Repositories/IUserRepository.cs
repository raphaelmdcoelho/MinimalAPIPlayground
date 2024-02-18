using MinimalApiPlayground.Modes;

namespace MinimalApiPlayground.Repositories;

public interface IUserRepository
{
    User Get(Guid id);
    void Add(User user);
}