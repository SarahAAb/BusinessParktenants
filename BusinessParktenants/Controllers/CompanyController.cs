using BusinessParktenants.Models;
using BusinessParktenants.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusinessParktenants.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        ICompanyService companyService;

        public CompanyController(ICompanyService _companyService)
        {
            companyService = _companyService;
        }
        [Route("NewCompany")]
        [HttpPost]
        public bool NewCompany(CompanyDTO companyDTO)
        {
            bool result = companyService.CheckName(companyDTO.Name);
            if (result == true)
            {
                companyService.insert(companyDTO);
                return true;
            }
            else
            {
                return false;
            }

        }
        [Route("CompanyList")]
        [HttpGet]
        public List<CompanyDTO> CompanyList()
        {
            return companyService.loadall();
        }
        [Route("Edit")]
        [HttpGet]
        public CompanyDTO Edited(int Id)
        {
            return companyService.Edit(Id);

        }
        [Route("Update")]
        [HttpPost]
        public void Updated(CompanyDTO company)
        {
            companyService.Update(company);


        }
        [Route("Delete")]
        [HttpGet]
        public void Deleted(int Id)
        {
            companyService.Delete(Id);


        }

    }
}
