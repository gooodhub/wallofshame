using System;
using System.Linq;
using WOSAPI.Models;

namespace WOSAPI.Data.Repositories
{
    public class UserRepository : IUserRepository, IDisposable
    {
        private readonly WosContext _context;

        public UserRepository(string userID)
        {
            _context = new WosContext(userID);
        }
        
        public IQueryable<ApplicationUser> Get()
        {
            return _context.Users;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }

    public interface IUserRepository
    { 
        IQueryable<ApplicationUser> Get();
    }
}
