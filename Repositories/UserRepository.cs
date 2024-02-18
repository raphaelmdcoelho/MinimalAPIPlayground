using MinimalApiPlayground.Modes;

namespace MinimalApiPlayground.Repositories;

public class UserRepository : IUserRepository
{
    private UserDbContext _dbContext;
    public UserRepository(UserDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public User Get(Guid id)
    {
        if (id == Guid.Empty)
            throw new ArgumentNullException(nameof(id));

        var user = _dbContext.Set<User>().FirstOrDefault(u => u.Id == id);
        if (user == null)
            throw new InvalidOperationException("User not found.");

        return user;
    }

    public void Add(User user)
    {
        _dbContext.Set<User>().Add(user);
        _dbContext.SaveChanges();
    }
}