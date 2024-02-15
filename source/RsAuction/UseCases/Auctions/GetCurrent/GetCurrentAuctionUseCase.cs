using RsAuction.Contracts;
using RsAuction.Entities;

namespace RsAuction.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    private readonly IAuctionRepository _repository;

    public GetCurrentAuctionUseCase(IAuctionRepository repository) => _repository = repository;

    public Auction? Execute()
    {
        return _repository.GetCurrent();
    }
}
