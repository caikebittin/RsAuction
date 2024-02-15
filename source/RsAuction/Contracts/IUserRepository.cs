using RsAuction.Entities;

namespace RsAuction.Contracts;

public interface IUserRepository
{
    bool ExistUserWithEmail(string email);

    User GetUserByEmail(string email);
}
