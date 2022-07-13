using System.Collections.Generic;
using System.Threading.Tasks;
using MyProfile.Models;
using MyProfile.ViewModel;

namespace MyProfile.Services.IServices
{
    public interface IProjectServices
    {
        Task<IEnumerable<Project>> AllList();
        Task<Project> GetById(int id);
        Task<bool> Create(ListOfProjectViewModel project);
        Task<bool> EditByDetails(ListOfProjectViewModel project);
        Task<bool> RemovedData(Project project);
    }
}
