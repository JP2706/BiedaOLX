using BiedaOLX.Core.Domains;
using BiedaOLX.Core.Models.Domains;
using System.Collections.Generic;

namespace BiedaOLX.Core.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Get();
        IEnumerable<NotOrUsed> NotOrUsedsGet();
    }
}
