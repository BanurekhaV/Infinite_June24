using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Validations.Models;


namespace Validations.Controllers
{
    public class RemoteValidationController : Controller
    {
        private readonly ValidationsDbContext _context;
        private readonly GenerateSuggestions generateSuggestions;

        public RemoteValidationController(ValidationsDbContext context, GenerateSuggestions generateSuggestions)
        {
            _context = context;
            this.generateSuggestions = generateSuggestions;
        }

        [AcceptVerbs("GET", "POST")]
        public async Task<IActionResult>IsEmailAvailable(string email)
        {
            if(!await _context.Users.AnyAsync(u =>u.Email == email))
                return Json(true);

            var suggestedEmails = await generateSuggestions.GenerateUniquetEmail(email, 3);
            return Json($"Email is already in use.. Try anyone of these :{suggestedEmails}");
        }

        [AcceptVerbs("GET","POST")]
        public async Task<IActionResult>IsUserNameAvailable(string username)
        {
            if (!await _context.Users.AnyAsync(u => u.UserName == username))
                return Json(true);

            var suggestedUsernames = await generateSuggestions.GenerateUniqueUserNames(username, 3);
            return Json($"User Name is already in use.. Try anyone of these :{suggestedUsernames}");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
