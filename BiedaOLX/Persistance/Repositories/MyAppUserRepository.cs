using BiedaOLX.Core;
using BiedaOLX.Core.Domains;
using BiedaOLX.Core.Repositories;
using System.Linq;

namespace BiedaOLX.Persistance.Repositories
{
    public class MyAppUserRepository : IMyAppUserRepository
    {
        private readonly IApplicationDBContext _context;
        public MyAppUserRepository(IApplicationDBContext context)
        {
            _context = context;
        }

        public MyAppUser Get(string id)
        {
            return _context.MyAppUsers.Single(x => x.UserId == id);
        }
        public void Add(MyAppUser myuser)
        {
            _context.MyAppUsers.Add(myuser);
        }
    }
}
