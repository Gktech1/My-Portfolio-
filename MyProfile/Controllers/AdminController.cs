using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyProfile.Data;
using MyProfile.ViewModel;

namespace MyProfile.Controllers
{
    public class AdminController : Controller
    {
        private  readonly SignInManager<IdentityUser> _signInManager;
        private readonly AppDbContext _context;
        public AdminController(SignInManager<IdentityUser> signInManager, AppDbContext context)
        {
            _signInManager = signInManager;
            _context = context;
                
        }
        public IActionResult Dashboard()
        {
             DashboardViewModel dashboard = new DashboardViewModel()
            {

              Experiences  = _context.Experience.ToList(),
              Skills = _context.Skill.ToList(),
              Projects = _context.Project.ToList()
            };
        

            return View(dashboard);
        }
    }
}
