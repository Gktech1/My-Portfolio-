using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyProfile.Data;
using MyProfile.ViewModel;

namespace MyProfile.Controllers
{
    public class DashboardController : Controller
    {
        private  readonly SignInManager<IdentityUser> _signInManager;
        private readonly AppDbContext _context;
        public DashboardController(SignInManager<IdentityUser> signInManager, AppDbContext context)
        {
            _signInManager = signInManager;
            _context = context;
                
        }
        public IActionResult Index()
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
