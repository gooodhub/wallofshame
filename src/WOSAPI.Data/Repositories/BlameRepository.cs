using System;
using System.Linq;
using WOSAPI.Models;

namespace WOSAPI.Data.Repositories
{
    public class BlameRepository : IBlameRepository, IDisposable
    {
        private readonly WosContext _context;

        public BlameRepository(string userID)
        {
            _context = new WosContext(userID);
        }

        public void Add(Blame blame)
        {
            _context.Blames.Add(blame);
            _context.SaveChanges();
        }

        public IQueryable<Blame> Get()
        {
            return _context.Blames;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }

    public interface IBlameRepository
    {
        void Add(Blame blame);
        IQueryable<Blame> Get();
    }
}
