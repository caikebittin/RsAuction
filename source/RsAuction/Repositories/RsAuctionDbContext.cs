using Microsoft.EntityFrameworkCore;
using RsAuction.Entities;

namespace RsAuction.Repositories;

public class RsAuctionDbContext : DbContext
{
    public RsAuctionDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }
}
