using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BookList.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList.Pages
{
    public class OverViewModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public OverViewModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public book book { get; set; }
        public async Task OnGet(int id)
        {
            book = await _db.Book.FindAsync(id);
        }

    }
}
