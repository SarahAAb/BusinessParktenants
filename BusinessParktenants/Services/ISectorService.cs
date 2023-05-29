using BusinessParktenants.Models;

namespace BusinessParktenants.Services
{
    public interface ISectorService
    {
        void insert(SectorDTO sectorDTO);
        List<SectorDTO> loadall();
    }
}
