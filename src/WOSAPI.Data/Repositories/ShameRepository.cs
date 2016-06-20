using System;
using System.Linq;
using WOSAPI.Models;

namespace WOSAPI.Data.Repositories
{
    public class ShameRepository : IShameRepository, IDisposable
    {
        private readonly WosContext _context;

        public ShameRepository(string userID)
        {
            _context = new WosContext(userID);
        }

        public void Add(Shame shame)
        {
            _context.Shames.Add(shame);
            _context.SaveChanges();
        }

        public IQueryable<Shame> Get()
        {
            return _context.Shames;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }

    public interface IShameRepository
    {
        void Add(Shame shame);
        IQueryable<Shame> Get();
    }
}
