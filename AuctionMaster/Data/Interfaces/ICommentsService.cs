using AuctionMaster.Models;

namespace AuctionMaster.Data.Interfaces
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
