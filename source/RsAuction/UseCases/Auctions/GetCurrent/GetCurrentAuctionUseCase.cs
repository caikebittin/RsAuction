using Microsoft.EntityFrameworkCore;
using RsAuction.Entities;
using RsAuction.Repositories;

namespace RsAuction.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction? Execute()
    {
        var repository = new RsAuctionDbContext();

        // Data Fixa para ser compartivel com a data de simulação da DB.
        // Usar DateTime.Now
        var today = new DateTime(2024, 01, 21);

        return repository.Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
}
