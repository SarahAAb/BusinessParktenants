using System.ComponentModel.DataAnnotations;

namespace BusinessParktenants.Models
{
    public class Role
    {
        [Required]
        public string Name { get; set; }

    }
}
