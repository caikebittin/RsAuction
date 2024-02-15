using RsAuction.Entities;

namespace RsAuction.Contracts;

public interface IAuctionRepository
{
    Auction? GetCurrent();
}
