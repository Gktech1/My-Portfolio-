using System.Collections.Generic;
using System.Threading.Tasks;
using MyProfile.Models;
using MyProfile.ViewModel;

namespace MyProfile.Services.IServices
{
    public interface ISkillServices
    {
        Task<IEnumerable<Skill>> AllList();
        Task<Skill> GetById(int id);
        Task<bool> Create(LIstOfSkillsViewModel skill);
        Task<bool> EditByDetails(Skill skill);
        Task<bool> RemovedData(Skill skill);
    }
}
