using RsAuction.Contracts;
using RsAuction.Entities;

namespace RsAuction.Repositories.DataAccess;

public class UserRepository : IUserRepository
{
    private readonly RsAuctionDbContext _dbContext;

    public UserRepository(RsAuctionDbContext dbContext) => _dbContext = dbContext;

    public bool ExistUserWithEmail(string email)
    {
        return _dbContext.Users.Any(user => user.Email.Equals(email));
    }
    public User GetUserByEmail(string email) => _dbContext.Users.First(user => user.Email.Equals(email));
}
