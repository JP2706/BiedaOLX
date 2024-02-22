using BiedaOLX.Core.Models.Domains;
using System.ComponentModel.DataAnnotations;

namespace BiedaOLX.Core.Domains
{
    public class MyAppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        [MaxLength(12)]
        public string PhoneNumer { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
