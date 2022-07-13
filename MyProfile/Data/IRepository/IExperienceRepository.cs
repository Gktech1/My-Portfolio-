using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyProfile.Models;

namespace MyProfile.Data.IRepository
{
    public interface IExperienceRepository
    {
        Task<IEnumerable<Experience>> GetAll();
        Task<Experience> GetByIdAsync(int id);
        Task<bool> Add(Experience experience);
        Task<bool> UpdateDataToDb(Experience experience);
       Task <bool> DeleteFromDb(Experience experience);
       Task<bool>  Save(); 

    }
}
