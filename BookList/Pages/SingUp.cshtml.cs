using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList.Pages
{
    public class SingUpModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public SingUpModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Account account { get; set; }

        public void OnGet()
        {
            account = new Account();
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                account.password = BCrypt.Net.BCrypt.HashPassword(account.password);
                await _db.Account.AddAsync(account);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
