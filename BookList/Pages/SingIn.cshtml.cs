using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList.Pages
{
    public class SingInModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public SingInModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Account account { get; set; }
        public string msg;

        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPost()
        {
            var acc = login(account.username, account.password);
            if(acc == null)
            {
                msg = "Invalid";
                return Page();
            }
            else
            {
                HttpContext.Session.SetString("usarname", acc.username);
                return RedirectToPage("Index");
            }
        }

        private Account login(string username, string password)
        {
            var account = _db.Account.SingleOrDefault(a => a.username.Equals(username));
            if(account != null)
            {
                if(BCrypt.Net.BCrypt.Verify(password, account.password))
                {
                    return account;
                }
            }
            return null;
        }
    }
}
