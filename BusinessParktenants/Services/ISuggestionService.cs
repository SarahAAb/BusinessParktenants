using BusinessParktenants.Models;

namespace BusinessParktenants.Services
{
    public interface ISuggestionService
    {
        void insert(SuggestionDTO suggestionDTO);
        List<SuggestionDTO> loadall();
    }
}
