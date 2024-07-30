using AuctionMaster.Models;

namespace AuctionMaster.Data.Interfaces
{
    public interface IListingsService
    {
        IQueryable<Listing> GetAll();
        Task Create(Listing listing);
        Task<Listing> GetById(int? id);
        Task SaveChanges();
    }
}
