using AuctionMaster.Models;

namespace AuctionMaster.Data.Interfaces
{
    public interface IBidService
    {
        Task Add(Bid bid);
        IQueryable<Bid> GetAll();
    }
}
