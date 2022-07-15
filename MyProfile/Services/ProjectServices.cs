using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MyProfile.Data.IRepository;
using MyProfile.Models;
using MyProfile.Services.IServices;
using MyProfile.ViewModel;

namespace MyProfile.Services
{
    public class ProjectServices:IProjectServices
    {
        private readonly IProjectRepository _project;
        private readonly IMapper _mapper;

        public ProjectServices(IProjectRepository project, IMapper mapper)
        {
            _project = project;
            _mapper = mapper;

        }
        public async Task<IEnumerable<Project>> AllList()
        {
            return  await _project.GetAll();
        }

        public async Task<Project> GetById(int id)
        {
            return await _project.GetByIdAsync(id);
        }
        public async Task<bool> Create(ListOfProjectViewModel project)
        {
            var addProject = _mapper.Map<Project>(project);
            return await _project.Add(addProject);
        }
        public async Task<bool> EditByDetails(Project project)
        {
           // var editInfo = _mapper.Map<Project>(project);
            return await _project.UpdateDataToDb(project);
        }

        public async Task<bool> RemovedData(Project project)
        {
            return await _project.DeleteFromDb(project);
        }
    }
}
