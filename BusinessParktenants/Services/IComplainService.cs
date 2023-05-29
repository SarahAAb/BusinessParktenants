using BusinessParktenants.Models;

namespace BusinessParktenants.Services
{
    public interface IComplainService
    {
        void insert(ComplainDTO complainDTO);
        void Update(ComplainDTO complainDTO);
        List<ComplainDTO> loadall();
        ComplainDTO Edit(int Id);
        List<ComplainDTO> loadComplain(string Id);
        void UpdateReplay(ComplainDTO complainDTO);
        ComplainDTO EditReplay(int Id);
        List<ComplainDTO> loadDone();
    }
}
