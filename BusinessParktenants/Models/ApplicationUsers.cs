using BusinessParktenants.Data;
using Microsoft.AspNetCore.Identity;

namespace BusinessParktenants.Models
{
    public class ApplicationUsers:IdentityUser
    {
        public string FullName { get; set; }
        public List<Complain> Complains { get; set; }

    }
}
