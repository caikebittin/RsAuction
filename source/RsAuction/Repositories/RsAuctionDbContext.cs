﻿using Microsoft.EntityFrameworkCore;
using RsAuction.Entities;

namespace RsAuction.Repositories;

public class RsAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=C:\Teste\leilaoDbNLW.db");
    }

}
