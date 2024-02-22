using BiedaOLX.Core.Domains;
using BiedaOLX.Core.Models.Domains;

namespace BiedaOLX.Core.ViewModels
{
    public class AnnouncementReadOnlyViewModel
    {
        public Announcement Announcement { get; set; }
        public MyAppUser MyAppUserE {  get; set; }
    }
}
