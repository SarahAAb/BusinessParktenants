using BusinessParktenants.Data;
using BusinessParktenants.Models;

namespace BusinessParktenants.Services
{
    public class SectorService:ISectorService
    {
        BussinessContext context;

        public SectorService(BussinessContext _context)
        {
            context = _context;
        }
        public void insert(SectorDTO sectorDTO)
        {
            Sector sector= new Sector()
            {
                Name = sectorDTO.Name,
            };
            context.Sectors.Add(sector);
            context.SaveChanges();
        }
        public List<SectorDTO> loadall()
        {
            List<Sector> sectors = context.Sectors.ToList();
            List<SectorDTO> sectorDTOs = new List<SectorDTO>();
            foreach (Sector item in sectors)
            {
                SectorDTO ll = new SectorDTO()
                {
                   Id = item.Id,
                    Name = item.Name,

                };
                sectorDTOs.Add(ll);
            }
            return sectorDTOs;
        }
    }
}
