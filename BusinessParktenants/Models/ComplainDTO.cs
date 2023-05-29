using BusinessParktenants.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BusinessParktenants.Models
{
    public class ComplainDTO
    {
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }

        public string Title { get; set; }
        [Required]
        public string Details { get; set; }
        public string? Note { get; set; }
        public string? Status { get; set; }
        public string? UserId { get; set; }


    }
}
