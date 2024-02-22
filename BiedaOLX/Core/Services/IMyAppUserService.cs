using BiedaOLX.Core.Domains;

namespace BiedaOLX.Core.Services
{
    public interface IMyAppUserService
    {
        MyAppUser Get(string userId);
        void Add(MyAppUser myuser);
    }
}
