using BusinessParktenants.Data;
using BusinessParktenants.Models;

namespace BusinessParktenants.Services
{
    public class ComplainService:IComplainService
    {
        BussinessContext context;

        public ComplainService(BussinessContext _context)
        {
            context = _context;
        }
        public void insert(ComplainDTO complainDTO)
        {
            Complain complain = new Complain()
            {
                Name = complainDTO.Name,
                Phone = complainDTO.Phone,
                Title = complainDTO.Title,
                Details = complainDTO.Details
            };
            context.Complains.Add(complain);
            context.SaveChanges();
        }
        
        public void Update(ComplainDTO complainDTO)
        {
            Complain complain = new Complain()
            {   Id=(int)complainDTO.Id,
                Name = complainDTO.Name,
                Phone = complainDTO.Phone,
                Title = complainDTO.Title,
                Details = complainDTO.Details,
                UserId = complainDTO.UserId,
            };
            context.Complains.Attach(complain);
            context.Entry(complain).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
        
        public void UpdateReplay(ComplainDTO complainDTO)
        {
            Complain complain = new Complain()
            {
                Id = (int)complainDTO.Id,
                Name = complainDTO.Name,
                Phone = complainDTO.Phone,
                Title = complainDTO.Title,
                Details = complainDTO.Details,
                UserId = complainDTO.UserId,
                Note =complainDTO.Note,
                Status=complainDTO.Status,
            };
            context.Complains.Attach(complain);
            context.Entry(complain).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
       
        public List<ComplainDTO> loadall()
        {
            List<Complain> complains = context.Complains.ToList();
            List<ComplainDTO> complainsDTOs = new List<ComplainDTO>();
            foreach (Complain item in complains)
            {
                ComplainDTO ll = new ComplainDTO();
                ll.Id = item.Id;
                ll.Name = item.Name;
                ll.Phone = item.Phone;
                ll.Details= item.Details;
                ll.Title= item.Title;
                complainsDTOs.Add(ll);
            }
            return complainsDTOs;
        }
        
        public ComplainDTO Edit(int Id)
        {
            Complain complain = context.Complains.Find(Id);
ComplainDTO complainDTO = new ComplainDTO()
            {
               Id=complain.Id,
               Name=complain.Name,
                Phone=complain.Phone,
                Details=complain.Details,
                Title=complain.Title,
                UserId=complain.UserId

            };

            return complainDTO;
        }
        
        public ComplainDTO EditReplay(int Id)
        {
            Complain complain = context.Complains.Find(Id);
            ComplainDTO complainDTO = new ComplainDTO()
            {
                Id = complain.Id,
                Name = complain.Name,
                Phone = complain.Phone,
                Details = complain.Details,
                Title = complain.Title,
                UserId = complain.UserId,
                Note = complain.Note,
                Status= complain.Status,
            };

            return complainDTO;
        }
        
        public List<ComplainDTO> loadComplain(string Id)
        {
           List<Complain> complains = context.Complains.Where(e => e.UserId == Id).ToList();
            List<ComplainDTO> complainsDTOs = new List<ComplainDTO>();
            foreach (Complain item in complains)
            {
                ComplainDTO ll = new ComplainDTO();
                ll.Id = item.Id;
                ll.Name = item.Name;
                ll.Phone = item.Phone;
                ll.Details = item.Details;
                ll.Title = item.Title;
                complainsDTOs.Add(ll);
            }
            return complainsDTOs;
        }
        
        public List<ComplainDTO> loadDone()
        {
            List<Complain> complains = context.Complains.Where(a=>a.Status=="Done").ToList();
            List<ComplainDTO> complainsDTOs = new List<ComplainDTO>();
            foreach (Complain item in complains)
            {
                ComplainDTO ll = new ComplainDTO();
                ll.Id = item.Id;
                ll.Name = item.Name;
                ll.Phone = item.Phone;
                ll.Details = item.Details;
                ll.Title = item.Title;
                complainsDTOs.Add(ll);
            }
            return complainsDTOs;
        }
    }
}
