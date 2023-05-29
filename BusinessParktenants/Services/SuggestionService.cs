using BusinessParktenants.Data;
using BusinessParktenants.Models;

namespace BusinessParktenants.Services
{
    public class SuggestionService : ISuggestionService
    {

        BussinessContext context;

        public SuggestionService(BussinessContext _context)
        {
            context = _context;
        }
        public void insert(SuggestionDTO suggestionDTO)
        {
            Suggestion suggestion = new Suggestion()
            {
                Name = suggestionDTO.Name,
                Phone = suggestionDTO.Phone,
                Title = suggestionDTO.Title,
                Details = suggestionDTO.Details
            };
            context.Suggestions.Add(suggestion);
            context.SaveChanges();
        }
        public List<SuggestionDTO> loadall()
        {
            List<Suggestion> Suggestions = context.Suggestions.ToList();
            List<SuggestionDTO> SuggestionsDTOs = new List<SuggestionDTO>();
            foreach (Suggestion item in Suggestions)
            {
                SuggestionDTO ll = new SuggestionDTO();
                ll.Id = item.Id;
                ll.Name = item.Name;
                ll.Phone = item.Phone;
                ll.Details = item.Details;
                ll.Title = item.Title;
                SuggestionsDTOs.Add(ll);
            }
            return SuggestionsDTOs;
        }

    }
}