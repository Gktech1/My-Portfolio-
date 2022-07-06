using Microsoft.AspNetCore.Mvc;

namespace Profile.Controllers.UserController
{
    public class UserController : Controller
    {
        //GET: /controller/
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Project()
        {
            return View();
        }

        /* public IActionResult Create()
         {
             if (!ModelState.IsValid)
             {
                 return View(model);
             }

             o
             userManger.findbyEmail(model.Email);
         }*/
    }
}
