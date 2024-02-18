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
        if(id == Guid.Empty)
            throw new ArgumentNullException(nameof(id));

        return _dbContext.Set<User>().Find(id);
    }

    public void Add(User user)
    {
        _dbContext.Set<User>().Add(user);
        _dbContext.SaveChanges();
    }
}