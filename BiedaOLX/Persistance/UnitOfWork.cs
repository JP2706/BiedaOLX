using BiedaOLX.Core;
using BiedaOLX.Core.Repositories;
using BiedaOLX.Persistance.Repositories;

namespace BiedaOLX.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IApplicationDBContext _context;

        public UnitOfWork(IApplicationDBContext context)
        {
            _context = context;
            Announcement = new AnnouncementRepository(context);
            Category = new CategoryRepository(context);
            MyAppUser = new MyAppUserRepository(context);
        }

        public IAnnouncementRepository Announcement { get; set; }

        public ICategoryRepository Category { get; set; }

        public IMyAppUserRepository MyAppUser { get; set; }



        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}
