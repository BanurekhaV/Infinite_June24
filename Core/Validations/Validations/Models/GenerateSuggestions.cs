
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Validations.Models
{
    public class GenerateSuggestions
    {
        private readonly ValidationsDbContext _context;
        public GenerateSuggestions(ValidationsDbContext context) 
        {
            _context = context;
        }

        public async Task<string>GenerateUniquetEmail(string baseEmail, int count=1)
        {
            var suggestions = new List<string>();
            string emailPrefix = baseEmail.Split('@')[0];
            string emailDomain = baseEmail.Split('@')[1];

            string suggestion;

            while (suggestions.Count < count)
            {
                do
                {
                    suggestion = $"{emailPrefix}{new Random().Next(100,999)}@{emailDomain}";
                    //use anyasync to check if email exists
                }while (await _context.Users.AnyAsync(u =>u.Email == suggestion) ||
                suggestions.Contains(suggestion));

                suggestions.Add(suggestion);
            }

            return string.Join(" , ", suggestions);
        }

        public async Task<string> GenerateUniqueUserNames(string baseUserName, int count=1)
        {
            var suggestions = new List<string>();

            string suggestion;

            while (suggestions.Count < count)
            {
                do
                {
                    suggestion = $"{baseUserName}{new Random().Next(100, 999)}";
                    //use anyasync to check if email exists
                } while (await _context.Users.AnyAsync(u => u.UserName == suggestion) ||
                suggestions.Contains(suggestion));

                suggestions.Add(suggestion);
            }

            return string.Join(" , ", suggestions);
        }
    }
}
