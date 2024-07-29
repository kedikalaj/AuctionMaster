using AuctionMaster.Data.Interfaces;
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

        public async Task Create(Listing listing)
        {
            _context.Listings.Add(listing);
            await _context.SaveChangesAsync();
        }

        public async Task<Listing> GetById(int? id)
        {
            var listing = await _context.Listings.Where(x => x.Id == id).Include(l => l.User).Include(l => l.Comments).Include(l => l.Bids).ThenInclude(l => l.User).FirstOrDefaultAsync();
            return listing;
        }
    }
}
