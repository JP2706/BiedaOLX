using BiedaOLX.Core;
using BiedaOLX.Core.Domains;
using BiedaOLX.Core.Services;

namespace BiedaOLX.Persistance.Services
{
    public class MyAppUserService : IMyAppUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MyAppUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public MyAppUser Get(string userId)
        {
            return _unitOfWork.MyAppUser.Get(userId);
        }
        public void Add(MyAppUser myuser)
        {
            _unitOfWork.MyAppUser.Add(myuser);
            _unitOfWork.Complete();
        }
    }
}
