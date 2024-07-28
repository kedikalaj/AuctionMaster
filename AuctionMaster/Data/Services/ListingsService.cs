﻿using AuctionMaster.Data.Interfaces;
using AuctionMaster.Models;
using Microsoft.EntityFrameworkCore;

namespace AuctionMaster.Data.Services
{
    public class ListingsService : IListingsService
    {
        private readonly ApplicationDbContext _context;

        public ListingsService(ApplicationDbContext context)
        {
            _context = context;
        }
        public ListingsService() { }
        public IQueryable<Listing> GetAll()
        {
            var applicationDbContext = _context.Listings.Include(l => l.User);
            return applicationDbContext;
        }
    }
}
