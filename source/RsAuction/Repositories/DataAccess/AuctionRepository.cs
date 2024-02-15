using Microsoft.EntityFrameworkCore;
using RsAuction.Contracts;
using RsAuction.Entities;

namespace RsAuction.Repositories.DataAccess;

public class AuctionRepository : IAuctionRepository
{
    private readonly RsAuctionDbContext _dbContext;

    public AuctionRepository(RsAuctionDbContext dbContext) => _dbContext = dbContext;

    public Auction? GetCurrent()
    {
        // Data Fixa para ser compartivel com a data de simulação da DB.
        // Usar DateTime.Now
        var today = new DateTime(2024, 01, 21);

        return _dbContext.Auctions
                         .Include(auction => auction.Items)
                         .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
}
