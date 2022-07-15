using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProfile.Models;
using MyProfile.Services.IServices;
using MyProfile.ViewModel;

namespace MyProfile.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectServices _project;

        public ProjectController(IProjectServices project)
        {
            _project = project;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _project.AllList();
            if (result != null)
            {
                return View(result);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var data =  await _project.GetById(id);
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Project project)
        {
            if (!ModelState.IsValid)
            {
                return View(project);
            }
            else
            {
                await _project.EditByDetails(project);
                TempData["Success"] = "The item has been successfully Updated!";

            }

            return RedirectToAction("Index", "Dashboard");
        }

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(ListOfProjectViewModel project)
        {
            if (ModelState.IsValid)
            {
                await _project.Create(project);
                TempData["Success"] = "The item has been successfully Created!";
            }
            return RedirectToAction("Index", "Dashboard");
        }
        public async Task<IActionResult> Delete(Project project)
        {
            if (ModelState.IsValid)
            {
                await _project.RemovedData(project);
                TempData["Success"] = "The details has been deleted successfully";
            }

            return RedirectToAction("Index", "Dashboard");

        }
       /* public IActionResult Details()
        {
            return View();
        }*/
    }
}
