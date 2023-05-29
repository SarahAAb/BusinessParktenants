using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessParktenants.Data
{
    [Table("Sectors")]

    public class Sector
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Company> Companies { get; set; }

    }
}
