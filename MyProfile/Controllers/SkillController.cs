using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProfile.Data.IRepository;
using MyProfile.Models;
using MyProfile.Services.IServices;
using MyProfile.ViewModel;

namespace MyProfile.Controllers
{
    public class SkillController : Controller
    {
        private readonly ISkillServices _skill;

        public SkillController(ISkillServices skill)
        {
            _skill = skill;
            
        }

        public async Task<IActionResult> Index()
        {
            var result = await _skill.AllList();
            if (result != null)
            {
                return View(result);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            if (id == 0)
                return NotFound();
            var data = await _skill.GetById(id);
            return View(data);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Skill skill)
        {
            if (!ModelState.IsValid)
            {
                return View(skill);
            }
            else
            {
                await _skill.EditByDetails(skill);
                TempData["Success"] = "The item has been successfully Updated!";

            }

            return RedirectToAction("Dashboard", "Admin");
        }

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(LIstOfSkillsViewModel skill)
        {
            if (ModelState.IsValid)
            {
                await _skill.Create(skill);
                TempData["Success"] = "The item has been successfully Created!";
            }
            return RedirectToAction("Dashboard", "Admin");
        }
        public async Task<IActionResult> Delete(Skill skill)
        {
            if (ModelState.IsValid)
            {
                await _skill.RemovedData(skill);
                TempData["Success"] = "The details has been deleted successfully";
            }

            return RedirectToAction("Dashboard", "Admin");

        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
