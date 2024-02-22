using BiedaOLX.Core.Domains;

namespace BiedaOLX.Core.Repositories
{
    public interface IMyAppUserRepository
    {
        MyAppUser Get(string id);
        void Add(MyAppUser myuser);
    }
}
