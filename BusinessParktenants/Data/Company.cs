using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessParktenants.Data
{
    [Table("Companies")]
    public class Company
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        public Sector Sector { get; set; }
        [ForeignKey("Sector")]
        public int SectorId { get; set; }
        [Required]
        public string size { get; set; }

    }
}
