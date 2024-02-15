using RsAuction.Entities;

namespace RsAuction.Contracts;

public interface IOfferRepository
{
    void Add(Offer offer);
}
