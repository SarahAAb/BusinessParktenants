using BusinessParktenants.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessParktenants.Data
{
    [Table("Suggestions")]
    public class Suggestion
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }

        public string Title { get; set; }
        [Required]
        public string Details { get; set; }

    }
}
