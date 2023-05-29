using System.ComponentModel.DataAnnotations;

namespace BusinessParktenants.Models
{
    public class SectorDTO
    {
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
