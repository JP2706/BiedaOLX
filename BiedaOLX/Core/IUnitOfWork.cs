using BiedaOLX.Core.Repositories;

namespace BiedaOLX.Core
{
    public interface IUnitOfWork
    {
        IAnnouncementRepository Announcement { get; set; }
        ICategoryRepository Category { get; set; }
        IMyAppUserRepository MyAppUser { get; set; }
        void Complete();

    }
}
