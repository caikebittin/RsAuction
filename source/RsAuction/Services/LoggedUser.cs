using RsAuction.Entities;
using RsAuction.Repositories;

namespace RsAuction.Services;

public class LoggedUser
{
    private readonly IHttpContextAccessor _httpcontextAccessor;

    public LoggedUser(IHttpContextAccessor httpContext)
    {
        _httpcontextAccessor = httpContext;
    }

    public User User()
    {
        var repository = new RsAuctionDbContext();

        var token = TokenOnRequest();

        var email = FromBase64String(token);

        return repository.Users.First(user => user.Email.Equals(email));
    }

    private string TokenOnRequest()
    {
        var authentication = _httpcontextAccessor.HttpContext!.Request.Headers.Authorization.ToString();

        return authentication["Bearer ".Length..];
    }

    private string FromBase64String(string base64)
    {
        var data = Convert.FromBase64String(base64);

        return System.Text.Encoding.UTF8.GetString(data);
    }
}
