using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyProfile.Data.IRepository;
using MyProfile.Models;

namespace MyProfile.Data.Repository
{
    public class ExperienceRepository:IExperienceRepository
    {
        private readonly AppDbContext _context;

        public ExperienceRepository(AppDbContext context)
        {
            _context = context;
                
        }
        public async Task<IEnumerable<Experience>> GetAll()
        {
            return await _context.Experience.ToListAsync();
        }

        public async Task<Experience> GetByIdAsync(int id)
        {
            return await _context.Experience.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task <bool> Add(Experience experience)
        {
            _context.Add(experience);
            return await Save();
        }
        public async Task<bool> UpdateDataToDb(Experience experience)
        {
            _context.Experience.Update(experience);
            return await Save();
        }

        public async Task<bool>  DeleteFromDb(Experience experience)
        {
            _context.Experience.Remove(experience);
            return await Save();
        }
        public async Task<bool> Save()
        {
            var saved = await  _context.SaveChangesAsync();
            return saved > 0;
        }
    }
}
