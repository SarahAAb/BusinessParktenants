using BusinessParktenants.Models;
using BusinessParktenants.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BusinessParktenants.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuggestionController : ControllerBase
    {
        ISuggestionService SuggestionService;

        public SuggestionController(ISuggestionService _SuggestionService)
        {
            SuggestionService = _SuggestionService;
        }
        [Route("NewSuggestion")]
        [HttpPost]
        public void NewSuggestion(SuggestionDTO SuggestionDTO)
        {
            SuggestionService.insert(SuggestionDTO);
        }
        [Authorize(Roles = "Admin")]
        [Route("SuggestionList")]
        [HttpGet]
        public List<SuggestionDTO> SuggestionList()
        {
            return SuggestionService.loadall();
        }
        [Authorize]
        [Route("Suggestionno")]
        [HttpGet]
        public int Suggestionno()
        {
            return SuggestionService.loadall().Count();
        }


    }
}
