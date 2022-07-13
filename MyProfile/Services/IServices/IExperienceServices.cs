using System.Collections.Generic;
using System.Threading.Tasks;
using MyProfile.Models;
using MyProfile.ViewModel;

namespace MyProfile.Services.IServices
{
    public interface IExperienceServices 
    {
        Task<IEnumerable<Experience>> AllList();
        Task<Experience> GetById(int id); 
        Task<bool> Create(ListOfExperiencesViewModel expView);
        public Task<bool> EditByDetails(ListOfExperiencesViewModel expView);
        Task<bool> RemovedData(Experience experience);
        
    }
}
