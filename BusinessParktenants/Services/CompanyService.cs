using BusinessParktenants.Data;
using BusinessParktenants.Models;

namespace BusinessParktenants.Services
{
    public class CompanyService : ICompanyService
    {
        BussinessContext context;

        public CompanyService(BussinessContext _context) {
            context = _context;
        }
        public void insert(CompanyDTO companyDTO)
        {
            Company company=new Company()
            {
              Name= companyDTO.Name,
              Phone = companyDTO.Phone,
              SectorId= (int)companyDTO.SectorId,
              size=companyDTO.size
            };
                context.Companies.Add(company);
                context.SaveChanges();
        }
        public void Update(CompanyDTO companyDTO)
        {
            Company company = new Company()
            {
                Id= (int)companyDTO.Id,
                Name = companyDTO.Name,
                Phone = companyDTO.Phone,
                SectorId = (int)companyDTO.SectorId,
                size = companyDTO.size
            };
            context.Companies.Attach(company);
            context.Entry(company).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
        public List<CompanyDTO> loadall()
        {
            List<Company> companies = context.Companies.ToList();
            List<CompanyDTO> companiesDTOs = new List<CompanyDTO>();
            foreach (Company item in companies)
            {
                CompanyDTO ll = new CompanyDTO();
                ll.Id = item.Id;
                ll.Name = item.Name;
                ll.Phone = item.Phone;
                ll.SectorId = item.SectorId;
                ll.size= item.size;
                companiesDTOs.Add(ll);
            }
            return companiesDTOs;
        }
        public CompanyDTO Edit(int Id)
        {
            Company company = context.Companies.Find(Id);
            CompanyDTO wCompanyDTO = new CompanyDTO()
            {
                Id = (int)company.Id,
                Name = company.Name,
                Phone = company.Phone,
                SectorId = (int)company.SectorId,
                size = company.size
            };

            return wCompanyDTO;
        }

        public void Delete(int Id)
        {
            Company company = context.Companies.Find(Id);
            context.Companies.Remove(company);
            context.SaveChanges();
        }
        public bool CheckName(string Name)
        {
            List<Company> companies = context.Companies.Where(e => e.Name == Name).ToList();
            if (companies.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
