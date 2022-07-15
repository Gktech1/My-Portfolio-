using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyProfile.Migrations;
using MyProfile.Models;
using MyProfile.Services.IServices;
using MyProfile.ViewModel;

namespace MyProfile.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly IExperienceServices _experience;
        private readonly IMapper _mapper;

        public ExperienceController(IExperienceServices experience, IMapper mapper)
        {

            _experience = experience;
            _mapper = mapper;
            
        }

        public async Task<IActionResult> Index()
        {
            var result = await _experience.AllList();
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
            var data = await  _experience.GetById(id);
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Experience experience)
        {
            if (!ModelState.IsValid)
            {
                return View(experience);
            }
            else
            {
                await _experience.EditByDetails(experience);
                TempData["Success"] = "The item has been successfully Updated!";
                
            }

            return RedirectToAction("Index", "Dashboard");
        }

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(ListOfExperiencesViewModel expView)
        {
            if (ModelState.IsValid)
            { 
                await _experience.Create(expView);
                TempData["Success"] = "The item has been successfully Created!";
            }
            return RedirectToAction("Index", "Dashboard");
        }
        public async Task<IActionResult> Delete(Experience experience)
        {
            if (ModelState.IsValid)
            {
                await _experience.RemovedData(experience);
                TempData["Success"] = "The details has been deleted successfully";
            }
            
            return RedirectToAction("Index", "Dashboard");

        }
    }
}
