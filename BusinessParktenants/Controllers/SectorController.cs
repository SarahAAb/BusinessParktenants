using BusinessParktenants.Models;
using BusinessParktenants.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BusinessParktenants.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class SectorController : ControllerBase
    {
       ISectorService sectorService;

        public SectorController(ISectorService _sectorService)
        {
            sectorService = _sectorService;
        }
        [Route("NewSector")]
        [HttpPost]
        public void NewSector(SectorDTO sectorDTO)
        {
                sectorService.insert(sectorDTO);

        }
        [Route("SectorList")]
        [HttpGet]
        public List<SectorDTO> CompanyList()
        {
            return sectorService.loadall();
        }
    }
}
