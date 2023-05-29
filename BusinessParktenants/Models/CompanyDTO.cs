using BusinessParktenants.Data;
using System.ComponentModel.DataAnnotations;

namespace BusinessParktenants.Models
{
    public class CompanyDTO
    {
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        public SectorDTO? SectorDTO { get; set; }
        public int? SectorId { get; set; }
        [Required]
        public string size { get; set; }
    }
}
