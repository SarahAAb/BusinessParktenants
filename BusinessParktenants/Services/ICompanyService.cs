using BusinessParktenants.Models;

namespace BusinessParktenants.Services
{
    public interface ICompanyService
    {
        void insert(CompanyDTO companyDTO);
        void Update(CompanyDTO companyDTO);
        List<CompanyDTO> loadall();
        CompanyDTO Edit(int Id);
        void Delete(int Id);
        bool CheckName(string Name);
    }
}
