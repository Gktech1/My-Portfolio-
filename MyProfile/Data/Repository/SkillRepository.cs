using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyProfile.Data.IRepository;
using MyProfile.Models;

namespace MyProfile.Data.Repository
{
    public class SkillRepository:ISkillRepository
    {
        private readonly  AppDbContext _context;

        public SkillRepository(AppDbContext context)
        {
                _context = context;
        }
        public async Task<IEnumerable<Skill>> GetAll()
        {
            return await _context.Skill.ToListAsync();
        }

        public async Task<Skill> GetByIdAsync(int id)
        {
            return await _context.Skill.Include(i => i.Name).FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<bool> Add(Skill skill)
        {
            _context.Add(skill);
            return await Save();
        }
        public async Task<bool> UpdateDataToDb(Skill skill)
        {
            _context.Skill.Update(skill);
            return await Save();
        }

        public async Task<bool> DeleteFromDb(Skill skill)
        {
            _context.Skill.Remove(skill);
            return await Save();
        }
        public async Task<bool> Save()
        {
            var saved = await _context.SaveChangesAsync();
            return saved > 0;
        }
    }
}
