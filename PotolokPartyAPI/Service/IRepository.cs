using PotolokPartyAPI.Models;

namespace PotolokPartyAPI.Service
{
    public interface IRepository
    {
        bool DoesItemExist(int id);
        IEnumerable<Order> All { get; }
        IEnumerable<string> AllNews { get; }
        Order Find(int id);
        void Insert(Order item);
        void Update(Order item);
        void Delete(int id);
    }
}