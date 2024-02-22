using BiedaOLX.Core;
using BiedaOLX.Core.Domains;
using BiedaOLX.Core.Models.Domains;
using BiedaOLX.Core.Services;
using System.Collections.Generic;

namespace BiedaOLX.Persistance.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Category> Get()
        {
            return _unitOfWork.Category.Get();
        }

        public IEnumerable<NotOrUsed> NotOrUsedsGet()
        {
            return _unitOfWork.Category.NotOrUsedsGet();
        }
    }
}
