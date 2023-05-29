using BusinessParktenants.Models;
using BusinessParktenants.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusinessParktenants.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplainController : ControllerBase
    {
        IComplainService complainService;

        public ComplainController(IComplainService _complainService)
        {
            complainService = _complainService;
        }            
            [Route("NewComplain")]
            [HttpPost]
            public void NewComplain(ComplainDTO complainDTO)
            {
                    complainService.insert(complainDTO);
            }
        [Authorize(Roles = "Admin")]
        [Route("ComplainList")]
            [HttpGet]
            public List<ComplainDTO> ComplainList()
            {
                return complainService.loadall();
            }
        [Authorize(Roles = "Admin")]
        [Route("Edit")]
            [HttpGet]
            public ComplainDTO Edited(int Id)
            {
            return complainService.Edit(Id);

            }
        [Authorize(Roles = "Employee")]
        [Route("EditReplay")]
        [HttpGet]
        public ComplainDTO EditReplay(int Id)
        {
            return complainService.EditReplay(Id);

        }
        [Authorize(Roles = "Employee")]
        [Route("UpdateReplay")]
        [HttpPost]
        public void UpdateReplay(ComplainDTO complainDTO)
        {
            complainService.UpdateReplay(complainDTO);
        }
        [Authorize(Roles = "Admin")]
        [Route("Assign")]
            [HttpPost]
            public void Assign(ComplainDTO complainDTO)
            {
                complainService.Update(complainDTO);


            }
        [Authorize(Roles = "Employee")]
        [Route("ComplainAssigned")]
        [HttpGet]
        public List<ComplainDTO> ComplainAssigned(string userId)
        {
            return complainService.loadComplain(userId);
        }
        [Authorize]
        [Route("Complainno")]
        [HttpGet]
        public int ComplainListno()
        {
            List<ComplainDTO> Result= complainService.loadall();
            return Result.Count();
        }
        [Authorize]
        [Route("ComplainDone")]
        [HttpGet]
        public int ComplainListDone()
        {
            List<ComplainDTO> Result = complainService.loadDone();
            return Result.Count();
        }
    }
}
