using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookList.Pages
{
    public class BookListModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public BookListModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<book> Books { get; set; }
        public async Task OnGet()
        {
            Books = await _db.Book.ToListAsync();
        }
    }
}
