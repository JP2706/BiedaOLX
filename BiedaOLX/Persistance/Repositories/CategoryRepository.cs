using BiedaOLX.Core;
using BiedaOLX.Core.Domains;
using BiedaOLX.Core.Models.Domains;
using BiedaOLX.Core.Repositories;
using System.Collections.Generic;

namespace BiedaOLX.Persistance.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IApplicationDBContext _context;

        public CategoryRepository(IApplicationDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> Get()
        {
            return _context.Categories;
        }

        public IEnumerable<NotOrUsed> NotOrUsedsGet()
        {
            return _context.NotOrUseds;
        }
    }
}
