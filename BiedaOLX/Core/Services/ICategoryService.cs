using BiedaOLX.Core.Domains;
using BiedaOLX.Core.Models.Domains;
using System.Collections.Generic;

namespace BiedaOLX.Core.Services
{
    public interface ICategoryService
    {
        IEnumerable<Category> Get();
        IEnumerable<NotOrUsed> NotOrUsedsGet();
    }
}
