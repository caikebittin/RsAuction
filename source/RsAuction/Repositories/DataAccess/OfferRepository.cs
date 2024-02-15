using RsAuction.Contracts;
using RsAuction.Entities;

namespace RsAuction.Repositories.DataAccess;

public class OfferRepository : IOfferRepository
{
    private readonly RsAuctionDbContext _dbContext;

    public OfferRepository(RsAuctionDbContext dbContext) => _dbContext = dbContext;

    public void Add(Offer offer)
    {
        _dbContext.Offers.Add(offer);

        _dbContext.SaveChanges();
    }
}
