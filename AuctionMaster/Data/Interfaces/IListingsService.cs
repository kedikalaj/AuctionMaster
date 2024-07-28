using AuctionMaster.Models;

namespace AuctionMaster.Data.Interfaces
{
    public interface IListingsService
    {
        IQueryable<Listing> GetAll();
    }
}
