using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MyProfile.Data.IRepository;
using MyProfile.Models;
using MyProfile.Services.IServices;
using MyProfile.ViewModel;

namespace MyProfile.Services
{
    public class ExperienceServices : IExperienceServices
    {

        private readonly IExperienceRepository _experience;
        private readonly IMapper _mapper;

        public ExperienceServices(IExperienceRepository experience, IMapper mapper)
        {
            _experience = experience;
            _mapper = mapper;
                
        }
        public async Task<IEnumerable<Experience>> AllList()
        {
            return await _experience.GetAll();
        }

        public async Task<Experience> GetById(int id)
        {
            return await _experience.GetByIdAsync(id);
        }

        public async Task<bool> Create(ListOfExperiencesViewModel expView)
        {
            var addExp = _mapper.Map<Experience>(expView);
            return await _experience.Add(addExp);
        }
        public async Task <bool> EditByDetails(Experience experience)
        {
            return await _experience.UpdateDataToDb(experience);
        }

        public async Task<bool> RemovedData(Experience experience)
        {
            return await _experience.DeleteFromDb(experience);
        }
    }
}
