using Microsoft.AspNetCore.Mvc;
using Validations.Models;

namespace Validations.Controllers
{
    public class UserController : Controller
    {
        private readonly ValidationsDbContext _context;
        private readonly GenerateSuggestions _suggestion;

        public UserController(ValidationsDbContext context, GenerateSuggestions suggestion)
        {
            _context = context;
            _suggestion = suggestion;
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(u => u.Email == model.Email))
                {
                    var suggestedMails = await _suggestion.GenerateUniquetEmail(model.Email, 2);

                    ModelState.AddModelError("Email", $"Email is in use, try anyone of these : {suggestedMails}");
                }

                if (_context.Users.Any(u => u.UserName == model.UserName))
                {
                    var suggestedNames = await _suggestion.GenerateUniqueUserNames(model.UserName, 2);

                    ModelState.AddModelError("UserName", $"User Name is in use, try anyone of these : {suggestedNames}");
                }

                if (ModelState.IsValid)
                {
                    User user = new User
                    {
                        Email = model.Email,
                        UserName = model.UserName,
                        Password = model.Password,
                    };

                    await _context.Users.AddAsync(user);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Success");
                }
            }
            return View(model); 
        }

        public string Success()
        {
            return "User Added Successfully";
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
