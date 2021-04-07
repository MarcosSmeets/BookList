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
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public book book { get; set; }
        public async Task<IActionResult> OnGet(int id)
        {
            book = await _db.Book.FirstOrDefaultAsync(u => u.idBook == id);
            if (book == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var bookFromDb = await _db.Book.FindAsync(book.idBook);
                bookFromDb.bookName = book.bookName;
                bookFromDb.authorName = book.authorName;
                bookFromDb.genre = book.genre;
                bookFromDb.sinopseBook = book.sinopseBook;
                bookFromDb.yearRelease = book.yearRelease;
                bookFromDb.famousQuote = book.famousQuote;

                await _db.SaveChangesAsync();
                return RedirectToPage("BookList");
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}
