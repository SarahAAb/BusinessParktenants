using System.ComponentModel.DataAnnotations;

namespace BusinessParktenants.Models
{
    public class SuggestionDTO
    {
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }

        public string Title { get; set; }
        [Required]
        public string Details { get; set; }

    }
}
