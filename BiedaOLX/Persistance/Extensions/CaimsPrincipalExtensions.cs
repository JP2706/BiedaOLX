using System.Security.Claims;

namespace BiedaOLX.Persistance.Extensions
{
    public static class CaimsPrincipalExtensions
    {
        public static string GetUserId(this ClaimsPrincipal model)
        {
            return model.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
