using BusinessParktenants.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessParktenants.Data
{
    [Table("Complains")]
    public class Complain
    {
       public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Title { get; set; }
        [Required]
        public string Details { get; set; }
        public string? Note { get; set; }
        public string? Status { get; set; }

        public ApplicationUsers applicationUsers { get; set; }
        [ForeignKey("applicationUsers")]
        public string? UserId { get; set; }
    }
}
